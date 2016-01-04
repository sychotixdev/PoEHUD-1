using PoeHUD.Hud.Settings;
using SharpDX;

namespace PoeHUD.Hud.Trackers
{
    public sealed class MonsterTrackerSettings : SettingsBase
    {
        public MonsterTrackerSettings()
        {
            Enable = true;
            Monsters = true;
            Minions = true;
            PlaySound = true;
            ShowText = true;
            SoundVolume = new RangeNode<int>(50, 0, 100);
            TextSize = new RangeNode<int>(24, 10, 50);
            BackgroundColor = new ColorBGRA(192, 192, 192, 230);
            TextPositionX = new RangeNode<int>(50, 0, 100);
            TextPositionY = new RangeNode<int>(85, 0, 100);
            DefaultTextColor = Color.Red;
            MinionsIcon = new RangeNode<int>(4, 1, 8);
            WhiteMobIcon = new RangeNode<int>(4, 1, 8);
            MagicMobIcon = new RangeNode<int>(6, 1, 12);
            RareMobIcon = new RangeNode<int>(8, 1, 16);
            UniqueMobIcon = new RangeNode<int>(10, 1, 20);
        }

        public ToggleNode Monsters { get; set; }
        public ToggleNode Minions { get; set; }
        public ToggleNode PlaySound { get; set; }
        public RangeNode<int> SoundVolume { get; set; }
        public ToggleNode ShowText { get; set; }
        public RangeNode<int> TextSize { get; set; }
        public ColorNode DefaultTextColor { get; set; }
        public ColorNode BackgroundColor { get; set; }
        public RangeNode<int> TextPositionX { get; set; }
        public RangeNode<int> TextPositionY { get; set; }
        public RangeNode<int> MinionsIcon { get; set; }
        public RangeNode<int> WhiteMobIcon { get; set; }
        public RangeNode<int> MagicMobIcon { get; set; }
        public RangeNode<int> RareMobIcon { get; set; }
        public RangeNode<int> UniqueMobIcon { get; set; }
    }
}