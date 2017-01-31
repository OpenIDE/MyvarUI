using System;
using System.Runtime.InteropServices;
using MyvarUI.SDL;

namespace MyvarUI
{
    public static class Globals
    {
        public static ISDL SDL { get; private set; } = null;
		public static OperatingSystem OS { get; }

	    public static void Init()
	    {
		    
	    }

        static Globals()
        {
            if (SDL == null)
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    SDL = new LinuxSDL();
					OS = OperatingSystem.Linux;
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    SDL = new WindowsSDL();
					OS = OperatingSystem.Windows;
                }
	            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
					throw new PlatformNotSupportedException();
	                OS = OperatingSystem.Mac;
                }
                else
                {
                    throw new PlatformNotSupportedException();
                }
                SDL.Init();
            }
        }
    }

	public enum OperatingSystem
	{
		Windows,
		Linux,
		Mac,
		Other
	}
}
