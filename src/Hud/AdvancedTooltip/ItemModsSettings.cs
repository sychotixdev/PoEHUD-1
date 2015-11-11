using SharpDX;

using PoeHUD.Hud.Settings;

namespace PoeHUD.Hud.AdvancedTooltip
{
    public sealed class ItemModsSettings : SettingsBase
    {
        public ItemModsSettings()
        {
            Enable = false;
            ModTextSize = new RangeNode<int>(13, 10, 50);
            BackgroundColor = new ColorBGRA(0, 0, 0, 220);
        }

        public RangeNode<int> ModTextSize { get; set; }

        public ColorNode BackgroundColor { get; set; }
    }
}