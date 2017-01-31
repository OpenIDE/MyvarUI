using System;
using MyvarUI.Drawing;

namespace MyvarUI.Window.Controls
{
    public class PictureBox : Control
    {
	    public Image Image { get; private set; } = null;
	    public PictureBox()
	    {
		    
	    }

	    public void SetImage(Image img)
	    {
		    Image = img;
	    }

	    public override void Draw(Graphics g)
	    {
		    if (Image == null) return;

			g.DrawImage(0, 0, Width, Height, Image);
	    }
    }
}