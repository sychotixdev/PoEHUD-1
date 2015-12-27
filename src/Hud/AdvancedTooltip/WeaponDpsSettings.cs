using SharpDX;
using PoeHUD.Hud.Settings;

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
			BackgroundColor = new ColorBGRA(255, 255, 0, 255);
        }

        public ColorNode TextColor { get; set; }
        public RangeNode<int> DpsTextSize { get; set; }
        public RangeNode<int> DpsNameTextSize { get; set; }
		public ColorNode BackgroundColor { get; set; }
    }
}