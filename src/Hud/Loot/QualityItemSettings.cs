using PoeHUD.Hud.Settings;

namespace PoeHUD.Hud.Loot
{
    public sealed class QualityItemSettings : SettingsBase
    {
        public QualityItemSettings() {}

        public QualityItemSettings(bool enable, int minQuality)
        {
            Enable = enable;
            MinQuality = new RangeNode<int>(minQuality, 0, 20);
        }

        public RangeNode<int> MinQuality { get; set; }
    }
}