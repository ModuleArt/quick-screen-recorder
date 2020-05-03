using System;
using System.Windows.Forms;

namespace quick_screen_recorder
{
	public partial class StopForm : Form
	{
		private DateTime startTime;

		public StopForm(DateTime startTime)
		{
			this.startTime = startTime;

			InitializeComponent();

			mainTimer.Start();
		}

		private void mainTimer_Tick(object sender, EventArgs e)
		{
			DateTime tickTime = DateTime.Now;
			TimeSpan result = tickTime - startTime;
			timeLabel.Text = string.Format("{0:D2}:{1:D2}.{2:D3}", result.Minutes, result.Seconds, result.Milliseconds);
		}

		private void recButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void StopForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			mainTimer.Stop();
			(Owner as MainForm).StopRec();
			(Owner as MainForm).Show();

			HotkeyManager.UnregisterHotKey(this.Handle, 0);
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == 0x0312)
			{
				Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
				HotkeyManager.KeyModifier modifier = (HotkeyManager.KeyModifier)((int)m.LParam & 0xFFFF);

				if (modifier == HotkeyManager.KeyModifier.Alt)
				{
					if (key == Keys.R)
					{
						this.Close();
					}
				}
			}
		}

		private void StopForm_Load(object sender, EventArgs e)
		{
			HotkeyManager.RegisterHotKey(this.Handle, 0, (int)HotkeyManager.KeyModifier.Alt, Keys.R.GetHashCode());
		}
	}
}
