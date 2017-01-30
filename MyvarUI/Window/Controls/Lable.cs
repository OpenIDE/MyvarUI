using MyvarUI.Drawing;

namespace MyvarUI.Window.Controls
{
    public class Lable : Control
    {
        public string Text { get; set; } = "Lable";
        public int FontSize { get; set; } = 15;

        public Font Font { get; set; } = Font.FontFromName("Source Code Pro");

        public Color FontColor { get; set; } = Color.White;

        public Lable()
        {
            X = 10;
            Y = 10;
        }

        public override void Draw(Graphics g)
        {
            g.DrawText(Text, 0, 0, Font, FontSize, FontColor);
        }
    }
}