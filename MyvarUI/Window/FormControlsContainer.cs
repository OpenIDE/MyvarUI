using MyvarUI.Drawing;
using MyvarUI.Events;
using MyvarUI.SDL;

namespace MyvarUI.Window
{
    internal class FormControlsContainer : ControlContainer
    {
        private ISDL _displayPort;
        private Form _form;

        public FormControlsContainer(Form form, ISDL displayPort)
        {
            this._form = form;
            this._displayPort = displayPort;
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);

            var mLoc = _displayPort.GetMouseLocation();
            var mState = _displayPort.GetMouseState();

            Update(mLoc, mState, g.GetOffset());
        }
    }
}