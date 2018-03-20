using PoeHUD.Hud.Settings;
using SharpDX;
using ImGuiVector2 = System.Numerics.Vector2;
using ImGuiNET;
using Newtonsoft.Json;
using PoeHUD.Plugins;
using PoeHUD.Hud.Themes;
using System.Windows.Forms;

namespace PoeHUD.Hud.Menu
{
    public sealed class CoreSettings : SettingsBase
    {
        public CoreSettings()
        {
            Enable = true;
        }

        public ImGuiVector2 MenuWindowPos = new ImGuiVector2(200, 200);
        public ImGuiVector2 MenuWindowSize = new ImGuiVector2(600, 600);

        public bool IsCollapsed = false;
        public TreeNodeFlags CorePluginsTreeState;
        public TreeNodeFlags InstalledPluginsTreeNode;

        [Menu("Main Menu Key Toggle")]
        public HotkeyNode MainMenuKeyToggle { get; set; } = Keys.F12;

        [Menu("Developer Mode")]
        public ToggleNode DeveloperMode { get; set; } = false;

        [Menu("Show plugins Render Time")]
        public ToggleNode ShowPluginsMS { get; set; } = false;

        [JsonIgnore]
        public ToggleNode ShowImguiDemo { get; set; } = false;

        [Menu("Reload plugin DLL on change")]
        public ToggleNode AutoReloadDllOnChanges { get; set; } = true;

        [Menu("Current Menu Theme")]
        public ListNode Theme { get; set; } = new ListNode() { Value = ThemeEditor.DefaultThemeName };
    }
}