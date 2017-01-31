using System.Collections.Generic;
using System.Runtime.InteropServices;
using MyvarUI.Drawing;
using MyvarUI.Events;
using MyvarUI.SDL;

namespace MyvarUI.Window
{
    public class Form
    {
        private ISDL _displayPort;
        public Graphics Graphics { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Color BackgroundColor { get; set; } = Color.FromKnownColor(KnownColor.Control);

        public bool Hidden { get; set; } = true;

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                _displayPort.SetTitle(value);
            }
        }

        public ControlContainer Controls { get; private set; }

        public Form()
        {
            X = 100;
            Y = 100;

            Width = 800;
            Height = 600;

            _displayPort = Globals.SDL;

            Font.Init(_displayPort);
            Graphics = new Graphics(_displayPort, 0, 0);
            Controls = new FormControlsContainer(this, _displayPort)
            {
                X = 0,
                Y = 0,
                Width = Width,
                Height = Height
            };
        }

        public void Show()
        {
            Hidden = false;
            _displayPort.CreateWindow(Title, X, Y, Width, Height);

            _displayPort.HookEventHandler += (s, e) =>
            {
                var x = e.type;
                if (x == SdlEventType.SdlKeyup
                    || x == SdlEventType.SdlTextinput
                    || x == SdlEventType.SdlKeydown)
                {
                    var a = e.key;

                    var eve = new KeyboardEventArgs
                    {
                        Scancode = a.keysym.scancode,
                        Keycode = a.keysym.sym, 
                        Keymod = a.keysym.mod,
                        Unicode = a.keysym.unicode
                    };

                    switch (x)
                    {
                        case SdlEventType.SdlKeyup:
                            eve.State = KeyboardState.KeyUp;
                            break;
                        case SdlEventType.SdlTextinput:
                            eve.State = KeyboardState.TextInput;
                            break;
                        case SdlEventType.SdlKeydown:
                            eve.State = KeyboardState.KeyDown;
                            break;
                    }

                    foreach (var i in Controls)
                    {
                        i.FireKeyboardEvents(eve);
                    }
                }
            };
        }

        public void Draw()
        {
            //clear displayPort
            _displayPort.Clear(BackgroundColor);

            Controls.Draw(Graphics);

            //swap buffer
            _displayPort.SwapBuffer();
        }
    }
}