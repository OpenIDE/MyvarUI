# MyvarUI
MyvarUI is a frame work to create .net core GUI's, its very incompleate, feel free to help add more controls, etc.

# Example
Code:
```csharp
      public static void Main(string[] args)
      {
           
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
            
            var lbl = new Lable();
            lbl.Y = 75;
            f.Controls.Add(lbl);

            var txtb = new TextBox();
            txtb.Y = 100;
            f.Controls.Add(txtb);

            while (true)
            {
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
```

![Screen Shot](/First Screen shot.png)
