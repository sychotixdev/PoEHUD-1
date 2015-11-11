using PoeHUD.Hud.Settings;
using SharpDX;

namespace PoeHUD.Hud.AdvancedTooltip
{
    public sealed class WeaponDpsSettings : SettingsBase
    {
        public WeaponDpsSettings()
        {
            Enable = true;
            TextColor = new ColorBGRA(254, 192, 118, 255);
            DpsTextSize = new RangeNode<int>(16, 10, 50);
            DpsNameTextSize = new RangeNode<int>(13, 10, 50);
        }

        public ColorNode TextColor { get; set; }
        public RangeNode<int> DpsTextSize { get; set; }
        public RangeNode<int> DpsNameTextSize { get; set; }
    }
}