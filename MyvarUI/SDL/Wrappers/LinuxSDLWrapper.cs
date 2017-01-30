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
        public static extern byte* SDL_GetKeyboardState(ref int numkeys);


        [DllImport(Libsdl)]
        public static extern uint SDL_GetMouseState(ref int x, ref int y);


        [DllImport(LibsdlTtf)]
        public static extern void* TTF_RenderGlyph_Solid(void* font, ushort ch, ColorStruct fg);

        [DllImport(Libsdl)]
        public static extern int SDL_BlitSurface(void* src, void* srcrect, void* dst, void* dstrect);


        [DllImport(Libsdl)]
        public static extern void* SDL_RWFromFile([MarshalAs(UnmanagedType.LPStr)] string file,
            [MarshalAs(UnmanagedType.LPStr)] string mode);

        [DllImport(Libsdl)]
        public static extern int SDL_SaveBMP_RW(void* surface, void* io, int freedst);


        [DllImport(Libsdl)]
        public static extern int SDL_SaveBMP(void* surface, string file);

        [DllImport(Libsdl)]
        public static extern int SDL_SetRenderTarget(void* renderer, void* texture);


        [DllImport(Libsdl)]
        public static extern int SDL_RenderCopy(void* renderer, void* texture, SdlRect* srcrect, SdlRect* dstrect);

        [DllImport(Libsdl)]
        public static extern string SDL_GetBasePath();

        [DllImport(LibsdlTtf)]
        public static extern int TTF_Init();

        [DllImport(LibsdlTtf)]
        public static extern void* TTF_RenderText_Shaded(void* font, [MarshalAs(UnmanagedType.LPStr)] string text,
            ColorStruct fg, ColorStruct bg);

        [DllImport(Libsdl)]
        public static extern void* SDL_CreateTextureFromSurface(void* renderer, IntPtr surface);

        [DllImport(Libsdl)]
        public static extern short* SDL_GetError();

        [DllImport(LibsdlTtf)]
        public static extern void* TTF_RenderText_Solid(IntPtr font, [MarshalAs(UnmanagedType.LPStr)] string text,
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
        public static extern int SDL_CreateWindowAndRenderer(int width, int height, uint windowFlags, void** window,
            void** renderer);

        [DllImport(Libsdl)]
        public static extern int SDL_RenderDrawPoint(void* renderer, int x, int y);

        [DllImport(Libsdl)]
        public static extern void SDL_RenderPresent(void* renderer);

        [DllImport(Libsdl)]
        public static extern void SDL_SetWindowTitle(void* window, string title);

        [DllImport(Libsdl)]
        public static extern int SDL_SetRenderDrawColor(void* renderer, byte r, byte g, byte b, byte a);

        [DllImport(Libsdl)]
        public static extern int SDL_RenderClear(void* renderer);


        [DllImport(Libsdl)]
        public static extern int SDL_PollEvent(byte* aEvent);

        [DllImport(Libsdl)]
        public static extern void SDL_DestroyRenderer(void* renderer);

        [DllImport(Libsdl)]
        public static extern void SDL_DestroyWindow(void* renderer);

        [DllImport(Libsdl)]
        public static extern void SDL_Quit();

        [DllImport(Libsdl)]
        public static extern void* SDL_CreateRenderer(void* window, int index, uint flags);

        [DllImport(Libsdl)]
        public static extern void* SDL_CreateWindow(string title, int x, int y, int w, int h, uint flags);
    }
}