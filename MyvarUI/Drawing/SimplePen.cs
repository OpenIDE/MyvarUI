using System;

namespace MyvarUI.Drawing
{
    public class SimplePen : Pen
    {
        public SimplePen(Brush brush, float width) : base(brush, width)
        {
        }

        public SimplePen(Brush brush) : base(brush)
        {
        }

        public SimplePen(Color color, float width) : base(color, width)
        {
        }

        public SimplePen(Color color) : base(color)
        {
        }

        public override void Draw(Graphics g, Point point)
        {
            if (Width <= 1) base.Draw(g, point);

            int width = (int)Math.Floor(Width);
            float maxDistance = point.DistanceTo(new Point(point.X + width, point.Y + width));
            for (int x = point.X - width; x < point.X + width; x++)
            {
                for (int y = point.Y - width; y < point.Y + width; y++)
                {
                    int distance = point.DistanceTo(new Point(x, y));
                    float percentage = (distance / maxDistance) * 10f;

                    g.SetPixel(x, y, LightenColor(Brush.Color, percentage));
                }
            }
        }
    }
}
