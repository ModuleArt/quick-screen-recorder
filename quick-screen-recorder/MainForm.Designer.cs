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
			this.recButton = new System.Windows.Forms.Button();
			this.folderTextBox = new System.Windows.Forms.TextBox();
			this.browseFolderBtn = new System.Windows.Forms.Button();
			this.folderLabel = new System.Windows.Forms.Label();
			this.fileNameTextBox = new System.Windows.Forms.TextBox();
			this.fileLabel = new System.Windows.Forms.Label();
			this.extLabel = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.fpsComboBox = new System.Windows.Forms.ComboBox();
			this.fpsLabel = new System.Windows.Forms.Label();
			this.qualityLabel = new System.Windows.Forms.Label();
			this.aboutBtn = new System.Windows.Forms.Button();
			this.qualityComboBox = new System.Windows.Forms.ComboBox();
			this.areaComboBox = new System.Windows.Forms.ComboBox();
			this.areaLabel = new System.Windows.Forms.Label();
			this.heightNumeric = new System.Windows.Forms.NumericUpDown();
			this.widthNumeric = new System.Windows.Forms.NumericUpDown();
			this.optionsGroup = new System.Windows.Forms.GroupBox();
			this.timeLabel = new System.Windows.Forms.Label();
			this.mainTimer = new System.Windows.Forms.Timer(this.components);
			this.hotkeyLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
			this.optionsGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// recButton
			// 
			this.recButton.Image = global::quick_screen_recorder.Properties.Resources.rec;
			this.recButton.Location = new System.Drawing.Point(12, 12);
			this.recButton.Name = "recButton";
			this.recButton.Size = new System.Drawing.Size(100, 44);
			this.recButton.TabIndex = 0;
			this.recButton.Text = "REC";
			this.recButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.recButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.recButton.UseVisualStyleBackColor = true;
			this.recButton.Click += new System.EventHandler(this.recButton_Click);
			// 
			// folderTextBox
			// 
			this.folderTextBox.Location = new System.Drawing.Point(73, 23);
			this.folderTextBox.Name = "folderTextBox";
			this.folderTextBox.Size = new System.Drawing.Size(211, 23);
			this.folderTextBox.TabIndex = 1;
			// 
			// browseFolderBtn
			// 
			this.browseFolderBtn.Location = new System.Drawing.Point(290, 22);
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
			this.folderLabel.Location = new System.Drawing.Point(21, 26);
			this.folderLabel.Name = "folderLabel";
			this.folderLabel.Size = new System.Drawing.Size(43, 15);
			this.folderLabel.TabIndex = 3;
			this.folderLabel.Text = "Folder:";
			// 
			// fileNameTextBox
			// 
			this.fileNameTextBox.Location = new System.Drawing.Point(73, 52);
			this.fileNameTextBox.Name = "fileNameTextBox";
			this.fileNameTextBox.Size = new System.Drawing.Size(256, 23);
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
			// extLabel
			// 
			this.extLabel.AutoSize = true;
			this.extLabel.Location = new System.Drawing.Point(335, 55);
			this.extLabel.Name = "extLabel";
			this.extLabel.Size = new System.Drawing.Size(25, 15);
			this.extLabel.TabIndex = 6;
			this.extLabel.Text = ".avi";
			// 
			// fpsComboBox
			// 
			this.fpsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fpsComboBox.FormattingEnabled = true;
			this.fpsComboBox.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "30",
            "45",
            "60"});
			this.fpsComboBox.Location = new System.Drawing.Point(73, 81);
			this.fpsComboBox.Name = "fpsComboBox";
			this.fpsComboBox.Size = new System.Drawing.Size(50, 23);
			this.fpsComboBox.TabIndex = 7;
			// 
			// fpsLabel
			// 
			this.fpsLabel.AutoSize = true;
			this.fpsLabel.Location = new System.Drawing.Point(35, 84);
			this.fpsLabel.Name = "fpsLabel";
			this.fpsLabel.Size = new System.Drawing.Size(29, 15);
			this.fpsLabel.TabIndex = 8;
			this.fpsLabel.Text = "FPS:";
			// 
			// qualityLabel
			// 
			this.qualityLabel.AutoSize = true;
			this.qualityLabel.Location = new System.Drawing.Point(178, 84);
			this.qualityLabel.Name = "qualityLabel";
			this.qualityLabel.Size = new System.Drawing.Size(48, 15);
			this.qualityLabel.TabIndex = 10;
			this.qualityLabel.Text = "Quality:";
			// 
			// aboutBtn
			// 
			this.aboutBtn.Location = new System.Drawing.Point(347, 12);
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
			this.qualityComboBox.Location = new System.Drawing.Point(232, 81);
			this.qualityComboBox.Name = "qualityComboBox";
			this.qualityComboBox.Size = new System.Drawing.Size(127, 23);
			this.qualityComboBox.TabIndex = 15;
			// 
			// areaComboBox
			// 
			this.areaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.areaComboBox.FormattingEnabled = true;
			this.areaComboBox.Items.AddRange(new object[] {
            "Fullscreen",
            "Custom area"});
			this.areaComboBox.Location = new System.Drawing.Point(73, 110);
			this.areaComboBox.Name = "areaComboBox";
			this.areaComboBox.Size = new System.Drawing.Size(154, 23);
			this.areaComboBox.TabIndex = 16;
			this.areaComboBox.SelectedIndexChanged += new System.EventHandler(this.areaComboBox_SelectedIndexChanged);
			// 
			// areaLabel
			// 
			this.areaLabel.AutoSize = true;
			this.areaLabel.Location = new System.Drawing.Point(30, 113);
			this.areaLabel.Name = "areaLabel";
			this.areaLabel.Size = new System.Drawing.Size(34, 15);
			this.areaLabel.TabIndex = 18;
			this.areaLabel.Text = "Area:";
			// 
			// heightNumeric
			// 
			this.heightNumeric.Location = new System.Drawing.Point(299, 110);
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
			this.widthNumeric.Location = new System.Drawing.Point(233, 110);
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
			// optionsGroup
			// 
			this.optionsGroup.Controls.Add(this.browseFolderBtn);
			this.optionsGroup.Controls.Add(this.folderTextBox);
			this.optionsGroup.Controls.Add(this.widthNumeric);
			this.optionsGroup.Controls.Add(this.folderLabel);
			this.optionsGroup.Controls.Add(this.heightNumeric);
			this.optionsGroup.Controls.Add(this.fileNameTextBox);
			this.optionsGroup.Controls.Add(this.qualityComboBox);
			this.optionsGroup.Controls.Add(this.areaLabel);
			this.optionsGroup.Controls.Add(this.qualityLabel);
			this.optionsGroup.Controls.Add(this.fileLabel);
			this.optionsGroup.Controls.Add(this.extLabel);
			this.optionsGroup.Controls.Add(this.areaComboBox);
			this.optionsGroup.Controls.Add(this.fpsComboBox);
			this.optionsGroup.Controls.Add(this.fpsLabel);
			this.optionsGroup.Location = new System.Drawing.Point(9, 69);
			this.optionsGroup.Margin = new System.Windows.Forms.Padding(0);
			this.optionsGroup.Name = "optionsGroup";
			this.optionsGroup.Size = new System.Drawing.Size(366, 142);
			this.optionsGroup.TabIndex = 21;
			this.optionsGroup.TabStop = false;
			this.optionsGroup.Text = "Options";
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLabel.Location = new System.Drawing.Point(118, 12);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(100, 22);
			this.timeLabel.TabIndex = 22;
			this.timeLabel.Text = "00:00.000";
			// 
			// mainTimer
			// 
			this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
			// 
			// hotkeyLabel
			// 
			this.hotkeyLabel.AutoSize = true;
			this.hotkeyLabel.Location = new System.Drawing.Point(119, 37);
			this.hotkeyLabel.Name = "hotkeyLabel";
			this.hotkeyLabel.Size = new System.Drawing.Size(84, 15);
			this.hotkeyLabel.TabIndex = 23;
			this.hotkeyLabel.Text = "Toggle: Alt + R";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(384, 220);
			this.Controls.Add(this.hotkeyLabel);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.optionsGroup);
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
			this.optionsGroup.ResumeLayout(false);
			this.optionsGroup.PerformLayout();
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
		private System.Windows.Forms.Label extLabel;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ComboBox fpsComboBox;
		private System.Windows.Forms.Label fpsLabel;
		private System.Windows.Forms.Label qualityLabel;
		private System.Windows.Forms.Button aboutBtn;
		private System.Windows.Forms.ComboBox qualityComboBox;
		private System.Windows.Forms.ComboBox areaComboBox;
		private System.Windows.Forms.Label areaLabel;
		private System.Windows.Forms.NumericUpDown heightNumeric;
		private System.Windows.Forms.NumericUpDown widthNumeric;
		private System.Windows.Forms.GroupBox optionsGroup;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Timer mainTimer;
		private System.Windows.Forms.Label hotkeyLabel;
	}
}

