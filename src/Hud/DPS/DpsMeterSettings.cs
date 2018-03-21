using PoeHUD.Hud.Settings;
using SharpDX;
using PoeHUD.Plugins;
using PoeHUD.Hud.Settings;

namespace PoeHUD.Hud.Dps
{
    public sealed class DpsMeterSettings : SettingsBase
    {
        public DpsMeterSettings()
        {
            Enable = false;
            ShowInTown = false;
            DpsTextSize = new RangeNode<int>(16, 10, 20);
            PeakDpsTextSize = new RangeNode<int>(16, 10, 20);
            DpsFontColor = new ColorBGRA(220, 190, 130, 255);
            PeakFontColor = new ColorBGRA(220, 190, 130, 255);
            BackgroundColor = new ColorBGRA(0, 0, 0, 255);
            ClearNode = new ButtonNode();
        }

        public ToggleNode ShowInTown { get; set; }
        public RangeNode<int> DpsTextSize { get; set; }
        public RangeNode<int> PeakDpsTextSize { get; set; }
        public ColorNode DpsFontColor { get; set; }
        public ColorNode PeakFontColor { get; set; }
        public ColorNode BackgroundColor { get; set; }
        public ButtonNode ClearNode { get; set; }

        [Menu("Show AOE")]
        public ToggleNode ShowAOE { get; set; } = true;
        public ToggleNode ShowCurrentHitDamage { get; set; } = true;
        public ToggleNode HasCullingStrike { get; set; } = false;
    }
}