namespace MyvarUI.Window
{
    public interface IContainerControl
    {
        Control ActiveControl { get; set; }
        bool ActivateControl(Control active);
    }
}
