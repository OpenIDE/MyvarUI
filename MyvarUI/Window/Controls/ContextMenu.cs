using System;
using MyvarUI.Drawing;

namespace MyvarUI.Window.Controls
{
    public class ContextMenu : ControlContainer
    {
        public ContextMenu()
        {
            Height = 30;
        }

        public override void Draw(Graphics g)
        {
            g.DrawFillRectangle(0, 0, this.Parent.Width, Height, BackgroundColor);


            int count = Controls.Count;
            int xOffset = 2;
            for (int c = 0; c < count; c++)
            {
                if (c > Controls.Count) break; //Prevent index out of range exceptions if the controls change.
                var i = Controls[c];

                g.SetOffset(xOffset, 3);

                xOffset += i.Width + 2;

                i.Draw(g);
            }

        }
    }
}