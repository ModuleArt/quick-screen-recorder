using System.Drawing;
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
			}

			this.Renderer = new CustomToolStripSystemRenderer(dark);
		}
	}

	internal class CustomToolStripSystemRenderer : ToolStripSystemRenderer
	{
		private bool darkMode = false;

		public CustomToolStripSystemRenderer(bool darkMode)
		{
			this.darkMode = darkMode;
		}

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }

		protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
		{
			if ((e.Item as ToolStripButton).Checked)
			{
				if ((e.Item as ToolStripButton).Pressed)
				{
					if (darkMode)
					{
						e.Graphics.FillRectangle(new SolidBrush(ThemeManager.DarkPaleColor), new Rectangle(1, 0, e.Item.Width - 1, e.Item.Height - 3));
					}
					else
					{
						e.Graphics.FillRectangle(new SolidBrush(ThemeManager.LightPaleColor), new Rectangle(1, 0, e.Item.Width - 1, e.Item.Height - 3));
					}

					e.Graphics.DrawRectangle(new Pen(ThemeManager.AccentColor), new Rectangle(1, 0, e.Item.Width - 2, e.Item.Height - 3));
				}
				else
				{
					if (darkMode)
					{
						e.Graphics.FillRectangle(new SolidBrush(ThemeManager.DarkPaleColor), new Rectangle(0, 0, e.Item.Width - 2, e.Item.Height - 3));
					}
					else
					{
						e.Graphics.FillRectangle(new SolidBrush(ThemeManager.LightPaleColor), new Rectangle(0, 0, e.Item.Width - 2, e.Item.Height - 3));
					}

					e.Graphics.DrawRectangle(new Pen(ThemeManager.AccentColor), new Rectangle(0, 0, e.Item.Width - 2, e.Item.Height - 3));
				}
			}
		}
	}
}
