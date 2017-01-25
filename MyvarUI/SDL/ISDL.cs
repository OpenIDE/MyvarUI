using System;
using System.Collections.Generic;

namespace MyvarUI.SDL
{
    public interface ISDL
    {
        Action<SDL_EventType> HookEvents { get; set; }

        void Init();
        void CreateWindow(string name, int x, int y, int width, int height);

        void Clear(Color c);

        void SetPixel(int x, int y, Color c);

        void SetTitle(string title);

        void DrawText(string text, int x, int y, Font font, int sizept, Color c);

        Point GetMouseLocation();

        MouseState GetMouseState();

        char[] KeyPresses();

        Size CalulateTextSize(string text, Font font, int sizept);

        void InitFont(string File,ref Dictionary<string, Font> index);
        

        void SwapBuffer();
    }
}