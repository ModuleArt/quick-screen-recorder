using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace quick_screen_recorder
{
	class CustomComboBox : ComboBox
	{
		public CustomComboBox()
		{
			SetStyle(ControlStyles.UserPaint, true);
			this.DrawMode = DrawMode.OwnerDrawFixed;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.Clear(ThemeManager.BackColorDark);
			e.Graphics.FillRectangle(new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height - 2);
			Rectangle newBounds = new Rectangle(this.ClientRectangle.X, this.ClientRectangle.Y, this.ClientRectangle.Width, this.ClientRectangle.Height - 1);
			ControlPaint.DrawBorder(e.Graphics, newBounds, ThemeManager.BorderColor, ButtonBorderStyle.Solid);

			e.Graphics.DrawLine(new Pen(ThemeManager.BorderColor), this.Width - 18, 0, this.Width - 18, this.Height - 2);
			e.Graphics.FillPolygon(new SolidBrush(this.ForeColor), new PointF[]
			{
				new PointF(this.Width - 13, 10),
				new PointF(this.Width - 9, 14),
				new PointF(this.Width - 5, 10)
			});

			e.Graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
			e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), 3, 3);
		}

		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			e.DrawBackground();
			e.Graphics.DrawString(this.Items[e.Index].ToString(), this.Font, new SolidBrush(this.ForeColor), e.Bounds.X, e.Bounds.Y);
		}
	}
}
