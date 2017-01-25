using System;
using MyvarUI.Drawing;
using MyvarUI.Events;

namespace MyvarUI.Window.Controls
{
    public class ContextMenuButton : ControlContainer
    {
        public string Text { get; set; } = "Button";
        public int FontSize { get; set; } = 15;

        public bool ShowDropDown { get; set; }

        public ContextMenuButton()
        {
            X = 2;
            Y = 2;

            Width = 75;
            Height = 25;

            this.MouseClick += InternalClick;
        }

        private void InternalClick(object sender, MouseEventArgs args)
        {
            ShowDropDown = !ShowDropDown;
        }

        public override void Draw(Graphics g)
        {

            if(Hidden)
            {
                return;
            }

            for (int c = 0; c < Controls.Count; c++)
            {
                if (c > Controls.Count) break; //Prevent index out of range exceptions if the controls change.
                Controls[c].Hidden = !ShowDropDown;
            }

            //draw white box where button should be
            g.DrawFillRectangle(0, 0, Width, Height, BackgroundColor);

            //calulate text size offset
            var sTxT = g.CalulateTextSize(Text, "", 15);

            Width = sTxT.W + 10;

            g.DrawText(Text, 0 + (Width / 2 - (sTxT.W / 2)),
             0 + (Height / 2 - (sTxT.H / 2)), "", FontSize,
              ForegroundColor);

            if (Focused)
            {
                const int hoffset = 9;
                var hcolor = Color.FromArgb(
                    BackgroundColor.R - (BackgroundColor.R / hoffset),
                    BackgroundColor.G - (BackgroundColor.G / hoffset),
                    BackgroundColor.B - (BackgroundColor.B / hoffset)
                );
                g.DrawRectangle(0, 0, Width - 1, Height - 1, hcolor);
            }

           // if (ShowDropDown)
            {
                int count = Controls.Count;
                int yOffset = Height;
                for (int c = 0; c < count; c++)
                {
                    if (c > Controls.Count) break; //Prevent index out of range exceptions if the controls change.
                    var i = Controls[c];
                    i.X = X;
                    i.Y = yOffset;
                    g.SetOffset(X, yOffset);

                    yOffset += i.Height;

                    i.Draw(g);
                }
            }
        }
    }
}