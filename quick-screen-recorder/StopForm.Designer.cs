namespace quick_screen_recorder
{
	partial class StopForm
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
			this.timeLabel = new System.Windows.Forms.Label();
			this.recButton = new System.Windows.Forms.Button();
			this.mainTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLabel.Location = new System.Drawing.Point(152, 17);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(100, 22);
			this.timeLabel.TabIndex = 23;
			this.timeLabel.Text = "00:00.000";
			// 
			// recButton
			// 
			this.recButton.Image = global::quick_screen_recorder.Properties.Resources.stop;
			this.recButton.Location = new System.Drawing.Point(9, 9);
			this.recButton.Margin = new System.Windows.Forms.Padding(0);
			this.recButton.Name = "recButton";
			this.recButton.Size = new System.Drawing.Size(120, 40);
			this.recButton.TabIndex = 24;
			this.recButton.Text = " STOP (Alt+R)";
			this.recButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.recButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.recButton.UseVisualStyleBackColor = true;
			this.recButton.Click += new System.EventHandler(this.recButton_Click);
			// 
			// mainTimer
			// 
			this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
			// 
			// StopForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(274, 58);
			this.Controls.Add(this.recButton);
			this.Controls.Add(this.timeLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "StopForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "⦿ Recording - Quick Screen Recorder";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StopForm_FormClosing);
			this.Load += new System.EventHandler(this.StopForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Button recButton;
		private System.Windows.Forms.Timer mainTimer;
	}
}