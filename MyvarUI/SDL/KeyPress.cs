namespace MyvarUI.SDL
{
    public sealed class KeyPress
    {
        public KeyboardState State { get; }
        public SdlScancode Scancode { get; }

        internal KeyPress(KeyboardState state, SdlScancode key)
        {
            State = state;
            Scancode = key;
        }
    }
}
