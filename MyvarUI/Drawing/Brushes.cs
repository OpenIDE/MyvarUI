using System;

namespace MyvarUI.Drawing
{
    public abstract class Brushes
    {
        static SolidBrush active_border;
        static SolidBrush active_caption;
        static SolidBrush active_caption_text;
        static SolidBrush app_workspace;
        static SolidBrush control;
        static SolidBrush control_dark;
        static SolidBrush control_dark_dark;
        static SolidBrush control_light;
        static SolidBrush control_light_light;
        static SolidBrush control_text;
        static SolidBrush desktop;
        static SolidBrush highlight;
        static SolidBrush highlight_text;
        static SolidBrush hot_track;
        static SolidBrush inactive_border;
        static SolidBrush inactive_caption;
        static SolidBrush info;
        static SolidBrush menu;
        static SolidBrush scroll_bar;
        static SolidBrush window;
        static SolidBrush window_text;
        static SolidBrush button_face;
        static SolidBrush button_highlight;
        static SolidBrush button_shadow;
        static SolidBrush gradient_activecaption;
        static SolidBrush gradient_inactivecaption;
        static SolidBrush graytext;
        static SolidBrush inactive_captiontext;
        static SolidBrush infotext;
        static SolidBrush menubar;
        static SolidBrush menu_highlight;
        static SolidBrush menu_text;
        static SolidBrush window_fame;

        private Brushes() { }

        public static Brush ActiveBorder
        {
            get
            {
                if (active_border == null)
                {
                    active_border = new SolidBrush(KnownColor.ActiveBorder);
                    active_border.IsModifiable = false;
                }

                return active_border;
            }
        }

        public static Brush ActiveCaption
        {
            get
            {
                if (active_caption == null)
                {
                    active_caption = new SolidBrush(KnownColor.ActiveCaption);
                    active_caption.IsModifiable = false;
                }

                return active_caption;
            }
        }

        public static Brush ActiveCaptionText
        {
            get
            {
                if (active_caption_text == null)
                {
                    active_caption_text = new SolidBrush(KnownColor.ActiveCaptionText);
                    active_caption_text.IsModifiable = false;
                }

                return active_caption_text;
            }
        }

        public static Brush AppWorkspace
        {
            get
            {
                if (app_workspace == null)
                {
                    app_workspace = new SolidBrush(KnownColor.AppWorkspace);
                    app_workspace.IsModifiable = false;
                }

                return app_workspace;
            }
        }

        public static Brush Control
        {
            get
            {
                if (control == null)
                {
                    control = new SolidBrush(KnownColor.Control);
                    control.IsModifiable = false;
                }

                return control;
            }
        }

        public static Brush ControlLight
        {
            get
            {
                if (control_light == null)
                {
                    control_light = new SolidBrush(KnownColor.ControlLight);
                    control_light.IsModifiable = false;
                }

                return control_light;
            }
        }

        public static Brush ControlLightLight
        {
            get
            {
                if (control_light_light == null)
                {
                    control_light_light = new SolidBrush(KnownColor.ControlLightLight);
                    control_light_light.IsModifiable = false;
                }

                return control_light_light;
            }
        }

        public static Brush ControlDark
        {
            get
            {
                if (control_dark == null)
                {
                    control_dark = new SolidBrush(KnownColor.ControlDark);
                    control_dark.IsModifiable = false;
                }

                return control_dark;
            }
        }

        public static Brush ControlDarkDark
        {
            get
            {
                if (control_dark_dark == null)
                {
                    control_dark_dark = new SolidBrush(KnownColor.ControlDarkDark);
                    control_dark_dark.IsModifiable = false;
                }

                return control_dark_dark;
            }
        }

        public static Brush ControlText
        {
            get
            {
                if (control_text == null)
                {
                    control_text = new SolidBrush(KnownColor.ControlText);
                    control_text.IsModifiable = false;
                }

                return control_text;
            }
        }

        public static Brush Highlight
        {
            get
            {
                if (highlight == null)
                {
                    highlight = new SolidBrush(KnownColor.Highlight);
                    highlight.IsModifiable = false;
                }

                return highlight;
            }
        }

        public static Brush HighlightText
        {
            get
            {
                if (highlight_text == null)
                {
                    highlight_text = new SolidBrush(KnownColor.HighlightText);
                    highlight_text.IsModifiable = false;
                }

                return highlight_text;
            }
        }

        public static Brush Window
        {
            get
            {
                if (window == null)
                {
                    window = new SolidBrush(KnownColor.Window);
                    window.IsModifiable = false;
                }

                return window;
            }
        }
        public static Brush WindowText
        {
            get
            {
                if (window_text == null)
                {
                    window_text = new SolidBrush(KnownColor.WindowText);
                    window_text.IsModifiable = false;
                }

                return window_text;
            }
        }

        public static Brush InactiveBorder
        {
            get
            {
                if (inactive_border == null)
                {
                    inactive_border = new SolidBrush(KnownColor.InactiveBorder);
                    inactive_border.IsModifiable = false;
                }

                return inactive_border;
            }
        }

        public static Brush Desktop
        {
            get
            {
                if (desktop == null)
                {
                    desktop = new SolidBrush(KnownColor.Desktop);
                    desktop.IsModifiable = false;
                }

                return desktop;
            }
        }

        public static Brush HotTrack
        {
            get
            {
                if (hot_track == null)
                {
                    hot_track = new SolidBrush(KnownColor.HotTrack);
                    hot_track.IsModifiable = false;
                }

                return hot_track;
            }
        }

        public static Brush InactiveCaption
        {
            get
            {
                if (inactive_caption == null)
                {
                    inactive_caption = new SolidBrush(KnownColor.InactiveCaption);
                    inactive_caption.IsModifiable = false;
                }

                return inactive_caption;
            }
        }

        public static Brush Info
        {
            get
            {
                if (info == null)
                {
                    info = new SolidBrush(KnownColor.Info);
                    info.IsModifiable = false;
                }

                return info;
            }
        }

        public static Brush Menu
        {
            get
            {
                if (menu == null)
                {
                    menu = new SolidBrush(KnownColor.Menu);
                    menu.IsModifiable = false;
                }

                return menu;
            }
        }

        public static Brush ScrollBar
        {
            get
            {
                if (scroll_bar == null)
                {
                    scroll_bar = new SolidBrush(KnownColor.ScrollBar);
                    scroll_bar.IsModifiable = false;
                }

                return scroll_bar;
            }
        }

        public static Brush FromSystemColor(Color c)
        {
            if (c.IsSystemColor)
            {
                SolidBrush newBrush = new SolidBrush(c);
                newBrush.IsModifiable = false;
                return newBrush;
            }

            String message = String.Format("The color {0} is not a system color.", c);
            throw new ArgumentException(message);
        }

        public static Brush ButtonFace
        {
            get
            {
                if (button_face == null)
                {
                    button_face = new SolidBrush(KnownColor.ButtonFace);
                    button_face.IsModifiable = false;
                }

                return button_face;
            }
        }

        public static Brush ButtonHighlight
        {
            get
            {
                if (button_highlight == null)
                {
                    button_highlight = new SolidBrush(KnownColor.ButtonHighlight);
                    button_highlight.IsModifiable = false;
                }

                return button_highlight;
            }
        }

        public static Brush ButtonShadow
        {
            get
            {
                if (button_shadow == null)
                {
                    button_shadow = new SolidBrush(KnownColor.ButtonShadow);
                    button_shadow.IsModifiable = false;
                }

                return button_shadow;
            }
        }

        public static Brush GradientActiveCaption
        {
            get
            {
                if (gradient_activecaption == null)
                {
                    gradient_activecaption = new SolidBrush(KnownColor.GradientActiveCaption);
                    gradient_activecaption.IsModifiable = false;
                }

                return gradient_activecaption;
            }
        }

        public static Brush GradientInactiveCaption
        {
            get
            {
                if (gradient_inactivecaption == null)
                {
                    gradient_inactivecaption = new SolidBrush(KnownColor.GradientInactiveCaption);
                    gradient_inactivecaption.IsModifiable = false;
                }

                return gradient_inactivecaption;
            }
        }

        public static Brush GrayText
        {
            get
            {
                if (graytext == null)
                {
                    graytext = new SolidBrush(KnownColor.GrayText);
                    graytext.IsModifiable = false;
                }

                return graytext;
            }
        }

        public static Brush InactiveCaptionText
        {
            get
            {
                if (inactive_captiontext == null)
                {
                    inactive_captiontext = new SolidBrush(KnownColor.InactiveCaptionText);
                    inactive_captiontext.IsModifiable = false;
                }

                return inactive_captiontext;
            }
        }

        public static Brush InfoText
        {
            get
            {
                if (infotext == null)
                {
                    infotext = new SolidBrush(KnownColor.InfoText);
                    infotext.IsModifiable = false;
                }

                return infotext;
            }
        }

        public static Brush MenuBar
        {
            get
            {
                if (menubar == null)
                {
                    menubar = new SolidBrush(KnownColor.MenuBar);
                    menubar.IsModifiable = false;
                }

                return menubar;
            }
        }

        public static Brush MenuHighlight
        {
            get
            {
                if (menu_highlight == null)
                {
                    menu_highlight = new SolidBrush(KnownColor.MenuHighlight);
                    menu_highlight.IsModifiable = false;
                }

                return menu_highlight;
            }
        }

        public static Brush MenuText
        {
            get
            {
                if (menu_text == null)
                {
                    menu_text = new SolidBrush(KnownColor.MenuText);
                    menu_text.IsModifiable = false;
                }

                return menu_text;
            }
        }

        public static Brush WindowFrame
        {
            get
            {
                if (window_fame == null)
                {
                    window_fame = new SolidBrush(KnownColor.WindowFrame);
                    window_fame.IsModifiable = false;
                }

                return window_fame;
            }
        }
    }
}
