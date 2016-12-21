using SharpDX;
using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;

namespace InventoryPreview
{
    public sealed class InventoryPreviewSettings : SettingsBase
    {
        public InventoryPreviewSettings()
        {
            Enable = false;
            AutoUpdate = true;
            CellUsedColor = new Color(255, 0, 0, 255);
            CellFreeColor = new Color(255, 255, 255, 255);
            CellSize = new RangeNode<int>(30, 1, 100);
            CellPadding = new RangeNode<int>(1, 0, 10);
            PositionX = new RangeNode<float>(28.0f, 0.0f, 100.0f);
            PositionY = new RangeNode<float>(83.0f, 0.0f, 100.0f);
            BackgroundColor = new ColorBGRA(0, 0, 0, 178);
        }

        [Menu("Auto Update")]
        public ToggleNode AutoUpdate { get; set; }
        [Menu("Used Cell Color")]
        public ColorNode CellUsedColor { get; set; }
        [Menu("Free Cell Color")]
        public ColorNode CellFreeColor { get; set; }
        [Menu("Cell Size")]
        public RangeNode<int> CellSize { get; set; }
        [Menu("Cell Padding")]
        public RangeNode<int> CellPadding { get; set; }
        [Menu("Position X")]
        public RangeNode<float> PositionX { get; set; }
        [Menu("Position Y")]
        public RangeNode<float> PositionY { get; set; }
        [Menu("Text Background Color")]
        public ColorNode BackgroundColor { get; set; }
    }
}
