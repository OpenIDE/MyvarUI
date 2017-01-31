using System;
using System.Runtime.InteropServices;

namespace MyvarUI.SDL.Wrappers
{
    public unsafe class LinuxSdlWrapper
    {
        public const string Libsdl = "./Libs/Linux/libSDL2-2.0.so.0.4.0";
        public const string LibsdlTtf = "./Libs/Linux/libSDL2_ttf-2.0.so.0.14.0";

        [DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr SDL_malloc(IntPtr size);

        [DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr SDL_realloc(IntPtr mem, IntPtr size);

        [DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void SDL_free(IntPtr memblock);

        [DllImport(Libsdl)]
        public static extern byte* SDL_GetKeyboardState(out int numkeys);

        [DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
        public static extern SdlKeycode SDL_GetKeyFromScancode(SdlScancode scancode);

        [DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
        public static extern SdlScancode SDL_GetScancodeFromKey(SdlKeycode keycode);

        [DllImport(Libsdl)]
        public static extern uint SDL_GetMouseState(ref int x, ref int y);


        [DllImport(LibsdlTtf)]
        public static extern IntPtr TTF_RenderGlyph_Solid(IntPtr font, ushort ch, ColorStruct fg);

        [DllImport(Libsdl)]
        public static extern int SDL_BlitSurface(IntPtr src, IntPtr srcrect, IntPtr dst, IntPtr dstrect);

		[DllImport(Libsdl, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SDL_FreeSurface(IntPtr surface);

		[DllImport(Libsdl)]
        public static extern IntPtr SDL_RWFromFile([MarshalAs(UnmanagedType.LPStr)] string file,
            [MarshalAs(UnmanagedType.LPStr)] string mode);

        [DllImport(Libsdl)]
        public static extern int SDL_SaveBMP_RW(IntPtr surface, IntPtr io, int freedst);


        [DllImport(Libsdl)]
        public static extern int SDL_SaveBMP(IntPtr surface, string file);

        [DllImport(Libsdl)]
        public static extern int SDL_SetRenderTarget(IntPtr renderer, IntPtr texture);


        [DllImport(Libsdl)]
        public static extern int SDL_RenderCopy(IntPtr renderer, IntPtr texture, SdlRect* srcrect, SdlRect* dstrect);

        [DllImport(Libsdl)]
        public static extern string SDL_GetBasePath();

        [DllImport(LibsdlTtf)]
        public static extern int TTF_Init();

        [DllImport(LibsdlTtf)]
        public static extern IntPtr TTF_RenderText_Shaded(IntPtr font, [MarshalAs(UnmanagedType.LPStr)] string text,
            ColorStruct fg, ColorStruct bg);

        [DllImport(Libsdl)]
        public static extern IntPtr SDL_CreateTextureFromSurface(IntPtr renderer, IntPtr surface);

        [DllImport(Libsdl)]
        public static extern short* SDL_GetError();

        [DllImport(LibsdlTtf)]
        public static extern IntPtr TTF_RenderText_Solid(IntPtr font, [MarshalAs(UnmanagedType.LPStr)] string text,
            ColorStruct fg);

        [DllImport(LibsdlTtf)]
        public static extern IntPtr TTF_RenderText_Blended(IntPtr font, [MarshalAs(UnmanagedType.LPStr)] string text,
            ColorStruct fg);

        [DllImport(LibsdlTtf)]
        public static extern IntPtr TTF_OpenFont(string filename, int ptsize);

        [DllImport(Libsdl)]
        public static extern int SDL_Init(UInt32 flags);

        [DllImport(LibsdlTtf)]
        public static extern string TTF_FontFaceFamilyName(IntPtr font);

        [DllImport(Libsdl)]
        public static extern int SDL_CreateWindowAndRenderer(int width, int height, uint windowFlags, out IntPtr window,
           out IntPtr renderer);

        [DllImport(Libsdl)]
        public static extern int SDL_RenderDrawPoint(IntPtr renderer, int x, int y);

        [DllImport(Libsdl)]
        public static extern void SDL_RenderPresent(IntPtr renderer);

        [DllImport(Libsdl)]
        public static extern void SDL_SetWindowTitle(IntPtr window, string title);

        [DllImport(Libsdl)]
        public static extern int SDL_SetRenderDrawColor(IntPtr renderer, byte r, byte g, byte b, byte a);

        [DllImport(Libsdl)]
        public static extern int SDL_RenderClear(IntPtr renderer);


        [DllImport(Libsdl)]
        public static extern int SDL_PollEvent(out SDL_Event aEvent);

        [DllImport(Libsdl)]
        public static extern void SDL_DestroyRenderer(IntPtr renderer);
		[DllImport(Libsdl)]
		public static extern void SDL_DestroyTexture(IntPtr texture);
		[DllImport(Libsdl)]
        public static extern void SDL_DestroyWindow(IntPtr renderer);

        [DllImport(Libsdl)]
        public static extern void SDL_Quit();

        [DllImport(Libsdl)]
        public static extern IntPtr SDL_CreateRenderer(IntPtr window, int index, uint flags);

        [DllImport(Libsdl)]
        public static extern IntPtr SDL_CreateWindow(string title, int x, int y, int w, int h, uint flags);
    }
}