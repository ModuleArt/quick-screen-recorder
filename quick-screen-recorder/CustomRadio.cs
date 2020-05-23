using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace quick_screen_recorder
{
	class CustomRadio : RadioButton
	{
		private bool darkMode = false;
		private string darkText;

		public CustomRadio()
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
			if (darkMode)
			{
				e.Graphics.Clear(ThemeManager.DarkBackColor);

				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				e.Graphics.FillEllipse(new SolidBrush(ThemeManager.DarkSecondColor), new Rectangle(0, 2, 13, 13));
				e.Graphics.DrawEllipse(new Pen(ThemeManager.BorderColor), new Rectangle(0, 2, 13, 13));

				if (this.Checked)
				{
					if (this.Enabled)
					{
						e.Graphics.FillEllipse(new SolidBrush(this.ForeColor), new Rectangle(3, 5, 7, 7));
					}
					else
					{
						e.Graphics.FillEllipse(new SolidBrush(ThemeManager.BorderColor), new Rectangle(3, 5, 7, 7));
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
