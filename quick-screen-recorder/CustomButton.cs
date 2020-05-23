using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace quick_screen_recorder
{
	class CustomButton : Button
	{
		private bool darkMode = false;
		private bool hovered = false;
		private bool pressed = false;

		public CustomButton()
		{
			SetStyle(ControlStyles.UserPaint, true);

			this.MouseEnter += CustomButton_MouseEnter;
			this.MouseLeave += CustomButton_MouseLeave;
			this.MouseDown += CustomButton_MouseDown;
			this.MouseUp += CustomButton_MouseUp;
		}

		private void CustomButton_MouseUp(object sender, MouseEventArgs e)
		{
			pressed = false;
			this.Refresh();
		}

		private void CustomButton_MouseDown(object sender, MouseEventArgs e)
		{
			pressed = true;
			this.Refresh();
		}

		private void CustomButton_MouseLeave(object sender, System.EventArgs e)
		{
			hovered = false;
			this.Refresh();
		}

		private void CustomButton_MouseEnter(object sender, System.EventArgs e)
		{
			hovered = true;
			this.Refresh();
		}

		public void SetDarkMode(bool dark)
		{
			this.darkMode = dark;

			if (dark)
			{
				this.BackColor = ThemeManager.DarkSecondColor;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			if (this.pressed)
			{
				e.Graphics.Clear(ThemeManager.PressedColor);
			}
			else
			{
				if (darkMode)
				{
					if (this.hovered)
					{
						e.Graphics.Clear(ThemeManager.DarkHoverColor);
					}
					else
					{
						e.Graphics.Clear(ThemeManager.DarkSecondColor);
					}
				}
				else
				{
					if (this.hovered)
					{
						e.Graphics.Clear(ThemeManager.LightHoverColor);
					}
					else
					{
						e.Graphics.Clear(ThemeManager.LightSecondColor);
					}
				}
			}

			if (this.Focused)
			{
				e.Graphics.DrawRectangle(new Pen(ThemeManager.BorderColor, 2), 1, 1, this.Width - 2, this.Height - 2);
				//e.Graphics.DrawRectangle(new Pen(ThemeManager.PressedColor), 5, 5, this.Width - 11, this.Height - 11);
			}
			else
			{
				e.Graphics.DrawRectangle(new Pen(ThemeManager.BorderColor), 0, 0, this.Width - 1, this.Height - 1);
			}

			e.Graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
			Size textSize = TextRenderer.MeasureText(this.Text, this.Font);
			e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), (this.Width / 2) - (textSize.Width / 2), 3);
		}
	}
}
