using System;

namespace MyvarUI.Drawing
{
    public abstract class Brush : IDisposable
    {
        protected Brush()
        {
            
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            
        }

        public virtual Color Color { get; set; } = Color.White;

        ~Brush()
        {
            Dispose(false);
        }
    }
}
