namespace MyvarUI
{
    public class Color
    {

        public static Color White { get; set; } = new Color(255);
        public static Color Black { get; set; } = new Color();
        public static Color Red { get; set; } = new Color(255, 0, 0);
        public static Color Green { get; set; } = new Color(0, 255, 0);
        public static Color Grey { get; set; } = new Color(125, 125, 125);
        public static Color Blue { get; set; } = new Color(0, 0, 255);

        public byte R, G, B, A;

        public Color()
        {

        }

        public Color(byte c)
        {
            R = c;
            G = c;
            B = c;
        }

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public Color(byte r, byte g, byte b, byte alpha)
        {
            R = r;
            G = g;
            B = b;
            A = alpha;
        }

        public byte[] ToArray()
        {
            return new byte[] { R, G, B, A };
        }

        public ColorStruct ToStruct()
        {
            return new ColorStruct() { R = R, G = G, B = B, A = A };
        }
    }

    public struct ColorStruct
    {
        public byte R, G, B, A;
    }
}