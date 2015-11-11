using System.Windows.Forms;

namespace PoeHUD.Framework.InputHooks
{
    public class KeyInfo
    {
        public KeyInfo(Keys keys, bool control, bool alt, bool shift)
        {
            Keys = keys;
            Control = control;
            Alt = alt;
            Shift = shift;
        }

        public Keys Keys { get; private set; }
        public bool Control { get; private set; }
        public bool Alt { get; private set; }
        public bool Shift { get; private set; }
        public bool Handled { get; set; }
    }
}