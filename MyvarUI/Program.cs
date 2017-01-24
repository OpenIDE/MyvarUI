using System;
using MyvarUI.Events;
using MyvarUI.SDL;
using MyvarUI.Window;
using MyvarUI.Window.Controls;

namespace MyvarUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NOTE: This is a library and is not supposed to be executed.");

            //for debugging

            var f = new Form();
            f.Show();

            var b = new Button();
            b.MouseClick += HandleClick;
            f.Controls.Add(b);

            var b1 = new Button();
            b1.X = 50;
            b1.Y = 50;
            b1.Text = "btn 2";
            b1.MouseClick += HandleClick;
            b1.MouseDown += MouseDown;
            b1.MouseUp += MouseUp;
            b1.MouseHover += MouseHover;
            f.Controls.Add(b1);
            
            var lbl = new Label();
            lbl.Y = 75;
            f.Controls.Add(lbl);

            var txtb = new TextBox();
            txtb.Y = 100;
            f.Controls.Add(txtb);

            while (true)
            {
                f.Update();
                f.Draw();
            }
        }

        public static void HandleClick(object sender, MouseEventArgs args)
        {
            var btn = sender as Button;
        }

        public static void MouseDown(object sender, MouseEventArgs args)
        {
            var btn = sender as Button;
            btn.Text = "MouseDown";
        }

        public static void MouseUp(object sender, MouseEventArgs args)
        {
            var btn = sender as Button;
            btn.Text = "MouseUp";
        }

        public static void MouseHover(object sender, MouseEventArgs args)
        {
        }
    }
}
