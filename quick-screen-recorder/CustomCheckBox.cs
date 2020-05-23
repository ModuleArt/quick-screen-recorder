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
		private bool hovered = false;
		private bool pressed = false;

		public CustomCheckBox()
		{
			if (darkMode)
			{
				SetStyle(ControlStyles.UserPaint, true);
				this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

				this.MouseEnter += CustomCheckBox_MouseEnter;
				this.MouseLeave += CustomCheckBox_MouseLeave;
				this.MouseDown += CustomCheckBox_MouseDown;
				this.MouseUp += CustomCheckBox_MouseUp;
			}
		}

		private void CustomCheckBox_MouseUp(object sender, MouseEventArgs e)
		{
			pressed = false;
			this.Refresh();
		}

		private void CustomCheckBox_MouseDown(object sender, MouseEventArgs e)
		{
			pressed = true;
			this.Refresh();
		}

		private void CustomCheckBox_MouseLeave(object sender, EventArgs e)
		{
			hovered = false;
			this.Refresh();
		}

		private void CustomCheckBox_MouseEnter(object sender, EventArgs e)
		{
			hovered = true;
			this.Refresh();
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
			if (darkMode)
			{
				e.Graphics.Clear(this.BackColor);

				if (this.pressed)
				{
					e.Graphics.FillRectangle(new SolidBrush(ThemeManager.PressedColor), new Rectangle(0, 2, 13, 13));
				}
				else
				{
					if (this.hovered)
					{
						e.Graphics.FillRectangle(new SolidBrush(ThemeManager.DarkHoverColor), new Rectangle(0, 2, 13, 13));
					}
					else
					{
						e.Graphics.FillRectangle(new SolidBrush(ThemeManager.DarkSecondColor), new Rectangle(0, 2, 13, 13));
					}
				}

				
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
			else
			{
				base.OnPaint(e);
			}
		}
	}
}
