using SharpDX;
using PoeHUD.Hud.Settings;

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
    }
}