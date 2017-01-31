using System;

namespace MyvarUI.Drawing
{
    public class SolidBrush : Brush
    {
        internal bool IsModifiable = true;
        private Color _color;
        public SolidBrush(Color color)
        {
            _color = color;
        }

        public SolidBrush(KnownColor knownColor) : this(MyvarUI.Color.FromKnownColor(knownColor))
        {
            
        }

        public override Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (IsModifiable)
                {
                    _color = value;
                }
                else
                    throw new ArgumentException("This SolidBrush object can't be modified.");
            }
        }
    }
}