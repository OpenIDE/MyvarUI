using MyvarUI.Drawing;

namespace MyvarUI.Window.Controls
{
    public class Button : Control
    {
        public string Text { get; set; } = "Button";
        public int FontSize { get; set; } = 15;

        public Font Font { get; set; } = Font.FontFromName("Source Code Pro");

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
            g.DrawFillRectangle(0, 0, Width, Height, BackgroundColor);

            //draw text

            //calulate text size offset
            var sTxT = g.CalulateTextSize(Text, Font, 15);
            
            
            g.DrawText(Text, (Width / 2 - (sTxT.W / 2)),
            (Height / 2 - (sTxT.H / 2)), Font, FontSize,
              Color.Black);

            if (Focused)
            {
                g.DrawRectangle(0, 0, Width - 1, Height - 1, Color.Blue);
            }
        }
    }
}