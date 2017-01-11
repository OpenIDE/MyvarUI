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

            W = 75;
            H = 25;
        }

        public override void Draw(Graphics g)
        {
            //draw white box where button should be
            g.DrawFillRectangle(X, Y, W, H, Color.White);

            //draw text

            //calulate text size offset
            var sTxT = g.CalulateTextSize(Text, "", 15);
            
            g.DrawText(Text, X + (W / 2 - (sTxT.W / 2)),
             Y + (H / 2 - (sTxT.H / 2)), "", FontSize,
              Color.Black);

            if (Focused)
            {
                g.DrawRectangle(X, Y, W - 1, H - 1, Color.Blue);
            }
        }
    }
}