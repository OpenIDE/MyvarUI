namespace MyvarUI
{
    public class Color
    {
        public static Color Empty { get; }

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

        public int ToArgb()
        {
            return (int)((uint)A << 24) + (R << 16) + (G << 8) + B;
        }

        public byte[] ToArray()
        {
            return new byte[] { R, G, B, A };
        }

        public ColorStruct ToStruct()
        {
            return new ColorStruct() { R = R, G = G, B = B, A = A };
        }

        public static Color FromArgb(byte a, byte r, byte g, byte b)
        {
            return new Color(r,g,b,a);
        }

        public static Color FromArgb(byte r, byte g, byte b)
        {
            return new Color(r, g, b, 255);
        }
   
        public static Color FromArgb(int argb)
        {
            return FromArgb((byte) ((argb >> 24) & 0x0FF), (byte) ((argb >> 16) & 0x0FF), (byte) ((argb >> 8) & 0x0FF), (byte) (argb & 0x0FF));
        }

        public static Color FromKnownColor(KnownColor color)
        {
            return KnownColors.FromKnownColor(color);
        }

        public static Color Transparent => KnownColors.FromKnownColor(KnownColor.Transparent);

        public static Color AliceBlue => KnownColors.FromKnownColor(KnownColor.AliceBlue);

        public static Color AntiqueWhite => KnownColors.FromKnownColor(KnownColor.AntiqueWhite);

        public static Color Aqua => KnownColors.FromKnownColor(KnownColor.Aqua);

        public static Color Aquamarine => KnownColors.FromKnownColor(KnownColor.Aquamarine);

        public static Color Azure => KnownColors.FromKnownColor(KnownColor.Azure);

        public static Color Beige => KnownColors.FromKnownColor(KnownColor.Beige);

        public static Color Bisque => KnownColors.FromKnownColor(KnownColor.Bisque);

        public static Color Black => KnownColors.FromKnownColor(KnownColor.Black);

        public static Color BlanchedAlmond => KnownColors.FromKnownColor(KnownColor.BlanchedAlmond);

        public static Color Blue => KnownColors.FromKnownColor(KnownColor.Blue);

        public static Color BlueViolet => KnownColors.FromKnownColor(KnownColor.BlueViolet);

        public static Color Brown => KnownColors.FromKnownColor(KnownColor.Brown);

        public static Color BurlyWood => KnownColors.FromKnownColor(KnownColor.BurlyWood);

        public static Color CadetBlue => KnownColors.FromKnownColor(KnownColor.CadetBlue);

        public static Color Chartreuse => KnownColors.FromKnownColor(KnownColor.Chartreuse);

        public static Color Chocolate => KnownColors.FromKnownColor(KnownColor.Chocolate);

        public static Color Coral => KnownColors.FromKnownColor(KnownColor.Coral);

        public static Color CornflowerBlue => KnownColors.FromKnownColor(KnownColor.CornflowerBlue);

        public static Color Cornsilk => KnownColors.FromKnownColor(KnownColor.Cornsilk);

        public static Color Crimson => KnownColors.FromKnownColor(KnownColor.Crimson);

        public static Color Cyan => KnownColors.FromKnownColor(KnownColor.Cyan);

        public static Color DarkBlue => KnownColors.FromKnownColor(KnownColor.DarkBlue);

        public static Color DarkCyan => KnownColors.FromKnownColor(KnownColor.DarkCyan);

        public static Color DarkGoldenrod => KnownColors.FromKnownColor(KnownColor.DarkGoldenrod);

        public static Color DarkGray => KnownColors.FromKnownColor(KnownColor.DarkGray);

        public static Color DarkGreen => KnownColors.FromKnownColor(KnownColor.DarkGreen);

        public static Color DarkKhaki => KnownColors.FromKnownColor(KnownColor.DarkKhaki);

        public static Color DarkMagenta => KnownColors.FromKnownColor(KnownColor.DarkMagenta);

        public static Color DarkOliveGreen => KnownColors.FromKnownColor(KnownColor.DarkOliveGreen);

        public static Color DarkOrange => KnownColors.FromKnownColor(KnownColor.DarkOrange);

        public static Color DarkOrchid => KnownColors.FromKnownColor(KnownColor.DarkOrchid);

        public static Color DarkRed => KnownColors.FromKnownColor(KnownColor.DarkRed);

        public static Color DarkSalmon => KnownColors.FromKnownColor(KnownColor.DarkSalmon);

        public static Color DarkSeaGreen => KnownColors.FromKnownColor(KnownColor.DarkSeaGreen);

        public static Color DarkSlateBlue => KnownColors.FromKnownColor(KnownColor.DarkSlateBlue);

        public static Color DarkSlateGray => KnownColors.FromKnownColor(KnownColor.DarkSlateGray);

        public static Color DarkTurquoise => KnownColors.FromKnownColor(KnownColor.DarkTurquoise);

        public static Color DarkViolet => KnownColors.FromKnownColor(KnownColor.DarkViolet);

        public static Color DeepPink => KnownColors.FromKnownColor(KnownColor.DeepPink);

        public static Color DeepSkyBlue => KnownColors.FromKnownColor(KnownColor.DeepSkyBlue);

        public static Color DimGray => KnownColors.FromKnownColor(KnownColor.DimGray);

        public static Color DodgerBlue => KnownColors.FromKnownColor(KnownColor.DodgerBlue);

        public static Color Firebrick => KnownColors.FromKnownColor(KnownColor.Firebrick);

        public static Color FloralWhite => KnownColors.FromKnownColor(KnownColor.FloralWhite);

        public static Color ForestGreen => KnownColors.FromKnownColor(KnownColor.ForestGreen);

        public static Color Fuchsia => KnownColors.FromKnownColor(KnownColor.Fuchsia);

        public static Color Gainsboro => KnownColors.FromKnownColor(KnownColor.Gainsboro);

        public static Color GhostWhite => KnownColors.FromKnownColor(KnownColor.GhostWhite);

        public static Color Gold => KnownColors.FromKnownColor(KnownColor.Gold);

        public static Color Goldenrod => KnownColors.FromKnownColor(KnownColor.Goldenrod);

        public static Color Gray => KnownColors.FromKnownColor(KnownColor.Gray);

        public static Color Green => KnownColors.FromKnownColor(KnownColor.Green);

        public static Color GreenYellow => KnownColors.FromKnownColor(KnownColor.GreenYellow);

        public static Color Honeydew => KnownColors.FromKnownColor(KnownColor.Honeydew);

        public static Color HotPink => KnownColors.FromKnownColor(KnownColor.HotPink);

        public static Color IndianRed => KnownColors.FromKnownColor(KnownColor.IndianRed);

        public static Color Indigo => KnownColors.FromKnownColor(KnownColor.Indigo);

        public static Color Ivory => KnownColors.FromKnownColor(KnownColor.Ivory);

        public static Color Khaki => KnownColors.FromKnownColor(KnownColor.Khaki);

        public static Color Lavender => KnownColors.FromKnownColor(KnownColor.Lavender);

        public static Color LavenderBlush => KnownColors.FromKnownColor(KnownColor.LavenderBlush);

        public static Color LawnGreen => KnownColors.FromKnownColor(KnownColor.LawnGreen);

        public static Color LemonChiffon => KnownColors.FromKnownColor(KnownColor.LemonChiffon);

        public static Color LightBlue => KnownColors.FromKnownColor(KnownColor.LightBlue);

        public static Color LightCoral => KnownColors.FromKnownColor(KnownColor.LightCoral);

        public static Color LightCyan => KnownColors.FromKnownColor(KnownColor.LightCyan);

        public static Color LightGoldenrodYellow => KnownColors.FromKnownColor(KnownColor.LightGoldenrodYellow);

        public static Color LightGreen => KnownColors.FromKnownColor(KnownColor.LightGreen);

        public static Color LightGray => KnownColors.FromKnownColor(KnownColor.LightGray);

        public static Color LightPink => KnownColors.FromKnownColor(KnownColor.LightPink);

        public static Color LightSalmon => KnownColors.FromKnownColor(KnownColor.LightSalmon);

        public static Color LightSeaGreen => KnownColors.FromKnownColor(KnownColor.LightSeaGreen);

        public static Color LightSkyBlue => KnownColors.FromKnownColor(KnownColor.LightSkyBlue);

        public static Color LightSlateGray => KnownColors.FromKnownColor(KnownColor.LightSlateGray);

        public static Color LightSteelBlue => KnownColors.FromKnownColor(KnownColor.LightSteelBlue);

        public static Color LightYellow => KnownColors.FromKnownColor(KnownColor.LightYellow);

        public static Color Lime => KnownColors.FromKnownColor(KnownColor.Lime);

        public static Color LimeGreen => KnownColors.FromKnownColor(KnownColor.LimeGreen);

        public static Color Linen => KnownColors.FromKnownColor(KnownColor.Linen);

        public static Color Magenta => KnownColors.FromKnownColor(KnownColor.Magenta);

        public static Color Maroon => KnownColors.FromKnownColor(KnownColor.Maroon);

        public static Color MediumAquamarine => KnownColors.FromKnownColor(KnownColor.MediumAquamarine);

        public static Color MediumBlue => KnownColors.FromKnownColor(KnownColor.MediumBlue);

        public static Color MediumOrchid => KnownColors.FromKnownColor(KnownColor.MediumOrchid);

        public static Color MediumPurple => KnownColors.FromKnownColor(KnownColor.MediumPurple);

        public static Color MediumSeaGreen => KnownColors.FromKnownColor(KnownColor.MediumSeaGreen);

        public static Color MediumSlateBlue => KnownColors.FromKnownColor(KnownColor.MediumSlateBlue);

        public static Color MediumSpringGreen => KnownColors.FromKnownColor(KnownColor.MediumSpringGreen);

        public static Color MediumTurquoise => KnownColors.FromKnownColor(KnownColor.MediumTurquoise);

        public static Color MediumVioletRed => KnownColors.FromKnownColor(KnownColor.MediumVioletRed);

        public static Color MidnightBlue => KnownColors.FromKnownColor(KnownColor.MidnightBlue);

        public static Color MintCream => KnownColors.FromKnownColor(KnownColor.MintCream);

        public static Color MistyRose => KnownColors.FromKnownColor(KnownColor.MistyRose);

        public static Color Moccasin => KnownColors.FromKnownColor(KnownColor.Moccasin);

        public static Color NavajoWhite => KnownColors.FromKnownColor(KnownColor.NavajoWhite);

        public static Color Navy => KnownColors.FromKnownColor(KnownColor.Navy);

        public static Color OldLace => KnownColors.FromKnownColor(KnownColor.OldLace);

        public static Color Olive => KnownColors.FromKnownColor(KnownColor.Olive);

        public static Color OliveDrab => KnownColors.FromKnownColor(KnownColor.OliveDrab);

        public static Color Orange => KnownColors.FromKnownColor(KnownColor.Orange);

        public static Color OrangeRed => KnownColors.FromKnownColor(KnownColor.OrangeRed);

        public static Color Orchid => KnownColors.FromKnownColor(KnownColor.Orchid);

        public static Color PaleGoldenrod => KnownColors.FromKnownColor(KnownColor.PaleGoldenrod);

        public static Color PaleGreen => KnownColors.FromKnownColor(KnownColor.PaleGreen);

        public static Color PaleTurquoise => KnownColors.FromKnownColor(KnownColor.PaleTurquoise);

        public static Color PaleVioletRed => KnownColors.FromKnownColor(KnownColor.PaleVioletRed);

        public static Color PapayaWhip => KnownColors.FromKnownColor(KnownColor.PapayaWhip);

        public static Color PeachPuff => KnownColors.FromKnownColor(KnownColor.PeachPuff);

        public static Color Peru => KnownColors.FromKnownColor(KnownColor.Peru);

        public static Color Pink => KnownColors.FromKnownColor(KnownColor.Pink);

        public static Color Plum => KnownColors.FromKnownColor(KnownColor.Plum);

        public static Color PowderBlue => KnownColors.FromKnownColor(KnownColor.PowderBlue);

        public static Color Purple => KnownColors.FromKnownColor(KnownColor.Purple);

        public static Color Red => KnownColors.FromKnownColor(KnownColor.Red);

        public static Color RosyBrown => KnownColors.FromKnownColor(KnownColor.RosyBrown);

        public static Color RoyalBlue => KnownColors.FromKnownColor(KnownColor.RoyalBlue);

        public static Color SaddleBrown => KnownColors.FromKnownColor(KnownColor.SaddleBrown);

        public static Color Salmon => KnownColors.FromKnownColor(KnownColor.Salmon);

        public static Color SandyBrown => KnownColors.FromKnownColor(KnownColor.SandyBrown);

        public static Color SeaGreen => KnownColors.FromKnownColor(KnownColor.SeaGreen);

        public static Color SeaShell => KnownColors.FromKnownColor(KnownColor.SeaShell);

        public static Color Sienna => KnownColors.FromKnownColor(KnownColor.Sienna);

        public static Color Silver => KnownColors.FromKnownColor(KnownColor.Silver);

        public static Color SkyBlue => KnownColors.FromKnownColor(KnownColor.SkyBlue);

        public static Color SlateBlue => KnownColors.FromKnownColor(KnownColor.SlateBlue);

        public static Color SlateGray => KnownColors.FromKnownColor(KnownColor.SlateGray);

        public static Color Snow => KnownColors.FromKnownColor(KnownColor.Snow);

        public static Color SpringGreen => KnownColors.FromKnownColor(KnownColor.SpringGreen);

        public static Color SteelBlue => KnownColors.FromKnownColor(KnownColor.SteelBlue);

        public static Color Tan => KnownColors.FromKnownColor(KnownColor.Tan);

        public static Color Teal => KnownColors.FromKnownColor(KnownColor.Teal);

        public static Color Thistle => KnownColors.FromKnownColor(KnownColor.Thistle);

        public static Color Tomato => KnownColors.FromKnownColor(KnownColor.Tomato);

        public static Color Turquoise => KnownColors.FromKnownColor(KnownColor.Turquoise);

        public static Color Violet => KnownColors.FromKnownColor(KnownColor.Violet);

        public static Color Wheat => KnownColors.FromKnownColor(KnownColor.Wheat);

        public static Color White => KnownColors.FromKnownColor(KnownColor.White);

        public static Color WhiteSmoke => KnownColors.FromKnownColor(KnownColor.WhiteSmoke);

        public static Color Yellow => KnownColors.FromKnownColor(KnownColor.Yellow);

        public static Color YellowGreen => KnownColors.FromKnownColor(KnownColor.YellowGreen);
    }

    public struct ColorStruct
    {
        public byte R, G, B, A;
    }
}