using System;
using System.Collections;
using System.Collections.Generic;
using MyvarUI.Drawing;
using MyvarUI.Events;

namespace MyvarUI.Window
{
    public class ControlContainer : Control, IContainerControl, IEnumerable<Control>
    {
        private Control _activeControl;
        private object _activeLock = new object();

        protected List<Control> Controls { get; }

        public ControlContainer()
        {
            Controls = new List<Control>();
        }

        public Control ActiveControl
        {
            get { return _activeControl; }
            set { ActivateControl(value); }
        }

        public bool ActivateControl(Control active)
        {
            if (!this.Controls.Contains(active)) return false;
            lock (_activeLock)
            {
                _activeControl.Focused = false;
                active.Focused = true;
                _activeControl = active;
            }
            return true;
        }

        public bool Contains(Control control)
        {
            return Controls.Contains(control);
        }

        public void Add(Control control)
        {
            control.Parent = this;
            Controls.Add(control);
        }

        public bool Remove(Control control)
        {
	        if (Controls.Remove(control))
	        {
		        if (_activeControl == control)
		        {
			        _activeControl = null;
		        }

		        return true;
	        }
	        return false;
        }

        public virtual void Update(Point mLoc, MouseState mState, Point offset)
        {
            bool mouseWasOverControl = false;
            int count = Controls.Count;

            for (int c = 0; c < count; c++)
            {
                if (c > Controls.Count) break; //Prevent index out of range exceptions if the controls change.
                var i = Controls[c];

                if (i is ControlContainer)
                {
                    var x = i as ControlContainer;
                    x.Update(mLoc, mState, offset);
                }

	            if (!i.Hidden) //We only wanna do the mouse events when the control is not hidden from the user.
	            {
		            //calulate mouse events
		            if (mLoc.X >= i.X && mLoc.X <= i.X + i.Width)
		            {
			            if (mLoc.Y >= i.Y && mLoc.Y <= i.Y + i.Height)
			            {
				            mouseWasOverControl = true;
				            if (mState != MouseState.None)
				            {
					            foreach (var ctrl in Controls)
					            {
						            ctrl.Focused = false;
					            }

					            i.Focused = true;
					            _activeControl = i;
				            }

				            i.FireMouseEvents(new MouseEventArgs() {MouseState = mState, X = mLoc.X, Y = mLoc.Y});
			            }
		            }
	            }
            }

            if (!mouseWasOverControl)
            {
                foreach (var ctrl in Controls)
                {
                    if (mState != MouseState.None)
                    {
                        ctrl.Focused = false;
                    }
                }
            }
        }

        public override void Draw(Graphics g)
        {
            int count = Controls.Count;

            for (int c = 0; c < count; c++)
            {
                if (c > Controls.Count) break; //Prevent index out of range exceptions if the controls change.
                var i = Controls[c];

				if (i.Hidden) continue; //Do not draw hidden controls.

                g.SetOffset(i.X, i.Y);

                i.Draw(g);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Control> GetEnumerator()
        {
            Control[] controls = Controls.ToArray();
            foreach (var i in controls)
            {
                yield return i;
            }
        }
    }
}