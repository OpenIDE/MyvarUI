namespace MyvarUI
{
    public struct Rectangle
    {
        public Point Min { get; set; }
        public Point Max { get; set; }

        public Rectangle(Point min, Point max)
        {
            Min = min;
            Max = max;
        }

        public bool Contains(Point point)
        {
            if (point.X >= Min.X && point.X <= Max.X)
            {
                if (point.Y >= Min.Y && point.Y <= Max.Y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
