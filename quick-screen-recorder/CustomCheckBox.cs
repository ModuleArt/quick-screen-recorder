using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace quick_screen_recorder
{
	class CustomCheckBox : CheckBox
	{
		private bool darkMode = false;
		private string darkText;

		public CustomCheckBox()
		{
			if (darkMode)
			{
				SetStyle(ControlStyles.UserPaint, true);
				this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			}
		}

		public void SetDarkMode(bool dark)
		{
			this.darkMode = dark;

			if (dark)
			{
				darkText = this.Text;
				this.Text = " ";
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (darkMode)
			{
				e.Graphics.FillRectangle(new SolidBrush(ThemeManager.DarkSecondColor), new Rectangle(0, 2, 13, 13));

				ControlPaint.DrawBorder(e.Graphics, new Rectangle(0, 2, 13, 13), ThemeManager.BorderColor, ButtonBorderStyle.Solid);

				if (this.Checked)
				{
					e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

					if (this.Enabled)
					{
						e.Graphics.DrawLine(new Pen(this.ForeColor, 2), 2, 7, 5, 10);
						e.Graphics.DrawLine(new Pen(this.ForeColor, 2), 5, 11, 12, 4);
					}
					else
					{
						e.Graphics.DrawLine(new Pen(ThemeManager.BorderColor, 2), 2, 7, 5, 10);
						e.Graphics.DrawLine(new Pen(ThemeManager.BorderColor, 2), 5, 11, 12, 4);
					}
				}

				e.Graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
				if (this.Enabled)
				{
					e.Graphics.DrawString(darkText, this.Font, new SolidBrush(this.ForeColor), 17, 0);
				}
				else
				{
					e.Graphics.DrawString(darkText, this.Font, new SolidBrush(ThemeManager.BorderColor), 17, 0);
				}
			}
		}
	}
}
