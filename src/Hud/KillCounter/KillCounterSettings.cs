using SharpDX;
using PoeHUD.Hud.Settings;

namespace PoeHUD.Hud.KillCounter
{
    public sealed class KillCounterSettings : SettingsBase
    {
        public KillCounterSettings()
        {
            Enable = false;
            ShowDetail = true;
            ShowInTown = true;
            TextColor = new ColorBGRA(220, 190, 130, 255);
            BackgroundColor = new ColorBGRA(0, 0, 0, 255);
            LabelTextSize = new RangeNode<int>(16, 10, 20);
            KillsTextSize = new RangeNode<int>(16, 10, 20);

        }

        public ToggleNode ShowInTown { get; set; }
        public ToggleNode ShowDetail { get; set; }
        public ColorNode TextColor { get; set; }
        public ColorNode BackgroundColor { get; set; }
        public RangeNode<int> LabelTextSize { get; set; }
        public RangeNode<int> KillsTextSize { get; set; }
    }
}