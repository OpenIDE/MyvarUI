namespace MyvarUI.Events
{
    public class KeybordEventArgs : Event
    {
        public KeyboardState State { get; set; }
        public char[] Input { get; set; }
    }
}