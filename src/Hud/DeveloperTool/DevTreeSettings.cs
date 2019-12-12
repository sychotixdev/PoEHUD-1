using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;
using System.Windows.Forms;
using PoeHUD.Controllers;
using ImGuiVector2 = System.Numerics.Vector2;

namespace PoeHUD.Hud.DeveloperTool
{
    public class DevTreeSettings : SettingsBase
    {
        public DevTreeSettings()
        {
            DebugNearestEnts = Keys.NumPad6;
            DebugHoverItem = Keys.NumPad5;
            NearestEntsRange = new RangeNode<int>(300, 1, 2000);
            var centerPos = GameController.Instance.Window.GetWindowRectangle().Center;
            LastSettingSize = new ImGuiVector2(620, 376);
            LastSettingPos = new ImGuiVector2(centerPos.X - LastSettingSize.X / 2, centerPos.Y - LastSettingSize.Y / 2);
            LimitEntriesDrawn = true;
            EntriesDrawLimit = new RangeNode<int>(500, 1, 5000);
        }

        [Menu("Toggle Show Window")]
        public HotkeyNode ToggleDraw { get; set; } = Keys.NumPad9;

        [Menu("Debug Nearest Ents")]
        public HotkeyNode DebugNearestEnts { get; set; }

        [Menu("Debug Hover Item")]
        public HotkeyNode DebugHoverItem { get; set; }

        [Menu("Nearest Ents Range")]
        public RangeNode<int> NearestEntsRange { get; set; }


        public ImGuiVector2 LastSettingPos { get; set; }
        public ImGuiVector2 LastSettingSize { get; set; }

        [Menu("Limit Entries Drawn", 0)]
        public ToggleNode LimitEntriesDrawn { get; set; }

        [Menu("Entries Draw Limit", 1, 0)]
        public RangeNode<int> EntriesDrawLimit { get; set; }

        [Menu("Debug UI element tooltip")]
        public HotkeyNode DebugTooltip { get; set; } = new HotkeyNode(Keys.D);

        public bool Opened = false;
    }
}
