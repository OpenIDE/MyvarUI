using System.Collections.Generic;

namespace MyvarUI
{
    public class Font
    {

        public static Dictionary<string, string> FontIndex { get; set; } = new Dictionary<string, string>();

        public static void Init()
        {
            FontIndex.Clear();
        }

        public string Name { get; set;}
        public Font(string name)
        {
            Name = name;
        }
    }
}