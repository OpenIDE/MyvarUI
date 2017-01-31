using System;
using MyvarUI.SDL;

namespace MyvarUI.Events
{
    public class SdlEventArgs : EventArgs
    {
        public ISDL Source { get; }
        public SdlEventType EventType { get; }
        internal SdlEventArgs(ISDL source, SdlEventType eventType)
        {
            Source = source;
            EventType = eventType;
        }
    }
}
