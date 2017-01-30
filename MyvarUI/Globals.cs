using System.Runtime.InteropServices;
using MyvarUI.SDL;

namespace MyvarUI
{
    public static class Globals
    {
        public static ISDL Isdl { get; private set; }

        static Globals()
        {
            bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

            if (isLinux)
            {
                Isdl = new LinuxIsdl();
            }
            else if (isWindows)
            {
                Isdl = new WindowsIsdl();
            }
        }
    }
}
