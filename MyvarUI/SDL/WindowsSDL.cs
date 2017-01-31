using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MyvarUI.Events;
using MyvarUI.SDL.Wrappers;

namespace MyvarUI.SDL
{
    public unsafe class WindowsSDL : ISDL
    {
        public EventHandler<SDL_Event> HookEventHandler { get; set; }

        private IntPtr _window;
        private IntPtr _renderer;

        public void Clear(Color c)
        {
            WindowsSdlWrapper.SDL_SetRenderDrawColor(_renderer, c.R, c.G, c.B, c.A);
            WindowsSdlWrapper.SDL_RenderClear(_renderer);
        }

        public void CreateWindow(string name, int x, int y, int width, int height)
        {
            WindowsSdlWrapper.SDL_CreateWindowAndRenderer(width, height, 0, out _window, out _renderer);
            WindowsSdlWrapper.SDL_SetWindowTitle(_window, name);
            DumpErrors();
        }

        public void Init()
        {
            var init = WindowsSdlWrapper.TTF_Init();
            if (init < 0)
            {
                throw new Exception("Failed to initialize the SDL_TTF library!");
            }

            if (WindowsSdlWrapper.SDL_Init((UInt32) SdlInit.SdlInitVideo) < 0)
            {
                DumpErrors();
                Console.WriteLine("SDL or TTF Init Failed");
            }
        }

        public void SetPixel(int x, int y, Color c)
        {
            WindowsSdlWrapper.SDL_SetRenderDrawColor(_renderer, c.R, c.G, c.B, c.A);
            WindowsSdlWrapper.SDL_RenderDrawPoint(_renderer, x, y);
        }

        public void SwapBuffer()
        {
            WindowsSdlWrapper.SDL_RenderPresent(_renderer);

            SDL_Event e;
            if (WindowsSdlWrapper.SDL_PollEvent(out e) == 1)
            {
                var type = e.type;

                HookEventHandler?.Invoke(this, e);

                if (type == SdlEventType.SdlQuit)
                {
                    Environment.Exit(0);
                }
            }
        }


        private void DumpErrors()
        {
            int loopc = 1;

            while (loopc > 0)
            {
                var error = WindowsSdlWrapper.SDL_GetError();
                int indch = 0;
                var chr = error[indch++];
                var byts = new List<Byte>();
                while (chr != 0)
                {
                    byts.AddRange(BitConverter.GetBytes(chr));
                    chr = error[indch++];
                }
                loopc = chr;
                Console.WriteLine(Encoding.ASCII.GetString(byts.ToArray()));
                //Console.WriteLine(SDL_GetBasePath());
            }
        }

        public void SetTitle(string title)
        {
            WindowsSdlWrapper.SDL_SetWindowTitle(_window, title);
        }

        public void DrawText(string text, int x, int y, Font font, int sizept, Color c)
        {
            var surface = WindowsSdlWrapper.TTF_RenderText_Blended(font.TtfFont, text, c);
            SdlSurface whRef = (SdlSurface) Marshal.PtrToStructure(surface, typeof(SdlSurface));
            var texture = WindowsSdlWrapper.SDL_CreateTextureFromSurface(_renderer, surface);
            var rect = new SdlRect()
            {
                W = whRef.W,
                H = whRef.H,
                X = x,
                Y = y
            };

            var res = WindowsSdlWrapper.SDL_RenderCopy(_renderer, texture, null, &rect);
        }

        public void InitFont(string file, ref Dictionary<string, Font> index)
        {
            IntPtr afont = WindowsSdlWrapper.TTF_OpenFont(file, 12);
            string nm = WindowsSdlWrapper.TTF_FontFaceFamilyName(afont);
            index.Add(nm, new Font(nm, afont));
        }

        public Size CalulateTextSize(string text, Font font, int sizept)
        {
            var surface = WindowsSdlWrapper.TTF_RenderText_Solid(font.TtfFont, text, Color.White);
            SdlSurface whRef = (SdlSurface) Marshal.PtrToStructure(surface, typeof(SdlSurface));


            return new Size(whRef.W, whRef.H);
        }

        public Point GetMouseLocation()
        {
            int x = 0, y = 0;

            WindowsSdlWrapper.SDL_GetMouseState(ref x, ref y);

            return new Point(x, y);
        }

        public MouseState GetMouseState()
        {
            int x = 0, y = 0;

            var mask = WindowsSdlWrapper.SDL_GetMouseState(ref x, ref y);

            return (MouseState) SDL_BUTTON(mask);
        }

        private int SDL_BUTTON(uint x) => (int) (1 << ((int) x - 1));
        public IntPtr Malloc(IntPtr size)
        {
            return WindowsSdlWrapper.SDL_malloc(size);
        }

        public IntPtr Realloc(IntPtr mem, IntPtr size)
        {
            return WindowsSdlWrapper.SDL_realloc(mem, size);
        }

        public void Free(IntPtr memblock)
        {
            WindowsSdlWrapper.SDL_free(memblock);
        }

        public SdlKeycode GetKeyCode(SdlScancode code)
        {
            return WindowsSdlWrapper.SDL_GetKeyFromScancode(code);
        }

        public SdlScancode GetScancode(SdlKeycode key)
        {
            return WindowsSdlWrapper.SDL_GetScancodeFromKey(key);
        }
    }
}