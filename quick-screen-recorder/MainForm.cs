using NAudio.Wave;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace quick_screen_recorder
{
	public partial class MainForm : Form
	{
		private AreaForm areaForm;
		private StopForm stopForm;

		private Recorder recorder = null;

		private bool darkMode;

		public MainForm(bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			this.darkMode = darkMode;

			InitializeComponent();

			areaForm = new AreaForm();
			areaForm.Owner = this;

			folderTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			qualityComboBox.SelectedIndex = 2;
			areaComboBox.SelectedIndex = 0;
			inputDeviceComboBox.SelectedIndex = 0;

			RefreshAudioDevices();

			if (darkMode)
			{
				applyDarkTheme();
			}
		}

		private void applyDarkTheme()
		{
			this.ForeColor = Color.White;
			this.BackColor = ThemeManager.DarkBackColor;

			recButton.BackColor = ThemeManager.DarkSecondColor;
			recButton.Image = Properties.Resources.white_record;

			browseFolderBtn.BackColor = ThemeManager.DarkSecondColor;

			toolStrip1.SetDarkMode(true, false);
			aboutBtn.Image = Properties.Resources.white_about;
			onTopBtn.Image = Properties.Resources.white_ontop;
			settingsBtn.Image = Properties.Resources.white_settings;

			fileNameTextBox.BackColor = ThemeManager.DarkSecondColor;
			fileNameTextBox.ForeColor = Color.White;

			folderTextBox.BackColor = ThemeManager.DarkSecondColor;
			folderTextBox.ForeColor = Color.White;

			generalGroup.Paint += ThemeManager.PaintDarkGroupBox;
			videoGroup.Paint += ThemeManager.PaintDarkGroupBox;
			audioGroup.Paint += ThemeManager.PaintDarkGroupBox;

			qualityComboBox.SetDarkMode(true);
			inputDeviceComboBox.SetDarkMode(true);
			areaComboBox.SetDarkMode(true);

			widthNumeric.SetDarkMode(true);
			heightNumeric.SetDarkMode(true);

			refreshBtn.BackColor = ThemeManager.DarkSecondColor;
			refreshBtn.Image = Properties.Resources.white_refresh;

			separateAudioCheckBox.SetDarkMode(true);
			captureCursorCheckBox.SetDarkMode(true);
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

		public async void checkForUpdates(bool showUpToDateDialog)
		{
			try
			{
				UpdateChecker checker = new UpdateChecker("ModuleArt", "quick-screen-recorder");

				bool update = await checker.CheckUpdate();

				if (update == false)
				{
					if (showUpToDateDialog)
					{
						MessageBox.Show("Application is up to date", "Updator", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					UpdateForm updateDialog = new UpdateForm(checker, "Quick Screen Recorder", darkMode);
					updateDialog.TopMost = this.TopMost;

					DialogResult result = updateDialog.ShowDialog();
					if (result == DialogResult.Yes)
					{
						DownloadForm downloadBox = new DownloadForm(checker.GetAssetUrl("QuickScreenRecorder-Setup.msi"), darkMode);
						downloadBox.Owner = this;
						downloadBox.TopMost = this.TopMost;
						downloadBox.ShowDialog();
					}
					else
					{
						updateDialog.Dispose();
					}
				}
			}
			catch
			{
				if (showUpToDateDialog)
				{
					MessageBox.Show("Connection error", "Updator", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

				recorder.Dispose();
				recorder.OnPeakVolumeChanged -= Recorder_OnPeakVolumeChanged;
				recorder = null;
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

				recorder = new Recorder(folder + "/" + fileName + ".avi", 
					quality, x, y, width, height, captureCursorCheckBox.Checked, 
					inputSourceIndex, separateAudioCheckBox.Checked);
				recorder.OnPeakVolumeChanged += Recorder_OnPeakVolumeChanged;

				areaForm.Hide();
				this.Hide();

				HotkeyManager.UnregisterHotKey(this.Handle, 0);

				string videoStr = videoStr = width + "x" + height + " (" + quality + "%";
				if (captureCursorCheckBox.Checked)
				{
					videoStr += ", Cursor";
				}
				videoStr += ")";

				string audioStr = inputDeviceComboBox.Text;

				stopForm = new StopForm(DateTime.Now, darkMode, videoStr, audioStr);
				stopForm.Owner = this;
				stopForm.Show();
			}
			catch
			{
				MessageBox.Show("Something went wrong!", "Error");
			}
		}

		private void Recorder_OnPeakVolumeChanged(object sender, OnPeakVolumeChangedArgs e)
		{
			if (stopForm != null)
			{
				stopForm.UpdateVolumeBar(e.Volume);
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
			AboutForm aboutBox = new AboutForm(darkMode);
			aboutBox.Owner = this;
			if (this.TopMost)
			{
				aboutBox.TopMost = true;
			}
			aboutBox.ShowDialog();
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

			onTopBtn.Checked = Properties.Settings.Default.AlwaysOnTop;
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

		private void onTopCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = onTopBtn.Checked;
			Properties.Settings.Default.AlwaysOnTop = onTopBtn.Checked;
			Properties.Settings.Default.Save();
		}

		public void MuteRecorder(bool b)
		{
			recorder.Mute = b;
		}

		private void refreshBtn_Click(object sender, EventArgs e)
		{
			RefreshAudioDevices();
		}

		private void RefreshAudioDevices()
		{
			inputDeviceComboBox.SelectedIndex = 0;

			while (inputDeviceComboBox.Items.Count > 2)
			{
				inputDeviceComboBox.Items.RemoveAt(inputDeviceComboBox.Items.Count - 1);
			}

			for (int i = 0; i < WaveIn.DeviceCount; i++)
			{
				inputDeviceComboBox.Items.Add(WaveIn.GetCapabilities(i).ProductName);
			}
		}

		private void settingsBtn_Click(object sender, EventArgs e)
		{
			SettingsForm settingsBox = new SettingsForm(darkMode);
			settingsBox.Owner = this;
			if (this.TopMost)
			{
				settingsBox.TopMost = true;
			}
			settingsBox.ShowDialog();
		}

		private void inputDeviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			separateAudioCheckBox.Enabled = inputDeviceComboBox.SelectedIndex != 0;
		}
	}
}
