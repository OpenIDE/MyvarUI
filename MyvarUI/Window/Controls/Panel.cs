using MyvarUI.Drawing;

namespace MyvarUI.Window.Controls
{
    public class Panel : Control
    {
        public Color BackgroundColor { get; set; } = Color.FromKnownColor(KnownColor.Control);
        public override void Draw(Graphics g)
        {
            g.DrawFillRectangle(X, Y, Width, Height, BackgroundColor);

            if (Focused)
            {
                g.DrawRectangle(X, Y, Width, Height, Color.FromKnownColor(KnownColor.ActiveBorder));
            }
            else
            {
                g.DrawRectangle(X, Y, Width, Height, Color.FromKnownColor(KnownColor.InactiveBorder));
            }
        }
    }
}
