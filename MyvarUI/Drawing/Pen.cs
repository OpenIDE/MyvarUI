using System;

namespace MyvarUI.Drawing
{
    public class Pen : IDisposable
    {
        protected Brush Brush;
        protected float Width;
        public Pen(Brush brush, float width)
        {
            Brush = brush;
            Width = width;
        }

        public Pen(Brush brush) : this (brush, 1.0F)
        {
            
        }

        public Pen(Color color, float width) : this(new SolidBrush(color), width)
        {
            
        }

        public Pen(Color color) : this(color, 1.0f)
        {
            
        }

        public virtual void Draw(Graphics g, Point point)
        {
            int width = (int)Math.Floor(Width);
            for (int x = point.X - width; x < point.X + width; x++)
            {
                for (int y = point.Y - width; y < point.Y + width; y++)
                {
                    g.SetPixel(x, y, Brush.Color);
                }
            }
        }

        protected Color LightenColor(Color color, float correctionfactory = 50f)
        {
            correctionfactory = correctionfactory / 100f;
            const float rgb255 = 255f;
            return Color.FromArgb((int) (color.R + (rgb255 - color.R) * correctionfactory),
                (int) (color.G + (rgb255 - color.G) * correctionfactory),
                (int) (color.B + (rgb255 - color.B) * correctionfactory)
            );
        }

        protected Color DarkenColor(Color color, float correctionfactory = 50f)
        {
            const float hundredpercent = 100f;
            return Color.FromArgb((int) (color.R / hundredpercent * correctionfactory),
                (int) (color.G / hundredpercent * correctionfactory),
                (int) (color.B / hundredpercent * correctionfactory));
        }

        public void Dispose()
        {
            Brush?.Dispose();
        }
    }
}
