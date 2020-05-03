using NAudio.Wave;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace quick_screen_recorder
{
	public partial class MainForm : Form
	{
		private AreaForm areaForm;
		private StopForm stopForm;

		private Recorder newRecorder = null;

		public MainForm()
		{
			InitializeComponent();

			areaForm = new AreaForm();
			areaForm.Owner = this;

			folderTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			qualityComboBox.SelectedIndex = 2;
			areaComboBox.SelectedIndex = 0;
			inputDeviceComboBox.SelectedIndex = 0;

			for (int i = 0; i < WaveIn.DeviceCount; i++)
			{
				inputDeviceComboBox.Items.Add(WaveIn.GetCapabilities(i).ProductName);
			}
		}

		public void SetAreaWidth(int w)
		{
			if (w > widthNumeric.Maximum)
			{
				widthNumeric.Value = widthNumeric.Maximum;
			}
			else
			{
				if (w < widthNumeric.Minimum)
				{
					widthNumeric.Value = widthNumeric.Minimum;
				}
				else
				{
					widthNumeric.Value = w;
				}
			}
		}

		public void SetAreaHeight(int h)
		{
			if (h > heightNumeric.Maximum)
			{
				heightNumeric.Value = heightNumeric.Maximum;
			}
			else
			{
				if (h < widthNumeric.Minimum)
				{
					heightNumeric.Value = heightNumeric.Minimum;
				}
				else
				{
					heightNumeric.Value = h;
				}
			}
		}

		private void recButton_Click(object sender, EventArgs e)
		{
			StartRec();
		}

		public void StopRec()
		{
			try
			{
				HotkeyManager.RegisterHotKey(this.Handle, 0, (int)HotkeyManager.KeyModifier.Alt, Keys.R.GetHashCode());

				if (areaComboBox.SelectedIndex == 1)
				{
					areaForm.Show();
				}

				newRecorder.Dispose();
				newRecorder = null;
			}
			catch
			{
				MessageBox.Show("Something went wrong!", "Error");
			}
		}

		private void StartRec()
		{
			try
			{
				string folder = folderTextBox.Text;
				string fileName = fileNameTextBox.Text;
				int quality = Convert.ToInt32(string.Concat(qualityComboBox.Text.Where(char.IsDigit)));
				int inputSourceIndex = inputDeviceComboBox.SelectedIndex - 2;

				int x = 0;
				int y = 0;
				int width = 0;
				int height = 0;

				if (areaComboBox.SelectedIndex == 1)
				{
					x = areaForm.Location.X + 1;
					y = areaForm.Location.Y + 1;
					width = (int)widthNumeric.Value;
					height = (int)heightNumeric.Value;
				}
				else
				{
					x = 0;
					y = 0;
					width = Screen.PrimaryScreen.Bounds.Width;
					height = Screen.PrimaryScreen.Bounds.Height;
				}

				newRecorder = new Recorder(folder + "/" + fileName + ".avi", quality, x, y, width, height, captureCursorCheckBox.Checked, inputSourceIndex);

				areaForm.Hide();
				this.Hide();

				HotkeyManager.UnregisterHotKey(this.Handle, 0);

				stopForm = new StopForm(DateTime.Now);
				stopForm.Owner = this;
				stopForm.Show();
			}
			catch
			{
				MessageBox.Show("Something went wrong!", "Error");
			}
		}

		private void browseFolderBtn_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				folderTextBox.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void aboutBtn_Click(object sender, EventArgs e)
		{
			AboutBox1 ab = new AboutBox1();
			if (ab.ShowDialog() == DialogResult.OK)
			{

			}
		}

		private void areaComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (areaComboBox.SelectedIndex == 1)
			{
				areaForm.Show();

				widthNumeric.Text = (areaForm.Width - 2).ToString();
				heightNumeric.Text = (areaForm.Height - 2).ToString();

				widthNumeric.Enabled = true;
				heightNumeric.Enabled = true;
			}
			else
			{
				areaForm.Hide();

				widthNumeric.Enabled = false;
				heightNumeric.Enabled = false;

				widthNumeric.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
				heightNumeric.Text = Screen.PrimaryScreen.Bounds.Height.ToString();
			}
		}

		private void widthNumeric_ValueChanged(object sender, EventArgs e)
		{
			if (widthNumeric.Enabled)
			{
				areaForm.Width = (int)widthNumeric.Value + 2;
			}
		}

		private void heightNumeric_ValueChanged(object sender, EventArgs e)
		{
			if (heightNumeric.Enabled)
			{
				areaForm.Height = (int)heightNumeric.Value + 2;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			HotkeyManager.RegisterHotKey(this.Handle, 0, (int)HotkeyManager.KeyModifier.Alt, Keys.R.GetHashCode());
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == 0x0312)
			{
				Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
				HotkeyManager.KeyModifier modifier = (HotkeyManager.KeyModifier)((int)m.LParam & 0xFFFF);

				if (modifier == HotkeyManager.KeyModifier.Alt)
				{
					if (key == Keys.R)
					{
						StartRec();
					}
				}
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			HotkeyManager.UnregisterHotKey(this.Handle, 0);
		}
	}
}
