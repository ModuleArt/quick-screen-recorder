namespace quick_screen_recorder
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.licenseLabel = new System.Windows.Forms.Label();
			this.darkThemeRadio = new QuickLibrary.QlibRadioButton();
			this.lightThemeRadio = new QuickLibrary.QlibRadioButton();
			this.systemThemeRadio = new QuickLibrary.QlibRadioButton();
			this.updatesCheckBox = new QuickLibrary.QlibCheckBox();
			this.settingsTabs = new QuickLibrary.QlibTabControl();
			this.themePage = new System.Windows.Forms.TabPage();
			this.audioPage = new System.Windows.Forms.TabPage();
			this.updatesPage = new System.Windows.Forms.TabPage();
			this.mixerBtn = new System.Windows.Forms.Button();
			this.winSoundBtn = new System.Windows.Forms.Button();
			this.settingsTabs.SuspendLayout();
			this.themePage.SuspendLayout();
			this.audioPage.SuspendLayout();
			this.updatesPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// licenseLabel
			// 
			this.licenseLabel.AutoSize = true;
			this.licenseLabel.Location = new System.Drawing.Point(6, 96);
			this.licenseLabel.Margin = new System.Windows.Forms.Padding(3);
			this.licenseLabel.Name = "licenseLabel";
			this.licenseLabel.Size = new System.Drawing.Size(120, 15);
			this.licenseLabel.TabIndex = 38;
			this.licenseLabel.Text = "* App restart required";
			// 
			// darkThemeRadio
			// 
			this.darkThemeRadio.Location = new System.Drawing.Point(9, 65);
			this.darkThemeRadio.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
			this.darkThemeRadio.Name = "darkThemeRadio";
			this.darkThemeRadio.Size = new System.Drawing.Size(49, 19);
			this.darkThemeRadio.TabIndex = 2;
			this.darkThemeRadio.Text = "Dark";
			this.darkThemeRadio.UseVisualStyleBackColor = true;
			this.darkThemeRadio.CheckedChanged += new System.EventHandler(this.darkThemeRadio_CheckedChanged);
			// 
			// lightThemeRadio
			// 
			this.lightThemeRadio.Location = new System.Drawing.Point(9, 37);
			this.lightThemeRadio.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
			this.lightThemeRadio.Name = "lightThemeRadio";
			this.lightThemeRadio.Size = new System.Drawing.Size(52, 19);
			this.lightThemeRadio.TabIndex = 1;
			this.lightThemeRadio.Text = "Light";
			this.lightThemeRadio.UseVisualStyleBackColor = true;
			this.lightThemeRadio.CheckedChanged += new System.EventHandler(this.lightThemeRadio_CheckedChanged);
			// 
			// systemThemeRadio
			// 
			this.systemThemeRadio.Checked = true;
			this.systemThemeRadio.Location = new System.Drawing.Point(9, 9);
			this.systemThemeRadio.Margin = new System.Windows.Forms.Padding(9);
			this.systemThemeRadio.Name = "systemThemeRadio";
			this.systemThemeRadio.Size = new System.Drawing.Size(123, 19);
			this.systemThemeRadio.TabIndex = 0;
			this.systemThemeRadio.TabStop = true;
			this.systemThemeRadio.Text = "Use system setting";
			this.systemThemeRadio.UseVisualStyleBackColor = true;
			this.systemThemeRadio.CheckedChanged += new System.EventHandler(this.systemThemeRadio_CheckedChanged);
			// 
			// updatesCheckBox
			// 
			this.updatesCheckBox.Location = new System.Drawing.Point(9, 9);
			this.updatesCheckBox.Margin = new System.Windows.Forms.Padding(9);
			this.updatesCheckBox.Name = "updatesCheckBox";
			this.updatesCheckBox.Size = new System.Drawing.Size(202, 19);
			this.updatesCheckBox.TabIndex = 0;
			this.updatesCheckBox.Text = "Check for updates on app startup";
			this.updatesCheckBox.UseVisualStyleBackColor = true;
			this.updatesCheckBox.CheckedChanged += new System.EventHandler(this.updatesCheckBox_CheckedChanged);
			// 
			// settingsTabs
			// 
			this.settingsTabs.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
			this.settingsTabs.AllowDrop = true;
			this.settingsTabs.BackTabColor = System.Drawing.Color.White;
			this.settingsTabs.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.settingsTabs.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
			this.settingsTabs.ClosingMessage = null;
			this.settingsTabs.Controls.Add(this.themePage);
			this.settingsTabs.Controls.Add(this.audioPage);
			this.settingsTabs.Controls.Add(this.updatesPage);
			this.settingsTabs.HeaderColor = System.Drawing.SystemColors.ControlLight;
			this.settingsTabs.HorizontalLineColor = System.Drawing.Color.Transparent;
			this.settingsTabs.ItemSize = new System.Drawing.Size(240, 16);
			this.settingsTabs.Location = new System.Drawing.Point(9, 9);
			this.settingsTabs.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
			this.settingsTabs.Name = "settingsTabs";
			this.settingsTabs.SelectedIndex = 0;
			this.settingsTabs.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.settingsTabs.ShowClosingButton = false;
			this.settingsTabs.ShowClosingMessage = false;
			this.settingsTabs.Size = new System.Drawing.Size(256, 145);
			this.settingsTabs.TabIndex = 13;
			this.settingsTabs.TextColor = System.Drawing.Color.Black;
			// 
			// themePage
			// 
			this.themePage.BackColor = System.Drawing.Color.White;
			this.themePage.Controls.Add(this.licenseLabel);
			this.themePage.Controls.Add(this.systemThemeRadio);
			this.themePage.Controls.Add(this.darkThemeRadio);
			this.themePage.Controls.Add(this.lightThemeRadio);
			this.themePage.Location = new System.Drawing.Point(4, 20);
			this.themePage.Margin = new System.Windows.Forms.Padding(0);
			this.themePage.Name = "themePage";
			this.themePage.Padding = new System.Windows.Forms.Padding(3);
			this.themePage.Size = new System.Drawing.Size(248, 121);
			this.themePage.TabIndex = 0;
			this.themePage.Text = "Theme";
			// 
			// audioPage
			// 
			this.audioPage.BackColor = System.Drawing.Color.White;
			this.audioPage.Controls.Add(this.winSoundBtn);
			this.audioPage.Controls.Add(this.mixerBtn);
			this.audioPage.Location = new System.Drawing.Point(4, 20);
			this.audioPage.Margin = new System.Windows.Forms.Padding(0);
			this.audioPage.Name = "audioPage";
			this.audioPage.Size = new System.Drawing.Size(248, 121);
			this.audioPage.TabIndex = 2;
			this.audioPage.Text = "Audio";
			// 
			// updatesPage
			// 
			this.updatesPage.BackColor = System.Drawing.Color.White;
			this.updatesPage.Controls.Add(this.updatesCheckBox);
			this.updatesPage.Location = new System.Drawing.Point(4, 20);
			this.updatesPage.Margin = new System.Windows.Forms.Padding(0);
			this.updatesPage.Name = "updatesPage";
			this.updatesPage.Padding = new System.Windows.Forms.Padding(3);
			this.updatesPage.Size = new System.Drawing.Size(248, 121);
			this.updatesPage.TabIndex = 1;
			this.updatesPage.Text = "Updates";
			// 
			// mixerBtn
			// 
			this.mixerBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.mixerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.mixerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mixerBtn.Image = ((System.Drawing.Image)(resources.GetObject("mixerBtn.Image")));
			this.mixerBtn.Location = new System.Drawing.Point(9, 9);
			this.mixerBtn.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.mixerBtn.Name = "mixerBtn";
			this.mixerBtn.Size = new System.Drawing.Size(230, 40);
			this.mixerBtn.TabIndex = 2;
			this.mixerBtn.Text = " Open volume mixer";
			this.mixerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.mixerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mixerBtn.UseVisualStyleBackColor = false;
			this.mixerBtn.Click += new System.EventHandler(this.mixerBtn_Click);
			// 
			// winSoundBtn
			// 
			this.winSoundBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.winSoundBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.winSoundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.winSoundBtn.Image = ((System.Drawing.Image)(resources.GetObject("winSoundBtn.Image")));
			this.winSoundBtn.Location = new System.Drawing.Point(9, 58);
			this.winSoundBtn.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.winSoundBtn.Name = "winSoundBtn";
			this.winSoundBtn.Size = new System.Drawing.Size(230, 40);
			this.winSoundBtn.TabIndex = 3;
			this.winSoundBtn.Text = " Manage audio devices";
			this.winSoundBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.winSoundBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.winSoundBtn.UseVisualStyleBackColor = false;
			this.winSoundBtn.Click += new System.EventHandler(this.winSoundBtn_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(274, 163);
			this.Controls.Add(this.settingsTabs);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
			this.settingsTabs.ResumeLayout(false);
			this.themePage.ResumeLayout(false);
			this.themePage.PerformLayout();
			this.audioPage.ResumeLayout(false);
			this.updatesPage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private QuickLibrary.QlibRadioButton lightThemeRadio;
		private QuickLibrary.QlibRadioButton systemThemeRadio;
		private QuickLibrary.QlibRadioButton darkThemeRadio;
		private QuickLibrary.QlibCheckBox updatesCheckBox;
		private System.Windows.Forms.Label licenseLabel;
		private QuickLibrary.QlibTabControl settingsTabs;
		private System.Windows.Forms.TabPage themePage;
		private System.Windows.Forms.TabPage updatesPage;
		private System.Windows.Forms.TabPage audioPage;
		private System.Windows.Forms.Button mixerBtn;
		private System.Windows.Forms.Button winSoundBtn;
	}
}
