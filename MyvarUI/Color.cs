using System;

namespace MyvarUI
{
    // Authors:
    // 	Dennis Hayes (dennish@raytek.com)
    // 	Ben Houston  (ben@exocortex.org)
    // 	Gonzalo Paniagua (gonzalo@ximian.com)
    // 	Juraj Skripsky (juraj@hotfeet.ch)
    //	Sebastien Pouliot  <sebastien@ximian.com>
    //  Taken from: https://github.com/mono/mono/blob/master/mcs/class/System.Drawing/System.Drawing/Color.cs
    public struct Color
    {
        // Private transparency (A) and R,G,B fields.
        private long _value;

        // The specs also indicate that all three of these properties are true
        // if created with FromKnownColor or FromNamedColor, false otherwise (FromARGB).
        // Per Microsoft and ECMA specs these varibles are set by which constructor is used, not by their values.
        internal enum ColorType : short
        {
            Empty = 0,
            Known = 1,
            Argb = 2,
            Named = 4,
            System = 8
        }

        internal short State;
        internal short KnownColor;
        // #if ONLY_1_1
        // Mono bug #324144 is holding this change
        // MS 1.1 requires this member to be present for serialization (not so in 2.0)
        // however it's bad to keep a string (reference) in a struct
        internal string name;
        // #endif

        public string Name
        {
            get
            {
#if NET_2_0_ONCE_MONO_BUG_324144_IS_FIXED
				if (IsNamedColor)
					return KnownColors.GetName (knownColor);
				else
					return String.Format ("{0:x}", ToArgb ());
#else
                // name is required for serialization under 1.x, but not under 2.0
                if (name == null)
                {
                    // Can happen with stuff deserialized from MS
                    if (IsNamedColor)
                        name = KnownColors.GetName(KnownColor);
                    else
                        name = string.Format("{0:x}", ToArgb());
                }
                return name;
#endif
            }
        }

        public bool IsKnownColor
        {
            get { return (State & ((short) ColorType.Known)) != 0; }
        }

        public bool IsSystemColor
        {
            get { return (State & ((short) ColorType.System)) != 0; }
        }

        public bool IsNamedColor
        {
            get { return (State & (short) (ColorType.Known | ColorType.Named)) != 0; }
        }

        internal long Value
        {
            get
            {
                // Optimization for known colors that were deserialized
                // from an MS serialized stream.  
                if (_value == 0 && IsKnownColor)
                {
                    _value = KnownColors.FromKnownColor((KnownColor) KnownColor).ToArgb() & 0xFFFFFFFF;
                }
                return _value;
            }
            set { this._value = value; }
        }

        public static Color FromArgb(int red, int green, int blue)
        {
            return FromArgb(255, red, green, blue);
        }

        public static Color FromArgb(int alpha, int red, int green, int blue)
        {
            CheckArgbValues(alpha, red, green, blue);
            Color color = new Color();
            color.State = (short) ColorType.Argb;
            color.Value = (int) ((uint) alpha << 24) + (red << 16) + (green << 8) + blue;
            return color;
        }

        public int ToArgb()
        {
            return (int) Value;
        }

        public static Color FromArgb(int alpha, Color baseColor)
        {
            return FromArgb(alpha, baseColor.R, baseColor.G, baseColor.B);
        }

        public static Color FromArgb(int argb)
        {
            return FromArgb((argb >> 24) & 0x0FF, (argb >> 16) & 0x0FF, (argb >> 8) & 0x0FF, argb & 0x0FF);
        }

        public static Color FromKnownColor(KnownColor color)
        {
            return KnownColors.FromKnownColor(color);
        }

        public static Color FromName(string name)
        {
            try
            {
                KnownColor kc = (KnownColor) Enum.Parse(typeof(KnownColor), name, true);
                return KnownColors.FromKnownColor(kc);
            }
            catch
            {
                // This is what it returns! 	 
                Color d = FromArgb(0, 0, 0, 0);
                d.name = name;
                d.State |= (short) ColorType.Named;
                return d;
            }
        }


        // -----------------------
        // Public Shared Members
        // -----------------------

        /// <summary>
        ///	Empty Shared Field
        /// </summary>
        ///
        /// <remarks>
        ///	An uninitialized Color Structure
        /// </remarks>
        public static readonly Color Empty;

        /// <summary>
        ///	Equality Operator
        /// </summary>
        ///
        /// <remarks>
        ///	Compares two Color objects. The return value is
        ///	based on the equivalence of the A,R,G,B properties 
        ///	of the two Colors.
        /// </remarks>
        public static bool operator ==(Color left, Color right)
        {
            if (left.Value != right.Value)
                return false;
            if (left.IsNamedColor != right.IsNamedColor)
                return false;
            if (left.IsSystemColor != right.IsSystemColor)
                return false;
            if (left.IsEmpty != right.IsEmpty)
                return false;
            if (left.IsNamedColor)
            {
                // then both are named (see previous check) and so we need to compare them
                // but otherwise we don't as it kills performance (Name calls String.Format)
                if (left.Name != right.Name)
                    return false;
            }
            return true;
        }

        /// <summary>
        ///	Inequality Operator
        /// </summary>
        ///
        /// <remarks>
        ///	Compares two Color objects. The return value is
        ///	based on the equivalence of the A,R,G,B properties 
        ///	of the two colors.
        /// </remarks>
        public static bool operator !=(Color left, Color right)
        {
            return !(left == right);
        }

        public float GetBrightness()
        {
            byte minval = Math.Min(R, Math.Min(G, B));
            byte maxval = Math.Max(R, Math.Max(G, B));

            return (float) (maxval + minval) / 510;
        }

        public float GetSaturation()
        {
            byte minval = (byte) Math.Min(R, Math.Min(G, B));
            byte maxval = (byte) Math.Max(R, Math.Max(G, B));

            if (maxval == minval)
                return 0.0f;

            int sum = maxval + minval;
            if (sum > 255)
                sum = 510 - sum;

            return (float) (maxval - minval) / sum;
        }

        public float GetHue()
        {
            int r = R;
            int g = G;
            int b = B;
            byte minval = (byte) Math.Min(r, Math.Min(g, b));
            byte maxval = (byte) Math.Max(r, Math.Max(g, b));

            if (maxval == minval)
                return 0.0f;

            float diff = (float) (maxval - minval);
            float rnorm = (maxval - r) / diff;
            float gnorm = (maxval - g) / diff;
            float bnorm = (maxval - b) / diff;

            float hue = 0.0f;
            if (r == maxval)
                hue = 60.0f * (6.0f + bnorm - gnorm);
            if (g == maxval)
                hue = 60.0f * (2.0f + rnorm - bnorm);
            if (b == maxval)
                hue = 60.0f * (4.0f + gnorm - rnorm);
            if (hue > 360.0f)
                hue = hue - 360.0f;

            return hue;
        }

        // -----------------------
        // Public Instance Members
        // -----------------------

        /// <summary>
        ///	ToKnownColor method
        /// </summary>
        ///
        /// <remarks>
        ///	Returns the KnownColor enum value for this color, 0 if is not known.
        /// </remarks>
        public KnownColor ToKnownColor()
        {
            return (KnownColor) KnownColor;
        }

        /// <summary>
        ///	IsEmpty Property
        /// </summary>
        ///
        /// <remarks>
        ///	Indicates transparent black. R,G,B = 0; A=0?
        /// </remarks>
        public bool IsEmpty
        {
            get { return State == (short) ColorType.Empty; }
        }

        public byte A
        {
            get { return (byte) (Value >> 24); }
        }

        public byte R
        {
            get { return (byte) (Value >> 16); }
        }

        public byte G
        {
            get { return (byte) (Value >> 8); }
        }

        public byte B
        {
            get { return (byte) Value; }
        }

        /// <summary>
        ///	Equals Method
        /// </summary>
        ///
        /// <remarks>
        ///	Checks equivalence of this Color and another object.
        /// </remarks>
        public override bool Equals(object obj)
        {
            if (!(obj is Color))
                return false;
            Color c = (Color) obj;
            return this == c;
        }

        /// <summary>
        ///	Reference Equals Method
        ///	Is commented out because this is handled by the base class.
        ///	TODO: Is it correct to let the base class handel reference equals
        /// </summary>
        ///
        /// <remarks>
        ///	Checks equivalence of this Color and another object.
        /// </remarks>
        //public bool ReferenceEquals (object o)
        //{
        //	if (!(o is Color))return false;
        //	return (this == (Color) o);
        //}
        /// <summary>
        ///	GetHashCode Method
        /// </summary>
        ///
        /// <remarks>
        ///	Calculates a hashing value.
        /// </remarks>
        public override int GetHashCode()
        {
            int hc = (int) (Value ^ (Value >> 32) ^ State ^ (KnownColor >> 16));
            if (IsNamedColor)
                hc ^= Name.GetHashCode();
            return hc;
        }

        /// <summary>
        ///	ToString Method
        /// </summary>
        ///
        /// <remarks>
        ///	Formats the Color as a string in ARGB notation.
        /// </remarks>
        public override string ToString()
        {
            if (IsEmpty)
                return "Color [Empty]";

            // Use the property here, not the field.
            if (IsNamedColor)
                return "Color [" + Name + "]";

            return string.Format("Color [A={0}, R={1}, G={2}, B={3}]", A, R, G, B);
        }

        private static void CheckRgbValues(int red, int green, int blue)
        {
            if ((red > 255) || (red < 0))
                throw CreateColorArgumentException(red, "red");
            if ((green > 255) || (green < 0))
                throw CreateColorArgumentException(green, "green");
            if ((blue > 255) || (blue < 0))
                throw CreateColorArgumentException(blue, "blue");
        }

        private static ArgumentException CreateColorArgumentException(int value, string color)
        {
            return new ArgumentException(string.Format("'{0}' is not a valid"
                                                       + " value for '{1}'. '{1}' should be greater or equal to 0 and"
                                                       + " less than or equal to 255.", value, color));
        }

        private static void CheckArgbValues(int alpha, int red, int green, int blue)
        {
            if ((alpha > 255) || (alpha < 0))
                throw CreateColorArgumentException(alpha, "alpha");
            CheckRgbValues(red, green, blue);
        }


        static public Color Transparent
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Transparent); }
        }

        static public Color AliceBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.AliceBlue); }
        }

        static public Color AntiqueWhite
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.AntiqueWhite); }
        }

        static public Color Aqua
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Aqua); }
        }

        static public Color Aquamarine
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Aquamarine); }
        }

        static public Color Azure
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Azure); }
        }

        static public Color Beige
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Beige); }
        }

        static public Color Bisque
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Bisque); }
        }

        static public Color Black
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Black); }
        }

        static public Color BlanchedAlmond
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.BlanchedAlmond); }
        }

        static public Color Blue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Blue); }
        }

        static public Color BlueViolet
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.BlueViolet); }
        }

        static public Color Brown
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Brown); }
        }

        static public Color BurlyWood
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.BurlyWood); }
        }

        static public Color CadetBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.CadetBlue); }
        }

        static public Color Chartreuse
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Chartreuse); }
        }

        static public Color Chocolate
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Chocolate); }
        }

        static public Color Coral
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Coral); }
        }

        static public Color CornflowerBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.CornflowerBlue); }
        }

        static public Color Cornsilk
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Cornsilk); }
        }

        static public Color Crimson
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Crimson); }
        }

        static public Color Cyan
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Cyan); }
        }

        static public Color DarkBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkBlue); }
        }

        static public Color DarkCyan
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkCyan); }
        }

        static public Color DarkGoldenrod
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkGoldenrod); }
        }

        static public Color DarkGray
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkGray); }
        }

        static public Color DarkGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkGreen); }
        }

        static public Color DarkKhaki
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkKhaki); }
        }

        static public Color DarkMagenta
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkMagenta); }
        }

        static public Color DarkOliveGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkOliveGreen); }
        }

        static public Color DarkOrange
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkOrange); }
        }

        static public Color DarkOrchid
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkOrchid); }
        }

        static public Color DarkRed
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkRed); }
        }

        static public Color DarkSalmon
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkSalmon); }
        }

        static public Color DarkSeaGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkSeaGreen); }
        }

        static public Color DarkSlateBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkSlateBlue); }
        }

        static public Color DarkSlateGray
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkSlateGray); }
        }

        static public Color DarkTurquoise
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkTurquoise); }
        }

        static public Color DarkViolet
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DarkViolet); }
        }

        static public Color DeepPink
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DeepPink); }
        }

        static public Color DeepSkyBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DeepSkyBlue); }
        }

        static public Color DimGray
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DimGray); }
        }

        static public Color DodgerBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.DodgerBlue); }
        }

        static public Color Firebrick
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Firebrick); }
        }

        static public Color FloralWhite
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.FloralWhite); }
        }

        static public Color ForestGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.ForestGreen); }
        }

        static public Color Fuchsia
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Fuchsia); }
        }

        static public Color Gainsboro
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Gainsboro); }
        }

        static public Color GhostWhite
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.GhostWhite); }
        }

        static public Color Gold
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Gold); }
        }

        static public Color Goldenrod
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Goldenrod); }
        }

        static public Color Gray
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Gray); }
        }

        static public Color Green
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Green); }
        }

        static public Color GreenYellow
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.GreenYellow); }
        }

        static public Color Honeydew
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Honeydew); }
        }

        static public Color HotPink
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.HotPink); }
        }

        static public Color IndianRed
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.IndianRed); }
        }

        static public Color Indigo
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Indigo); }
        }

        static public Color Ivory
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Ivory); }
        }

        static public Color Khaki
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Khaki); }
        }

        static public Color Lavender
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Lavender); }
        }

        static public Color LavenderBlush
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LavenderBlush); }
        }

        static public Color LawnGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LawnGreen); }
        }

        static public Color LemonChiffon
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LemonChiffon); }
        }

        static public Color LightBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightBlue); }
        }

        static public Color LightCoral
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightCoral); }
        }

        static public Color LightCyan
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightCyan); }
        }

        static public Color LightGoldenrodYellow
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightGoldenrodYellow); }
        }

        static public Color LightGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightGreen); }
        }

        static public Color LightGray
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightGray); }
        }

        static public Color LightPink
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightPink); }
        }

        static public Color LightSalmon
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightSalmon); }
        }

        static public Color LightSeaGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightSeaGreen); }
        }

        static public Color LightSkyBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightSkyBlue); }
        }

        static public Color LightSlateGray
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightSlateGray); }
        }

        static public Color LightSteelBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightSteelBlue); }
        }

        static public Color LightYellow
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LightYellow); }
        }

        static public Color Lime
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Lime); }
        }

        static public Color LimeGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.LimeGreen); }
        }

        static public Color Linen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Linen); }
        }

        static public Color Magenta
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Magenta); }
        }

        static public Color Maroon
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Maroon); }
        }

        static public Color MediumAquamarine
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.MediumAquamarine); }
        }

        static public Color MediumBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.MediumBlue); }
        }

        static public Color MediumOrchid
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.MediumOrchid); }
        }

        static public Color MediumPurple
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.MediumPurple); }
        }

        static public Color MediumSeaGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.MediumSeaGreen); }
        }

        static public Color MediumSlateBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.MediumSlateBlue); }
        }

        static public Color MediumSpringGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.MediumSpringGreen); }
        }

        static public Color MediumTurquoise
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.MediumTurquoise); }
        }

        static public Color MediumVioletRed
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.MediumVioletRed); }
        }

        static public Color MidnightBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.MidnightBlue); }
        }

        static public Color MintCream
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.MintCream); }
        }

        static public Color MistyRose
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.MistyRose); }
        }

        static public Color Moccasin
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Moccasin); }
        }

        static public Color NavajoWhite
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.NavajoWhite); }
        }

        static public Color Navy
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Navy); }
        }

        static public Color OldLace
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.OldLace); }
        }

        static public Color Olive
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Olive); }
        }

        static public Color OliveDrab
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.OliveDrab); }
        }

        static public Color Orange
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Orange); }
        }

        static public Color OrangeRed
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.OrangeRed); }
        }

        static public Color Orchid
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Orchid); }
        }

        static public Color PaleGoldenrod
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.PaleGoldenrod); }
        }

        static public Color PaleGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.PaleGreen); }
        }

        static public Color PaleTurquoise
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.PaleTurquoise); }
        }

        static public Color PaleVioletRed
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.PaleVioletRed); }
        }

        static public Color PapayaWhip
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.PapayaWhip); }
        }

        static public Color PeachPuff
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.PeachPuff); }
        }

        static public Color Peru
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Peru); }
        }

        static public Color Pink
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Pink); }
        }

        static public Color Plum
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Plum); }
        }

        static public Color PowderBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.PowderBlue); }
        }

        static public Color Purple
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Purple); }
        }

        static public Color Red
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Red); }
        }

        static public Color RosyBrown
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.RosyBrown); }
        }

        static public Color RoyalBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.RoyalBlue); }
        }

        static public Color SaddleBrown
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.SaddleBrown); }
        }

        static public Color Salmon
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Salmon); }
        }

        static public Color SandyBrown
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.SandyBrown); }
        }

        static public Color SeaGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.SeaGreen); }
        }

        static public Color SeaShell
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.SeaShell); }
        }

        static public Color Sienna
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Sienna); }
        }

        static public Color Silver
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Silver); }
        }

        static public Color SkyBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.SkyBlue); }
        }

        static public Color SlateBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.SlateBlue); }
        }

        static public Color SlateGray
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.SlateGray); }
        }

        static public Color Snow
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Snow); }
        }

        static public Color SpringGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.SpringGreen); }
        }

        static public Color SteelBlue
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.SteelBlue); }
        }

        static public Color Tan
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Tan); }
        }

        static public Color Teal
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Teal); }
        }

        static public Color Thistle
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Thistle); }
        }

        static public Color Tomato
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Tomato); }
        }

        static public Color Turquoise
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Turquoise); }
        }

        static public Color Violet
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Violet); }
        }

        static public Color Wheat
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Wheat); }
        }

        static public Color White
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.White); }
        }

        static public Color WhiteSmoke
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.WhiteSmoke); }
        }

        static public Color Yellow
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.Yellow); }
        }

        static public Color YellowGreen
        {
            get { return KnownColors.FromKnownColor(MyvarUI.KnownColor.YellowGreen); }
        }

        public static implicit operator ColorStruct(Color c)
        {
            return new ColorStruct()
            {
                A = c.A,
                R = c.R,
                G = c.G,
                B = c.B
            };
        }
    }

    public struct ColorStruct
    {
        public byte R, G, B, A;
    }
}