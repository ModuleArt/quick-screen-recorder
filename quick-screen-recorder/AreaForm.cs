using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace quick_screen_recorder
{
	public partial class AreaForm : Form
	{
		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		private Point startPos;
		private Size curSize;

		System.Timers.Timer resizeTimer = new System.Timers.Timer();

		public AreaForm()
		{
			InitializeComponent();

			resizeTimer.Elapsed += new ElapsedEventHandler(resizeTimer_Elapsed);
			resizeTimer.Interval = 50;
		}

		private void resizeTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			this.Invoke((MethodInvoker)(() => {
				Point curPos = this.PointToClient(Cursor.Position);

				int newWidth = curSize.Width + curPos.X - startPos.X;
				int newHeight = curSize.Height + curPos.Y - startPos.Y;

				(this.Owner as MainForm).SetAreaWidth(newWidth - 2);
				(this.Owner as MainForm).SetAreaHeight(newHeight - 2);
			}));
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
		}

		private void AreaForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Point downPos = this.PointToClient(Cursor.Position);
				if (downPos.X > dragBtn.Location.X && downPos.X < dragBtn.Location.X + dragBtn.Width &&
					downPos.Y > dragBtn.Location.Y && downPos.Y < dragBtn.Location.Y + dragBtn.Height)
				{
					Cursor.Current = Cursors.SizeNWSE;
					startPos = downPos;
					curSize = this.Size;
					resizeTimer.Start();
				}
				else
				{
					Cursor.Current = Cursors.SizeAll;
					ReleaseCapture();
					SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
				}
			}
		}

		private void AreaForm_MouseUp(object sender, MouseEventArgs e)
		{
			resizeTimer.Stop();
			Cursor.Current = Cursors.Default;
		}

		private void AreaForm_SizeChanged(object sender, EventArgs e)
		{
			this.Refresh();
		}

		private void AreaForm_LocationChanged(object sender, EventArgs e)
		{
			sizeBtn.Text = "X:" + (this.Location.X + 1) + "\nY:" + (this.Location.Y + 1);
		}
	}
}
