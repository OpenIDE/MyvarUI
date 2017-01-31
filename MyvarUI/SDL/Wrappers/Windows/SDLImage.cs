using System;
using System.Runtime.InteropServices;

namespace MyvarUI.SDL.Wrappers.Windows
{
    public static class SDLImage
    {
		public const string Libsdl = ".\\Libs\\Windows\\SDL2_image.dll";
		/* Similar to the headers, this is the version we're expecting to be
		 * running with. You will likely want to check this somewhere in your
		 * program!
		 */
		public const int SDL_IMAGE_MAJOR_VERSION = 2;
		public const int SDL_IMAGE_MINOR_VERSION = 0;
		public const int SDL_IMAGE_PATCHLEVEL = 0;

		[Flags]
		public enum IMG_InitFlags
		{
			IMG_INIT_JPG = 0x00000001,
			IMG_INIT_PNG = 0x00000002,
			IMG_INIT_TIF = 0x00000004,
			IMG_INIT_WEBP = 0x00000008
		}
		
	//	public static void SDL_IMAGE_VERSION(out SDL.SDL_version X)
	//	{
		//	X.major = SDL_IMAGE_MAJOR_VERSION;
		//	X.minor = SDL_IMAGE_MINOR_VERSION;
		//	X.patch = SDL_IMAGE_PATCHLEVEL;
		//}

		[DllImport(Libsdl, EntryPoint = "IMG_LinkedVersion", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr INTERNAL_IMG_LinkedVersion();
	/*	public static SDL.SDL_version IMG_LinkedVersion()
		{
			SDL.SDL_version result;
			IntPtr result_ptr = INTERNAL_IMG_LinkedVersion();
			result = (SDL.SDL_version)Marshal.PtrToStructure(
				result_ptr,
				typeof(SDL.SDL_version)
			);
			return result;
		}*/

		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
		public static extern int IMG_Init(IMG_InitFlags flags);

		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
		public static extern void IMG_Quit();

		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Load")]
		private static extern IntPtr IMG_Load_native(IntPtr file);

		public static IntPtr IMG_Load(string file)
		{
			using (Utf8String s = new Utf8String(file))
			{
				return IMG_Load_native(s.Handle);
			}
		}
 
		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr IMG_Load_RW(
			IntPtr src,
			int freesrc
		);

		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTyped_RW")]
		private static extern IntPtr IMG_LoadTyped_RW_native(IntPtr file, int freesrc, IntPtr type);

		public static IntPtr IMG_LoadTyped_RW(IntPtr src, int freesrc, string type)
		{
			using (Utf8String s = new Utf8String(type))
			{
				return IMG_LoadTyped_RW_native(src, freesrc, s.Handle);
			}
		}

		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTexture")]
		private static extern IntPtr IMG_LoadTexture_Native(IntPtr renderer, IntPtr file);

		public static IntPtr IMG_LoadTexture(IntPtr renderer, string file)
		{
			using (Utf8String s = new Utf8String(file))
			{
				return IMG_LoadTexture_Native(renderer, s.Handle);
			}
		}

		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr IMG_LoadTexture_RW(
			IntPtr renderer,
			IntPtr src,
			int freesrc
		);


		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTextureTyped_RW")]
		private static extern IntPtr IMG_LoadTextureTyped_Native(IntPtr renderer, IntPtr src, int freesrc, IntPtr file);

		public static IntPtr IMG_LoadTextureTyped_RW(IntPtr renderer, IntPtr src, int freesrc, string type)
		{
			using (Utf8String s = new Utf8String(type))
			{
				return IMG_LoadTextureTyped_Native(renderer, src, freesrc, s.Handle);
			}
		}

		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
		public static extern int IMG_InvertAlpha(int on);

		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr IMG_ReadXPMFromArray(
			[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)]
				string[] xpm
		);

		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SavePNG")]
		private static extern IntPtr IMG_SavePNG_Native(IntPtr surface, IntPtr file);

		public static IntPtr IMG_SavePNG(IntPtr surface, string file)
		{
			using (Utf8String s = new Utf8String(file))
			{
				return IMG_SavePNG_Native(surface, s.Handle);
			}
		}

		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
		public static extern int IMG_SavePNG_RW(
			IntPtr surface,
			IntPtr dst,
			int freedst
		);
	}
}
