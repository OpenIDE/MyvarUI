using System;
using MyvarUI.Drawing;
using MyvarUI.Events;

namespace MyvarUI.Window.Controls
{
    public class TextBox : Control
    {
        public string Text { get; set; } = "";

        public TextBox()
        {
            X = 10;
            Y = 10;

            W = 100;
            H = 25;
        }

        public override void FireKeybordEvents(KeybordEventArgs args)
        {

            if(args.State == KeybordState.TextInput)
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
            g.DrawFillRectangle(X, Y, W, H, Color.White);

            if (!string.IsNullOrEmpty(Text))
            {
                //draw text
                g.DrawText(Text, X, Y, "", 15, Color.Black);
            }

            if (Focused)
            {
                g.DrawRectangle(X, Y, W - 1, H - 1, Color.Blue);
            }
        }
    }
}