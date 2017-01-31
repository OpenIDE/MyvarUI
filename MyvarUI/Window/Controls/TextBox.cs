using System;
using MyvarUI.Drawing;
using MyvarUI.Events;
using MyvarUI.SDL;

namespace MyvarUI.Window.Controls
{
    public class TextBox : Control
    {
        public string Text { get; set; } = "";

        public Font Font { get; set; } = Font.FontFromName("Source Code Pro");

        public TextBox()
        {
            X = 10;
            Y = 10;

            Width = 100;
            Height = 25;
        }

        public override void FireKeyboardEvents(KeyboardEventArgs args)
        {
            if (!Focused) return;

            if (args.State != KeyboardState.KeyDown) return;

            if (args.Scancode == SdlScancode.Backspace)
            {
                if (Text.Length >= 1)
                {
                    Text = Text.Remove(Text.Length - 1);
                }
                return;
            }

            //var c = Keyboard.CharFromScanCode(args.Scancode);
            var c = args.GetChar();
            if (c != '\0') Text += c;
        }

        public override void Draw(Graphics g)
        {
            //draw white box where button should be
            g.DrawFillRectangle(0, 0, Width, Height, Color.White);

            if (!string.IsNullOrEmpty(Text))
            {
                //draw text
                string text = Text;
                Size size = g.CalulateTextSize(text, Font, 15);
                while (size.W > this.Width)
                {
                    text = text.Remove(text.Length - 1);
                    size = g.CalulateTextSize(text, Font, 15);
                }

                g.DrawText(text, 0, 0, Font, 15, Color.Black);
            }

            if (Focused)
            {
                g.DrawRectangle(0, 0, Width - 1, Height - 1, Color.Blue);
            }
        }
    }
}