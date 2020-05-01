using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace quick_screen_recorder
{
	public partial class MainForm : Form
	{
		private Recorder rec;
		private AreaForm areaForm;
		private DateTime startTime;

		private enum KeyModifier
		{
			None = 0,
			Alt = 1,
			Control = 2,
			Shift = 4,
			WinKey = 8
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		public MainForm()
		{
			InitializeComponent();

			areaForm = new AreaForm();
			areaForm.Owner = this;

			folderTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			fpsComboBox.SelectedIndex = 0;
			qualityComboBox.SelectedIndex = 2;
			areaComboBox.SelectedIndex = 0;
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
			ToggleRec();
		}

		private void ToggleRec()
		{
			if (rec == null)
			{
				try
				{
					string folder = folderTextBox.Text;
					string fileName = fileNameTextBox.Text;
					int fps = Convert.ToInt32(fpsComboBox.Text);
					int quality = Convert.ToInt32(string.Concat(qualityComboBox.Text.Where(char.IsDigit)));

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

					rec = new Recorder(new RecorderParams(
						folder + "/" + fileName + ".avi",
						fps,
						SharpAvi.KnownFourCCs.Codecs.MotionJpeg,
						quality,
						x,
						y,
						width,
						height
					));

					mainTimer.Start();

					areaForm.Hide();

					startTime = DateTime.Now;

					recButton.Text = "STOP";
					recButton.Image = Properties.Resources.stop;

					this.Text = "⦿ Recording - Quick Screen Recorder";
				}
				catch
				{
					MessageBox.Show("Something went wrong!", "Error");
				}
			}
			else
			{
				rec.Dispose();

				mainTimer.Stop();

				if (areaComboBox.SelectedIndex == 1)
				{
					areaForm.Show();
				}

				recButton.Text = "REC";
				recButton.Image = Properties.Resources.rec;

				this.Text = "Quick Screen Recorder";

				rec = null;
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

		private void mainTimer_Tick(object sender, EventArgs e)
		{
			DateTime tickTime = DateTime.Now;
			TimeSpan result = tickTime - startTime;
			timeLabel.Text = string.Format("{0:D2}:{1:D2}.{2:D3}", result.Minutes, result.Seconds, result.Milliseconds);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			RegisterHotKey(this.Handle, 0, (int)KeyModifier.Alt, Keys.R.GetHashCode());
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == 0x0312)
			{
				Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
				KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);

				if (modifier == KeyModifier.Alt)
				{
					if (key == Keys.R)
					{
						ToggleRec();
					}
				}
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			UnregisterHotKey(this.Handle, 0);
		}
	}
}
