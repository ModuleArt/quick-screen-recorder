namespace quick_screen_recorder
{
	partial class AreaForm
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
			this.dragBtn = new System.Windows.Forms.Button();
			this.sizeBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dragBtn
			// 
			this.dragBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.dragBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.dragBtn.Enabled = false;
			this.dragBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.dragBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dragBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dragBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dragBtn.Location = new System.Drawing.Point(414, 254);
			this.dragBtn.Name = "dragBtn";
			this.dragBtn.Size = new System.Drawing.Size(56, 56);
			this.dragBtn.TabIndex = 0;
			this.dragBtn.Text = "Drag here to resize";
			this.dragBtn.UseVisualStyleBackColor = false;
			// 
			// sizeBtn
			// 
			this.sizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.sizeBtn.Enabled = false;
			this.sizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.sizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sizeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.sizeBtn.Location = new System.Drawing.Point(12, 12);
			this.sizeBtn.Name = "sizeBtn";
			this.sizeBtn.Size = new System.Drawing.Size(56, 56);
			this.sizeBtn.TabIndex = 1;
			this.sizeBtn.UseVisualStyleBackColor = false;
			// 
			// AreaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumBlue;
			this.ClientSize = new System.Drawing.Size(482, 322);
			this.Controls.Add(this.sizeBtn);
			this.Controls.Add(this.dragBtn);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(162, 162);
			this.Name = "AreaForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Recording area - Quick Screen Recorder";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.MediumBlue;
			this.LocationChanged += new System.EventHandler(this.AreaForm_LocationChanged);
			this.SizeChanged += new System.EventHandler(this.AreaForm_SizeChanged);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AreaForm_MouseDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AreaForm_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button dragBtn;
		private System.Windows.Forms.Button sizeBtn;
	}
}