using System;

namespace MyvarUI.SDL
{ 
    public struct WindowInfo
    {
        public IntPtr Window;
        public IntPtr Renderer;

        internal WindowInfo(IntPtr window, IntPtr renderer)
        {
            Window = window;
            Renderer = renderer;
        }
    }
}
