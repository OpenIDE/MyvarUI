using System;
using MyvarUI.Drawing;

namespace MyvarUI.Window.Controls
{
    public class ContextMenuDivider : Control
    {
        public ContextMenuDivider()
        {
            X = 10;
            Y = 10;

            Width = 75;
            Height = 2;
        }

        public override void Draw(Graphics g)
        {
            if (Hidden)
            {
                return;
            }

            //draw white box where button should be
            g.DrawFillRectangle(0, 0, Width, Height, BackgroundColor);
        }
    }
}