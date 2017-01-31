using System;
using System.Collections.Generic;
using MyvarUI.Events;

namespace MyvarUI.SDL
{
    public interface ISDL
    {
        //Action<SdlEventType> HookEvents { get; set; }
        EventHandler<SDL_Event> HookEventHandler { get; set; }

        void Init();
        void CreateWindow(string name, int x, int y, int width, int height);

        void Clear(Color c);

        void SetPixel(int x, int y, Color c);

        void SetTitle(string title);

        void DrawText(string text, int x, int y, Font font, int sizept, Color c);

        Point GetMouseLocation();

        MouseState GetMouseState();

        SdlKeycode GetKeyCode(SdlScancode code);
        SdlScancode GetScancode(SdlKeycode key);

        Size CalulateTextSize(string text, Font font, int sizept);

        void InitFont(string file, ref Dictionary<string, Font> index);


        void SwapBuffer();

        IntPtr Malloc(IntPtr size);
        IntPtr Realloc(IntPtr mem, IntPtr size);
        void Free(IntPtr memblock);
    }
}