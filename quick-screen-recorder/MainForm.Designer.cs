namespace quick_screen_recorder
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.folderTextBox = new System.Windows.Forms.TextBox();
			this.browseFolderBtn = new System.Windows.Forms.Button();
			this.folderLabel = new System.Windows.Forms.Label();
			this.fileNameTextBox = new System.Windows.Forms.TextBox();
			this.fileLabel = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.qualityLabel = new System.Windows.Forms.Label();
			this.aboutBtn = new System.Windows.Forms.Button();
			this.qualityComboBox = new System.Windows.Forms.ComboBox();
			this.areaComboBox = new System.Windows.Forms.ComboBox();
			this.areaLabel = new System.Windows.Forms.Label();
			this.heightNumeric = new System.Windows.Forms.NumericUpDown();
			this.widthNumeric = new System.Windows.Forms.NumericUpDown();
			this.videoGroup = new System.Windows.Forms.GroupBox();
			this.captureCursorCheckBox = new System.Windows.Forms.CheckBox();
			this.inputDeviceComboBox = new System.Windows.Forms.ComboBox();
			this.inputDeviceLabel = new System.Windows.Forms.Label();
			this.audioGroup = new System.Windows.Forms.GroupBox();
			this.separateAudioCheckBox = new System.Windows.Forms.CheckBox();
			this.generalGroup = new System.Windows.Forms.GroupBox();
			this.aviLabel = new System.Windows.Forms.Label();
			this.recButton = new System.Windows.Forms.Button();
			this.updateTimer = new System.Windows.Forms.Timer(this.components);
			this.onTopCheckBox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
			this.videoGroup.SuspendLayout();
			this.audioGroup.SuspendLayout();
			this.generalGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// folderTextBox
			// 
			this.folderTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.folderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.folderTextBox.Location = new System.Drawing.Point(73, 22);
			this.folderTextBox.Name = "folderTextBox";
			this.folderTextBox.Size = new System.Drawing.Size(171, 23);
			this.folderTextBox.TabIndex = 1;
			// 
			// browseFolderBtn
			// 
			this.browseFolderBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.browseFolderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
			this.browseFolderBtn.FlatAppearance.BorderSize = 0;
			this.browseFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.browseFolderBtn.Location = new System.Drawing.Point(251, 22);
			this.browseFolderBtn.Name = "browseFolderBtn";
			this.browseFolderBtn.Size = new System.Drawing.Size(69, 23);
			this.browseFolderBtn.TabIndex = 2;
			this.browseFolderBtn.Text = "Browse";
			this.browseFolderBtn.UseVisualStyleBackColor = false;
			this.browseFolderBtn.Click += new System.EventHandler(this.browseFolderBtn_Click);
			// 
			// folderLabel
			// 
			this.folderLabel.AutoSize = true;
			this.folderLabel.Location = new System.Drawing.Point(24, 26);
			this.folderLabel.Name = "folderLabel";
			this.folderLabel.Size = new System.Drawing.Size(43, 15);
			this.folderLabel.TabIndex = 3;
			this.folderLabel.Text = "Folder:";
			// 
			// fileNameTextBox
			// 
			this.fileNameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.fileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fileNameTextBox.Location = new System.Drawing.Point(73, 52);
			this.fileNameTextBox.Name = "fileNameTextBox";
			this.fileNameTextBox.Size = new System.Drawing.Size(216, 23);
			this.fileNameTextBox.TabIndex = 4;
			this.fileNameTextBox.Text = "NewVideo1";
			// 
			// fileLabel
			// 
			this.fileLabel.AutoSize = true;
			this.fileLabel.Location = new System.Drawing.Point(6, 55);
			this.fileLabel.Name = "fileLabel";
			this.fileLabel.Size = new System.Drawing.Size(61, 15);
			this.fileLabel.TabIndex = 5;
			this.fileLabel.Text = "File name:";
			// 
			// qualityLabel
			// 
			this.qualityLabel.AutoSize = true;
			this.qualityLabel.Location = new System.Drawing.Point(19, 25);
			this.qualityLabel.Name = "qualityLabel";
			this.qualityLabel.Size = new System.Drawing.Size(48, 15);
			this.qualityLabel.TabIndex = 10;
			this.qualityLabel.Text = "Quality:";
			// 
			// aboutBtn
			// 
			this.aboutBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.aboutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
			this.aboutBtn.FlatAppearance.BorderSize = 0;
			this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.aboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("aboutBtn.Image")));
			this.aboutBtn.Location = new System.Drawing.Point(312, 9);
			this.aboutBtn.Margin = new System.Windows.Forms.Padding(0);
			this.aboutBtn.Name = "aboutBtn";
			this.aboutBtn.Size = new System.Drawing.Size(23, 23);
			this.aboutBtn.TabIndex = 14;
			this.aboutBtn.UseVisualStyleBackColor = false;
			this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
			// 
			// qualityComboBox
			// 
			this.qualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.qualityComboBox.FormattingEnabled = true;
			this.qualityComboBox.Items.AddRange(new object[] {
            "25% - Low",
            "50% - Medium",
            "75% - High",
            "100% - Original"});
			this.qualityComboBox.Location = new System.Drawing.Point(73, 22);
			this.qualityComboBox.Name = "qualityComboBox";
			this.qualityComboBox.Size = new System.Drawing.Size(247, 23);
			this.qualityComboBox.TabIndex = 15;
			// 
			// areaComboBox
			// 
			this.areaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.areaComboBox.FormattingEnabled = true;
			this.areaComboBox.Items.AddRange(new object[] {
            "Fullscreen",
            "Custom area"});
			this.areaComboBox.Location = new System.Drawing.Point(73, 51);
			this.areaComboBox.Name = "areaComboBox";
			this.areaComboBox.Size = new System.Drawing.Size(115, 23);
			this.areaComboBox.TabIndex = 16;
			this.areaComboBox.SelectedIndexChanged += new System.EventHandler(this.areaComboBox_SelectedIndexChanged);
			// 
			// areaLabel
			// 
			this.areaLabel.AutoSize = true;
			this.areaLabel.Location = new System.Drawing.Point(33, 53);
			this.areaLabel.Name = "areaLabel";
			this.areaLabel.Size = new System.Drawing.Size(34, 15);
			this.areaLabel.TabIndex = 18;
			this.areaLabel.Text = "Area:";
			// 
			// heightNumeric
			// 
			this.heightNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.heightNumeric.Location = new System.Drawing.Point(260, 51);
			this.heightNumeric.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
			this.heightNumeric.Minimum = new decimal(new int[] {
            160,
            0,
            0,
            0});
			this.heightNumeric.Name = "heightNumeric";
			this.heightNumeric.Size = new System.Drawing.Size(60, 23);
			this.heightNumeric.TabIndex = 19;
			this.heightNumeric.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
			this.heightNumeric.ValueChanged += new System.EventHandler(this.heightNumeric_ValueChanged);
			// 
			// widthNumeric
			// 
			this.widthNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.widthNumeric.Location = new System.Drawing.Point(194, 51);
			this.widthNumeric.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
			this.widthNumeric.Minimum = new decimal(new int[] {
            160,
            0,
            0,
            0});
			this.widthNumeric.Name = "widthNumeric";
			this.widthNumeric.Size = new System.Drawing.Size(60, 23);
			this.widthNumeric.TabIndex = 20;
			this.widthNumeric.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
			this.widthNumeric.ValueChanged += new System.EventHandler(this.widthNumeric_ValueChanged);
			// 
			// videoGroup
			// 
			this.videoGroup.Controls.Add(this.captureCursorCheckBox);
			this.videoGroup.Controls.Add(this.widthNumeric);
			this.videoGroup.Controls.Add(this.heightNumeric);
			this.videoGroup.Controls.Add(this.qualityComboBox);
			this.videoGroup.Controls.Add(this.areaLabel);
			this.videoGroup.Controls.Add(this.qualityLabel);
			this.videoGroup.Controls.Add(this.areaComboBox);
			this.videoGroup.Location = new System.Drawing.Point(9, 157);
			this.videoGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.videoGroup.Name = "videoGroup";
			this.videoGroup.Size = new System.Drawing.Size(326, 105);
			this.videoGroup.TabIndex = 21;
			this.videoGroup.TabStop = false;
			this.videoGroup.Text = "Video options";
			// 
			// captureCursorCheckBox
			// 
			this.captureCursorCheckBox.AutoSize = true;
			this.captureCursorCheckBox.Checked = true;
			this.captureCursorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.captureCursorCheckBox.Location = new System.Drawing.Point(216, 80);
			this.captureCursorCheckBox.Name = "captureCursorCheckBox";
			this.captureCursorCheckBox.Size = new System.Drawing.Size(104, 19);
			this.captureCursorCheckBox.TabIndex = 24;
			this.captureCursorCheckBox.Text = "Capture cursor";
			this.captureCursorCheckBox.UseVisualStyleBackColor = true;
			// 
			// inputDeviceComboBox
			// 
			this.inputDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputDeviceComboBox.FormattingEnabled = true;
			this.inputDeviceComboBox.Items.AddRange(new object[] {
            "None",
            "System sounds (Soundcard)"});
			this.inputDeviceComboBox.Location = new System.Drawing.Point(73, 22);
			this.inputDeviceComboBox.Name = "inputDeviceComboBox";
			this.inputDeviceComboBox.Size = new System.Drawing.Size(247, 23);
			this.inputDeviceComboBox.TabIndex = 25;
			// 
			// inputDeviceLabel
			// 
			this.inputDeviceLabel.AutoSize = true;
			this.inputDeviceLabel.Location = new System.Drawing.Point(29, 25);
			this.inputDeviceLabel.Name = "inputDeviceLabel";
			this.inputDeviceLabel.Size = new System.Drawing.Size(38, 15);
			this.inputDeviceLabel.TabIndex = 26;
			this.inputDeviceLabel.Text = "Input:";
			// 
			// audioGroup
			// 
			this.audioGroup.Controls.Add(this.separateAudioCheckBox);
			this.audioGroup.Controls.Add(this.inputDeviceLabel);
			this.audioGroup.Controls.Add(this.inputDeviceComboBox);
			this.audioGroup.Location = new System.Drawing.Point(9, 271);
			this.audioGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.audioGroup.Name = "audioGroup";
			this.audioGroup.Size = new System.Drawing.Size(326, 76);
			this.audioGroup.TabIndex = 24;
			this.audioGroup.TabStop = false;
			this.audioGroup.Text = "Audio options";
			// 
			// separateAudioCheckBox
			// 
			this.separateAudioCheckBox.AutoSize = true;
			this.separateAudioCheckBox.Location = new System.Drawing.Point(109, 51);
			this.separateAudioCheckBox.Name = "separateAudioCheckBox";
			this.separateAudioCheckBox.Size = new System.Drawing.Size(211, 19);
			this.separateAudioCheckBox.TabIndex = 25;
			this.separateAudioCheckBox.Text = "Write audio to a separate file (.wav)";
			this.separateAudioCheckBox.UseVisualStyleBackColor = true;
			// 
			// generalGroup
			// 
			this.generalGroup.Controls.Add(this.aviLabel);
			this.generalGroup.Controls.Add(this.folderTextBox);
			this.generalGroup.Controls.Add(this.browseFolderBtn);
			this.generalGroup.Controls.Add(this.folderLabel);
			this.generalGroup.Controls.Add(this.fileNameTextBox);
			this.generalGroup.Controls.Add(this.fileLabel);
			this.generalGroup.Location = new System.Drawing.Point(9, 58);
			this.generalGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.generalGroup.Name = "generalGroup";
			this.generalGroup.Size = new System.Drawing.Size(326, 90);
			this.generalGroup.TabIndex = 25;
			this.generalGroup.TabStop = false;
			this.generalGroup.Text = "General options";
			// 
			// aviLabel
			// 
			this.aviLabel.AutoSize = true;
			this.aviLabel.Location = new System.Drawing.Point(295, 55);
			this.aviLabel.Name = "aviLabel";
			this.aviLabel.Size = new System.Drawing.Size(25, 15);
			this.aviLabel.TabIndex = 26;
			this.aviLabel.Text = ".avi";
			// 
			// recButton
			// 
			this.recButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.recButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
			this.recButton.FlatAppearance.BorderSize = 0;
			this.recButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.recButton.Image = ((System.Drawing.Image)(resources.GetObject("recButton.Image")));
			this.recButton.Location = new System.Drawing.Point(9, 9);
			this.recButton.Margin = new System.Windows.Forms.Padding(0);
			this.recButton.Name = "recButton";
			this.recButton.Size = new System.Drawing.Size(120, 40);
			this.recButton.TabIndex = 0;
			this.recButton.Text = " REC (Alt+R)";
			this.recButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.recButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.recButton.UseVisualStyleBackColor = false;
			this.recButton.Click += new System.EventHandler(this.recButton_Click);
			// 
			// onTopCheckBox
			// 
			this.onTopCheckBox.AutoSize = true;
			this.onTopCheckBox.Checked = true;
			this.onTopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.onTopCheckBox.Location = new System.Drawing.Point(208, 12);
			this.onTopCheckBox.Name = "onTopCheckBox";
			this.onTopCheckBox.Size = new System.Drawing.Size(101, 19);
			this.onTopCheckBox.TabIndex = 27;
			this.onTopCheckBox.Text = "Always on top";
			this.onTopCheckBox.UseVisualStyleBackColor = true;
			this.onTopCheckBox.CheckedChanged += new System.EventHandler(this.onTopCheckBox_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(344, 355);
			this.Controls.Add(this.onTopCheckBox);
			this.Controls.Add(this.generalGroup);
			this.Controls.Add(this.audioGroup);
			this.Controls.Add(this.videoGroup);
			this.Controls.Add(this.aboutBtn);
			this.Controls.Add(this.recButton);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quick Screen Recorder";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).EndInit();
			this.videoGroup.ResumeLayout(false);
			this.videoGroup.PerformLayout();
			this.audioGroup.ResumeLayout(false);
			this.audioGroup.PerformLayout();
			this.generalGroup.ResumeLayout(false);
			this.generalGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button recButton;
		private System.Windows.Forms.TextBox folderTextBox;
		private System.Windows.Forms.Button browseFolderBtn;
		private System.Windows.Forms.Label folderLabel;
		private System.Windows.Forms.TextBox fileNameTextBox;
		private System.Windows.Forms.Label fileLabel;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label qualityLabel;
		private System.Windows.Forms.Button aboutBtn;
		private System.Windows.Forms.ComboBox qualityComboBox;
		private System.Windows.Forms.ComboBox areaComboBox;
		private System.Windows.Forms.Label areaLabel;
		private System.Windows.Forms.NumericUpDown heightNumeric;
		private System.Windows.Forms.NumericUpDown widthNumeric;
		private System.Windows.Forms.GroupBox videoGroup;
		private System.Windows.Forms.CheckBox captureCursorCheckBox;
		private System.Windows.Forms.ComboBox inputDeviceComboBox;
		private System.Windows.Forms.Label inputDeviceLabel;
		private System.Windows.Forms.GroupBox audioGroup;
		private System.Windows.Forms.GroupBox generalGroup;
		private System.Windows.Forms.Label aviLabel;
		private System.Windows.Forms.Timer updateTimer;
		private System.Windows.Forms.CheckBox separateAudioCheckBox;
		private System.Windows.Forms.CheckBox onTopCheckBox;
	}
}

