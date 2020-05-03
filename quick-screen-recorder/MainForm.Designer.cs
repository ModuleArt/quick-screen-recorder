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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.generalGroup = new System.Windows.Forms.GroupBox();
			this.aviLabel = new System.Windows.Forms.Label();
			this.recButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
			this.videoGroup.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.generalGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// folderTextBox
			// 
			this.folderTextBox.Location = new System.Drawing.Point(82, 22);
			this.folderTextBox.Name = "folderTextBox";
			this.folderTextBox.Size = new System.Drawing.Size(162, 23);
			this.folderTextBox.TabIndex = 1;
			// 
			// browseFolderBtn
			// 
			this.browseFolderBtn.Location = new System.Drawing.Point(250, 21);
			this.browseFolderBtn.Name = "browseFolderBtn";
			this.browseFolderBtn.Size = new System.Drawing.Size(70, 25);
			this.browseFolderBtn.TabIndex = 2;
			this.browseFolderBtn.Text = "Browse";
			this.browseFolderBtn.UseVisualStyleBackColor = true;
			this.browseFolderBtn.Click += new System.EventHandler(this.browseFolderBtn_Click);
			// 
			// folderLabel
			// 
			this.folderLabel.AutoSize = true;
			this.folderLabel.Location = new System.Drawing.Point(33, 26);
			this.folderLabel.Name = "folderLabel";
			this.folderLabel.Size = new System.Drawing.Size(43, 15);
			this.folderLabel.TabIndex = 3;
			this.folderLabel.Text = "Folder:";
			// 
			// fileNameTextBox
			// 
			this.fileNameTextBox.Location = new System.Drawing.Point(82, 52);
			this.fileNameTextBox.Name = "fileNameTextBox";
			this.fileNameTextBox.Size = new System.Drawing.Size(207, 23);
			this.fileNameTextBox.TabIndex = 4;
			this.fileNameTextBox.Text = "NewVideo1";
			// 
			// fileLabel
			// 
			this.fileLabel.AutoSize = true;
			this.fileLabel.Location = new System.Drawing.Point(15, 55);
			this.fileLabel.Name = "fileLabel";
			this.fileLabel.Size = new System.Drawing.Size(61, 15);
			this.fileLabel.TabIndex = 5;
			this.fileLabel.Text = "File name:";
			// 
			// qualityLabel
			// 
			this.qualityLabel.AutoSize = true;
			this.qualityLabel.Location = new System.Drawing.Point(28, 25);
			this.qualityLabel.Name = "qualityLabel";
			this.qualityLabel.Size = new System.Drawing.Size(48, 15);
			this.qualityLabel.TabIndex = 10;
			this.qualityLabel.Text = "Quality:";
			// 
			// aboutBtn
			// 
			this.aboutBtn.Location = new System.Drawing.Point(310, 9);
			this.aboutBtn.Margin = new System.Windows.Forms.Padding(0);
			this.aboutBtn.Name = "aboutBtn";
			this.aboutBtn.Size = new System.Drawing.Size(25, 25);
			this.aboutBtn.TabIndex = 14;
			this.aboutBtn.Text = "?";
			this.aboutBtn.UseVisualStyleBackColor = true;
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
			this.qualityComboBox.Location = new System.Drawing.Point(82, 22);
			this.qualityComboBox.Name = "qualityComboBox";
			this.qualityComboBox.Size = new System.Drawing.Size(238, 23);
			this.qualityComboBox.TabIndex = 15;
			// 
			// areaComboBox
			// 
			this.areaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.areaComboBox.FormattingEnabled = true;
			this.areaComboBox.Items.AddRange(new object[] {
            "Fullscreen",
            "Custom area"});
			this.areaComboBox.Location = new System.Drawing.Point(82, 51);
			this.areaComboBox.Name = "areaComboBox";
			this.areaComboBox.Size = new System.Drawing.Size(106, 23);
			this.areaComboBox.TabIndex = 16;
			this.areaComboBox.SelectedIndexChanged += new System.EventHandler(this.areaComboBox_SelectedIndexChanged);
			// 
			// areaLabel
			// 
			this.areaLabel.AutoSize = true;
			this.areaLabel.Location = new System.Drawing.Point(6, 53);
			this.areaLabel.Name = "areaLabel";
			this.areaLabel.Size = new System.Drawing.Size(70, 15);
			this.areaLabel.TabIndex = 18;
			this.areaLabel.Text = "Screen area:";
			// 
			// heightNumeric
			// 
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
			this.videoGroup.Size = new System.Drawing.Size(326, 108);
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
            "System sounds (Beta)"});
			this.inputDeviceComboBox.Location = new System.Drawing.Point(82, 22);
			this.inputDeviceComboBox.Name = "inputDeviceComboBox";
			this.inputDeviceComboBox.Size = new System.Drawing.Size(238, 23);
			this.inputDeviceComboBox.TabIndex = 25;
			// 
			// inputDeviceLabel
			// 
			this.inputDeviceLabel.AutoSize = true;
			this.inputDeviceLabel.Location = new System.Drawing.Point(38, 25);
			this.inputDeviceLabel.Name = "inputDeviceLabel";
			this.inputDeviceLabel.Size = new System.Drawing.Size(38, 15);
			this.inputDeviceLabel.TabIndex = 26;
			this.inputDeviceLabel.Text = "Input:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.inputDeviceLabel);
			this.groupBox1.Controls.Add(this.inputDeviceComboBox);
			this.groupBox1.Location = new System.Drawing.Point(9, 274);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(326, 60);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Audio options";
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
			this.recButton.Image = global::quick_screen_recorder.Properties.Resources.rec;
			this.recButton.Location = new System.Drawing.Point(9, 9);
			this.recButton.Margin = new System.Windows.Forms.Padding(0);
			this.recButton.Name = "recButton";
			this.recButton.Size = new System.Drawing.Size(120, 40);
			this.recButton.TabIndex = 0;
			this.recButton.Text = "REC (Alt+R)";
			this.recButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.recButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.recButton.UseVisualStyleBackColor = true;
			this.recButton.Click += new System.EventHandler(this.recButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(344, 342);
			this.Controls.Add(this.generalGroup);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.videoGroup);
			this.Controls.Add(this.aboutBtn);
			this.Controls.Add(this.recButton);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.generalGroup.ResumeLayout(false);
			this.generalGroup.PerformLayout();
			this.ResumeLayout(false);

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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox generalGroup;
		private System.Windows.Forms.Label aviLabel;
	}
}

