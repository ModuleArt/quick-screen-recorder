using NAudio.Wave;
using System;
using System.Data;
using System.Drawing;
using System.IO;
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

			inputDeviceComboBox.SelectedIndex = 0;

			RefreshScreens();
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
			xNumeric.SetDarkMode(true);
			yNumeric.SetDarkMode(true);

			refreshAudioBtn.BackColor = ThemeManager.DarkSecondColor;
			refreshAudioBtn.Image = Properties.Resources.white_refresh;

			refreshScreensBtn.BackColor = ThemeManager.DarkSecondColor;
			refreshScreensBtn.Image = Properties.Resources.white_refresh;

			separateAudioCheckBox.SetDarkMode(true);
			captureCursorCheckBox.SetDarkMode(true);
			hideTaskbarCheckBox.SetDarkMode(true);
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

		public void SetAreaX(int x)
		{
			if (x > xNumeric.Maximum)
			{
				xNumeric.Value = xNumeric.Maximum;
			}
			else
			{
				if (x < xNumeric.Minimum)
				{
					xNumeric.Value = xNumeric.Minimum;
				}
				else
				{
					xNumeric.Value = x;
				}
			}
		}

		public void SetAreaY(int y)
		{
			if (y > yNumeric.Maximum)
			{
				yNumeric.Value = yNumeric.Maximum;
			}
			else
			{
				if (y < xNumeric.Minimum)
				{
					yNumeric.Value = yNumeric.Minimum;
				}
				else
				{
					yNumeric.Value = y;
				}
			}
		}

		public void SetMaximumX(int maxX)
		{
			xNumeric.Maximum = maxX;
		}

		public void SetMaximumY(int maxY)
		{
			yNumeric.Maximum = maxY;
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
			CheckStartRec();
		}

		public void StopRec()
		{
			try
			{
				HotkeyManager.RegisterHotKey(this.Handle, 0, (int)HotkeyManager.KeyModifier.Alt, Keys.R.GetHashCode());

				if (areaComboBox.SelectedIndex == areaComboBox.Items.Count - 1)
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

		private void CheckStartRec()
		{
			string path = folderTextBox.Text + "/" + fileNameTextBox.Text + ".avi";

			if (File.Exists(path))
			{
				DialogResult window = MessageBox.Show(
					fileNameTextBox.Text + ".avi already exists.\nDo you want to replace it and start recording?",
					"Warning",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);

				if (window == DialogResult.Yes)
				{
					StartRec(path);
				}
			}
			else
			{
				StartRec(path);
			}
		}

		private void StartRec(string path)
		{
			try
			{
				int quality = 0;
				int.TryParse(string.Concat(qualityComboBox.Text.Where(char.IsDigit)), out quality);
				int inputSourceIndex = inputDeviceComboBox.SelectedIndex - 2;

				int width = (int)widthNumeric.Value;
				int height = (int)heightNumeric.Value;
				int x = (int)xNumeric.Value;
				int y = (int)yNumeric.Value;

				recorder = new Recorder(path, 
					quality, x, y, width, height, captureCursorCheckBox.Checked, 
					inputSourceIndex, separateAudioCheckBox.Checked);
				recorder.OnPeakVolumeChanged += Recorder_OnPeakVolumeChanged;

				areaForm.Hide();
				this.Hide();

				HotkeyManager.UnregisterHotKey(this.Handle, 0);

				string videoStr = videoStr = width + "x" + height + " (";
				if (quality == 0)
				{
					videoStr += "Uncompressed";
				}
				else
				{
					videoStr += quality + "%";
				}
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
			RefreshAreaInfo();
		}

		private void RefreshAreaInfo()
		{
			if (areaComboBox.SelectedIndex == areaComboBox.Items.Count - 1)
			{
				areaForm.Show();

				widthNumeric.Text = areaForm.Width.ToString();
				heightNumeric.Text = areaForm.Height.ToString();
				xNumeric.Text = areaForm.Left.ToString();
				yNumeric.Text = areaForm.Top.ToString();

				widthNumeric.Enabled = true;
				heightNumeric.Enabled = true;
				xNumeric.Enabled = true;
				yNumeric.Enabled = true;

				hideTaskbarCheckBox.Enabled = false;
			}
			else
			{
				areaForm.Hide();

				widthNumeric.Enabled = false;
				heightNumeric.Enabled = false;
				xNumeric.Enabled = false;
				yNumeric.Enabled = false;

				hideTaskbarCheckBox.Enabled = true;

				if (Screen.AllScreens.Length > 1)
				{
					if (areaComboBox.SelectedIndex == areaComboBox.Items.Count - 2)
					{
						widthNumeric.Text = SystemInformation.VirtualScreen.Width.ToString();
						heightNumeric.Text = SystemInformation.VirtualScreen.Height.ToString();
						xNumeric.Text = SystemInformation.VirtualScreen.Left.ToString();
						yNumeric.Text = SystemInformation.VirtualScreen.Top.ToString();

						hideTaskbarCheckBox.Enabled = false;
					}
					else
					{
						hideTaskbarCheckBox.Enabled = true;

						if (hideTaskbarCheckBox.Checked)
						{
							widthNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].WorkingArea.Width.ToString();
							heightNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].WorkingArea.Height.ToString();
							xNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].WorkingArea.X.ToString();
							yNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].WorkingArea.Y.ToString();
						}
						else
						{
							widthNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].Bounds.Width.ToString();
							heightNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].Bounds.Height.ToString();
							xNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].Bounds.X.ToString();
							yNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].Bounds.Y.ToString();
						}
					}
				}
				else
				{
					if (hideTaskbarCheckBox.Checked)
					{
						widthNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].WorkingArea.Width.ToString();
						heightNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].WorkingArea.Height.ToString();
						xNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].WorkingArea.X.ToString();
						yNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].WorkingArea.Y.ToString();
					}
					else
					{
						widthNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].Bounds.Width.ToString();
						heightNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].Bounds.Height.ToString();
						xNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].Bounds.X.ToString();
						yNumeric.Text = Screen.AllScreens[areaComboBox.SelectedIndex].Bounds.Y.ToString();
					}

					hideTaskbarCheckBox.Enabled = true;
				}
			}
		}

		private void widthNumeric_ValueChanged(object sender, EventArgs e)
		{
			if (widthNumeric.Enabled)
			{
				areaForm.Width = (int)widthNumeric.Value;
			}
		}

		private void heightNumeric_ValueChanged(object sender, EventArgs e)
		{
			if (heightNumeric.Enabled)
			{
				areaForm.Height = (int)heightNumeric.Value;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			HotkeyManager.RegisterHotKey(this.Handle, 0, (int)HotkeyManager.KeyModifier.Alt, Keys.R.GetHashCode());

			onTopBtn.Checked = Properties.Settings.Default.AlwaysOnTop;
			qualityComboBox.SelectedIndex = Properties.Settings.Default.QualityIndex;
			captureCursorCheckBox.Checked = Properties.Settings.Default.CaptureCursor;
			hideTaskbarCheckBox.Checked = Properties.Settings.Default.HideTaskbar;
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
						CheckStartRec();
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

		private void RefreshScreens()
		{
			areaComboBox.Items.Clear();

			for (int i = 0; i < Screen.AllScreens.Length; i++)
			{
				if (Screen.AllScreens[i].Primary)
				{
					areaComboBox.Items.Add("Primary screen (" + Screen.AllScreens[i].Bounds.Width + "x" + Screen.AllScreens[i].Bounds.Height + ")");
				}
				else
				{
					areaComboBox.Items.Add("Screen " + (i + 1) + " (" + Screen.AllScreens[i].Bounds.Width + "x" + Screen.AllScreens[i].Bounds.Height + ")");
				}
			}

			if (Screen.AllScreens.Length > 1)
			{
				areaComboBox.Items.Add("Everything");
			}

			areaComboBox.Items.Add("Custom area");

			areaComboBox.SelectedIndex = 0;

			widthNumeric.Maximum = SystemInformation.VirtualScreen.Width;
			heightNumeric.Maximum = SystemInformation.VirtualScreen.Height;
			//xNumeric.Maximum = SystemInformation.VirtualScreen.Width - areaForm.MinimumSize.Width;
			//yNumeric.Maximum = SystemInformation.VirtualScreen.Height - areaForm.MinimumSize.Height;

			areaForm.SetMaximumArea(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
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

		private void xNumeric_ValueChanged(object sender, EventArgs e)
		{
			if (xNumeric.Enabled)
			{
				areaForm.Left = (int)xNumeric.Value;
			}
		}

		private void yNumeric_ValueChanged(object sender, EventArgs e)
		{
			if (yNumeric.Enabled)
			{
				areaForm.Top = (int)yNumeric.Value;
			}
		}

		private void hideTaskbarCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			RefreshAreaInfo();
			Properties.Settings.Default.HideTaskbar = hideTaskbarCheckBox.Checked;
			Properties.Settings.Default.Save();
		}

		private void refreshScreensBtn_Click(object sender, EventArgs e)
		{
			RefreshScreens();
		}

		private void captureCursorCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.CaptureCursor = captureCursorCheckBox.Checked;
			Properties.Settings.Default.Save();
		}

		private void qualityComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.QualityIndex = qualityComboBox.SelectedIndex;
			Properties.Settings.Default.Save();
		}
	}
}
