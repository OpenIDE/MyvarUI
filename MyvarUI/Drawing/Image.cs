using System;
using System.IO;
using System.Runtime.InteropServices;
using MyvarUI.SDL;
using MyvarUI.SDL.Wrappers;

namespace MyvarUI.Drawing
{
    public sealed unsafe class Image : IDisposable
    {
	    private IntPtr Surface;
		public IntPtr Texture { get; private set; }
	    public int Width { get; }
		public int Height { get; }
		internal Image(IntPtr image, IntPtr texture)
		{
			Surface = image;

			SdlSurface surface = Marshal.PtrToStructure<SdlSurface>(image);
			Width = surface.W;
			Height = surface.H;

			Texture = texture;
		}

	    public static Image FromFile(string file)
	    {
		    Image result = null;
			switch (Globals.OS)
			{
				case OperatingSystem.Windows:
					var a = SDL.Wrappers.Windows.SDLImage.IMG_Load(file);
					if (a == IntPtr.Zero)
					{
						throw new FileLoadException("Could not load image", file);
					}

					var texture = Globals.SDL.CreateTextureFromSurface(a);
					if (texture == IntPtr.Zero)
					{
						WindowsSdlWrapper.SDL_FreeSurface(a);
						throw new FileLoadException("Could not load image", file);
					}

					result = new Image(a, texture);
					break;
				case OperatingSystem.Linux:
					var ab = SDL.Wrappers.Linux.SDLImage.IMG_Load(file);
					if (ab == IntPtr.Zero)
					{
						throw new FileLoadException("Could not load image", file);
					}

					var atexture = Globals.SDL.CreateTextureFromSurface(ab);
					if (atexture == IntPtr.Zero)
					{
						LinuxSdlWrapper.SDL_FreeSurface(ab);
						throw new FileLoadException("Could not load image", file);
					}

					result = new Image(ab, atexture);
					break;
			}

			if (result == null) throw new NotImplementedException();

			return result;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

	    private bool _disposed = false;
	    private void Dispose(bool disposing)
	    {
		    if (!_disposed)
		    {
				//Dispose managed.
			    if (disposing)
			    {
				    
			    }
				
				//Dispose unmanaged
				switch (Globals.OS)
				{
					case OperatingSystem.Windows:
						WindowsSdlWrapper.SDL_DestroyTexture(Texture);
						WindowsSdlWrapper.SDL_FreeSurface(Surface);
						break;
					case OperatingSystem.Linux:
						LinuxSdlWrapper.SDL_DestroyTexture(Texture);
						LinuxSdlWrapper.SDL_FreeSurface(Surface);
						break;
				}

			    Surface = IntPtr.Zero;
			    Texture = IntPtr.Zero;

				_disposed = true;
		    }
	    }

	    ~Image()
	    {
		    Dispose(false);
	    }
	}
}
