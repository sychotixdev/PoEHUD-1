using PoeHUD.Hud.Settings;
using SharpDX;

namespace PoeHUD.Hud.Menu
{
    public sealed class MenuSettings : SettingsBase
    {
        public MenuSettings()
        {
            Enable = true;
            X = 10; Y = 85;
        }
        public float X { get; set; }
        public float Y { get; set; }
    }
}