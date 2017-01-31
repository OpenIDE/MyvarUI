using System;
using MyvarUI.SDL;

namespace MyvarUI.Drawing
{
    public class Graphics
    {
        private ISDL _displayPort;
        private int _xOffset;
        private int _yOfsset;

        public Graphics(ISDL displayport, int xOffset, int yOffset)
        {
            _displayPort = displayport;
            _xOffset = xOffset;
            _yOfsset = yOffset;
        }

        public void SetOffset(int x, int y)
        {
            _xOffset = x;
            _yOfsset = y;
        }

        public Point GetOffset()
        {
            return new Point(_xOffset, _yOfsset);
        }

        public void Clear(Color c)
        {
            _displayPort.Clear(c);
        }

        public void SetPixel(int x, int y, Color c)
        {
            _displayPort.SetPixel(x + _xOffset, y + _yOfsset, c);
        }

        public void DrawText(string text, int x, int y, Font font, int sizept, Color c)
        {
            _displayPort.DrawText(text, x + _xOffset, y + _yOfsset, font, sizept, c);
        }

        public Size CalulateTextSize(string text, Font font, int sizept)
        {
            return _displayPort.CalulateTextSize(text, font, sizept);
        }

        public void DrawLine(Point start, Point end, Pen pen)
        {
            int currentX = start.X;
            int currentY = start.Y;

            int dx = Math.Abs(end.X - start.X), 
                sx = start.X < end.X ? 1 : -1;

            int dy = Math.Abs(end.Y - start.Y), 
                sy = start.Y < end.Y ? 1 : -1;

            int err = (dx > dy ? dx : -dy) / 2;
            for (;;)
            {
                pen.Draw(this, new Point(currentX, currentY));
                if (currentX == end.X && currentY == end.Y) break;

                var e2 = err;
                if (e2 > -dx)
                {
                    err -= dy;
                    currentX += sx;
                }
                if (e2 < dy)
                {
                    err += dx;
                    currentY += sy;
                }
            }
        }

        public void DrawLine(int x, int y, int x2, int y2, Color color)
        {
            int w = x2 - x;
            int h = y2 - y;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;
            if (w < 0) dx1 = -1;
            else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1;
            else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1;
            else if (w > 0) dx2 = 1;
            int longest = w;
            int shortest = h;
            if (!(longest > shortest))
            {
                longest = h;
                shortest = w;
                if (h < 0) dy2 = -1;
                else if (h > 0) dy2 = 1;
                dx2 = 0;
            }
            int numerator = longest >> 1;
            for (int i = 0; i <= longest; i++)
            {
                SetPixel(x, y, color);
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }
        }

        public void DrawRectangle(int x, int y, int w, int h, Color c)
        {
            DrawLine(x, y, x + w, y, c);
            DrawLine(x, y, x, y + h, c);
            DrawLine(x, y + h, x + w, y + h, c);
            DrawLine(x + w, y, x + w, y + h, c);
        }

        public void DrawFillRectangle(int x, int y, int w, int h, Color c)
        {
            for (int x1 = x; x1 < x + w; x1++)
            {
                for (int y1 = y; y1 < y + h; y1++)
                {
                    SetPixel(x1, y1, c);
                }
            }
        }
    }
}