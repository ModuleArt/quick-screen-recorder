using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quick_screen_recorder
{
	class CustomToolStrip : ToolStrip
	{
		public CustomToolStrip()
		{

		}

		public void SetDarkMode(bool dark, bool titlebar)
		{
			if (dark)
			{
				if (titlebar)
				{
					this.BackColor = ThemeManager.DarkMainColor;
				}
				else
				{
					this.BackColor = ThemeManager.DarkBackColor;
				}

				this.Renderer = new CustomToolStripSystemRenderer(dark);
			}
		}
	}

	internal class CustomToolStripSystemRenderer : ToolStripSystemRenderer
	{
		private bool darkMode;

		public CustomToolStripSystemRenderer(bool darkMode)
		{
			this.darkMode = darkMode;
		}

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }

		protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
		{
			base.OnRenderButtonBackground(e);

			if (darkMode && (e.Item as ToolStripButton).Checked)
			{
				e.Graphics.DrawRectangle(new Pen(ThemeManager.AccentColor), new Rectangle(1, 1, e.Item.Width - 4, e.Item.Height - 5));
			}
		}
	}
}
