using System;

namespace MyvarUI
{
    public class Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        public int DistanceTo(Point point)
        {
            return (int) Math.Sqrt(Math.Pow((point.X - X), 2) + Math.Pow((point.Y - Y), 2));
        }
    }
}