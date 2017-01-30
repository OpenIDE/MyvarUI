using MyvarUI.Drawing;
using MyvarUI.Events;

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

        public override void FireKeybordEvents(KeybordEventArgs args)
        {
            if (args.State == KeybordState.TextInput)
            {
                /*  foreach(var c in args.Input)
                  {
                      Text += c;
                  }*/
                Text += args.Input[0];
            }

            base.FireKeybordEvents(args);
        }

        public override void Draw(Graphics g)
        {
            //draw white box where button should be
            g.DrawFillRectangle(0, 0, Width, Height, Color.White);

            if (!string.IsNullOrEmpty(Text))
            {
                //draw text
                g.DrawText(Text, 0, 0, Font, 15, Color.Black);
            }

            if (Focused)
            {
                g.DrawRectangle(0, 0, Width - 1, Height - 1, Color.Blue);
            }
        }
    }
}