using System;
using System.Runtime.InteropServices;
using MyvarUI.SDL;

namespace MyvarUI
{
    public static class Globals
    {
        public static ISDL SDL { get; private set; } = null;

        static Globals()
        {
            if (SDL == null)
            {
                bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
                bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

                if (isLinux)
                {
                    SDL = new LinuxSDL();
                }
                else if (isWindows)
                {
                    SDL = new WindowsSDL();
                }
                else
                {
                    throw new PlatformNotSupportedException();
                }
                SDL.Init();
            }
        }
    }
}
