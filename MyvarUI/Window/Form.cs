using System.Collections.Generic;
using System.Runtime.InteropServices;
using MyvarUI.Drawing;
using MyvarUI.Events;
using MyvarUI.SDL;

namespace MyvarUI.Window
{
    public class Form
    {
        private ISDL displayPort;
        public Graphics Graphics { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public bool Hidden { get; set; } = true;

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                displayPort.SetTitle(value);
            }
        }

        public Color BackgroundColor { get; set; } = Color.FromKnownColor(KnownColor.AppWorkspace);

        public List<Control> Controls { get; set; } = new List<Control>();

        public Form()
        {
            X = 100;
            Y = 100;

            Width = 800;
            Height = 600;

            bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

            if(isLinux)
            {
                 displayPort = new LinuxSdl();
            }
            else if(isWindows)
            {
                 displayPort = new WindowsSdl();
            }

           
            displayPort.Init();
            Graphics = new Graphics(displayPort);
        }

        public void Show()
        {
            Hidden = false;
            displayPort.CreateWindow(Title, X, Y, Width, Height);

            displayPort.HookEvents = (x) =>
            {
                if (x == SDL_EventType.SDL_KEYUP
                || x == SDL_EventType.SDL_TEXTINPUT
                || x == SDL_EventType.SDL_KEYDOWN)
                {
                    var kState = displayPort.KeyPresses();

                    foreach (var i in Controls)
                    {
                        var kbst = new KeybordEventArgs();

                        switch (x)
                        {
                            case SDL_EventType.SDL_KEYUP:
                                kbst.State = KeyboardState.KeyUp;
                                break;
                            case SDL_EventType.SDL_TEXTINPUT:
                                kbst.State = KeyboardState.TextInput;
                                break;
                            case SDL_EventType.SDL_KEYDOWN:
                                kbst.State = KeyboardState.KeyDown;
                                break;
                        }

                        if (kState.Length != 0)
                        {
                            kbst.Input = kState;

                            i.FireKeyboardEvents(kbst);
                        }
                    }
                }
            };
        }

        public void Draw()
        {
            //clear displayPort
            displayPort.Clear(BackgroundColor);

            Control[] controls = Controls.ToArray();
            //draw controls
            foreach (var i in controls)
            {
                if (i.Visible) //If visible, draw
                {
                    i.Draw(Graphics);
                }
            }

            //swap buffer
            displayPort.SwapBuffer();
        }

        public void Update()
        {
            var mLoc = displayPort.GetMouseLocation();
            var mState = displayPort.GetMouseState();

            Control oldFocus = null;
            bool focusChanged = false;
            Control[] controls = Controls.ToArray();
            foreach (var control in controls)
            {
                if (control.Focused)
                {
                    if (focusChanged)
                    {
                        control.Focused = false;
                    }
                    oldFocus = control;
                }

                if (control.Rectangle.Contains(mLoc))
                {
                    if (mState != MouseState.None && !control.Focused)
                    {
                        control.Focused = true;
                        focusChanged = true;

                        if (oldFocus != null)
                        {
                            oldFocus.Focused = false;
                        }
                    }

                    control.FireMouseEvents(new MouseEventArgs() { MouseState = mState, X = mLoc.X, Y = mLoc.Y });
                }
            }
        }
    }
}