using MyvarUI.SDL;

namespace MyvarUI.Events
{
    public class KeyboardEventArgs : Event
    {
        public SdlKeycode Keycode { get; set; }
        public SdlScancode Scancode { get; set; }
        public KeyboardState State { get; set; }
        public SDL_Keymod Keymod { get; set; }
        public uint Unicode { get; set; }

        public char GetChar()
        {
            bool capsLock = (Keymod & SDL_Keymod.KMOD_CAPS) != 0;
            bool shift = (Keymod & SDL_Keymod.KMOD_SHIFT) != 0;

            char raw = (char)Keycode;
            if (Scancode >= SdlScancode.A && Scancode <= SdlScancode.Z) //Handle a-z
            {
                if (capsLock && !shift)
                {
                    raw = char.ToUpper(raw);
                }
                else if (!capsLock && shift)
                {
                    raw = char.ToUpper(raw);
                }
                
                return raw;
            }
       
            if (Scancode >= SdlScancode.D1 && Scancode <= SdlScancode.D0) //Number keys
            {
                //TODO: If shift is pressed, get special keys.

                return raw;
            }

            if (Scancode >= SdlScancode.Minus && Scancode <= SdlScancode.Slash)
            {
                //TODO: If shift is pressed, get special keys.

                return raw;
            }

            if (Scancode == SdlScancode.Tab) return '\t';
            if (Scancode == SdlScancode.Return) return '\r';
            if (Scancode == SdlScancode.Space) return ' ';

            return char.MinValue;
        }
    }
}