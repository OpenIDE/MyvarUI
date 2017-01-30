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

            _displayPort = Globals.Isdl;

            _displayPort.Init();
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

            _displayPort.HookEvents = (x) =>
            {
                if (x == SdlEventType.SdlKeyup
                    || x == SdlEventType.SdlTextinput
                    || x == SdlEventType.SdlKeydown)
                {
                    var kState = _displayPort.KeyPresses();

                    foreach (var i in Controls)
                    {
                        var kbst = new KeybordEventArgs();

                        switch (x)
                        {
                            case SdlEventType.SdlKeyup:
                                kbst.State = KeybordState.KeyUp;
                                break;
                            case SdlEventType.SdlTextinput:
                                kbst.State = KeybordState.TextInput;
                                break;
                            case SdlEventType.SdlKeydown:
                                kbst.State = KeybordState.KeyDown;
                                break;
                        }

                        if (kState.Length != 0)
                        {
                            kbst.Input = kState;

                            i.FireKeybordEvents(kbst);
                        }
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