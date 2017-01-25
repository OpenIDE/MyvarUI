using System.Collections.Generic;
using System.IO;
using MyvarUI.SDL;

namespace MyvarUI
{
    public unsafe class Font
    {

        public static Dictionary<string, Font> FontIndex = new Dictionary<string, Font>();

        public static void Init(ISDL displayPort)
        {
            FontIndex = new Dictionary<string, Font>();
            FontIndex.Clear();
            foreach(var i in Directory.GetFiles("Fonts"))
            {
                displayPort.InitFont(i, ref FontIndex);
            }
        }

        public static Font FontFromName(string Name)
        {
            return FontIndex[Name];
        }

        internal void* TTF_Font { get; set;}
        public string Name { get; set;}
        public Font(string name, void * fnt)
        {
            Name = name;
            TTF_Font = fnt;
        }
    }
}