using System;
using MyvarUI.Drawing;
using MyvarUI.Events;

namespace MyvarUI.Window.Controls
{
    public class Button : Control
    {
        public string Text { get; set; } = "Button";
        public int FontSize { get; set; } = 15;

        public Button()
        {
            X = 10;
            Y = 10;

            Width = 75;
            Height = 25;
        }

        public override void Draw(Graphics g)
        {
            //draw white box where button should be
            g.DrawFillRectangle(X, Y, Width, Height, Color.White);

            //draw text

            //calulate text size offset
            var sTxT = g.CalulateTextSize(Text, "", 15);
            
            g.DrawText(Text, X + (Width / 2 - (sTxT.Width / 2)),
             Y + (Height / 2 - (sTxT.Height / 2)), "", FontSize,
              Color.Black);

            if (Focused)
            {
                g.DrawRectangle(X, Y, Width - 1, Height - 1, Color.Blue);
            }
        }
    }
}