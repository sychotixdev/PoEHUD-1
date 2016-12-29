using System;
using PoeHUD.Plugins;
using PoeHUD.Hud.Settings;

namespace MapsExchange
{
    public class MapsExchangeSettings : SettingsBase
    {
        public MapsExchangeSettings()
        {
            Enable = false;
            AlwaysHighlight = true;
            BordersWidth = new RangeNode<float>(3, 1, 10);
            Spacing = new RangeNode<float>(1, 0, 10);
        }

        [Menu("Always Highlight")]
        public ToggleNode AlwaysHighlight { get; set; }
        [Menu("Borders Width")]
        public RangeNode<float> BordersWidth { get; set; }
        [Menu("Spacing")]
        public RangeNode<float> Spacing { get; set; }
    }
}
