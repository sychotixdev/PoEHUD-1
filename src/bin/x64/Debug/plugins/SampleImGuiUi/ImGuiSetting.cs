using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;

namespace SampleImGuiUi
{
    public class ImGuiSetting : SettingsBase
    {
        public ImGuiSetting()
        {
            Enable = false;
            x = new RangeNode<int>(0, 0, 8000);
            y = new RangeNode<int>(0, 0, 8000);
        }

        [Menu("X Axis")]
        public RangeNode<int> x { get; set; }

        [Menu("Y Axis")]
        public RangeNode<int> y { get; set; }
    }
}
