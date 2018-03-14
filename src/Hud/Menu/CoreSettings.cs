using PoeHUD.Hud.Settings;
using SharpDX;
using ImGuiVector2 = System.Numerics.Vector2;
using ImGuiNET;
using Newtonsoft.Json;
using PoeHUD.Plugins;

namespace PoeHUD.Hud.Menu
{
    public sealed class CoreSettings : SettingsBase
    {
        public CoreSettings()
        {
            Enable = true;
        }

        public ImGuiVector2 MenuWindowPos;
        public ImGuiVector2 MenuWindowSize;
        public bool IsOpened = true;
        public TreeNodeFlags CorePluginsTreeState;
        public TreeNodeFlags InstalledPluginsTreeNode;


        public ToggleNode DeveloperMode { get; set; } = false;

        [JsonIgnore]
        public ToggleNode ShowImguiDemo { get; set; } = false;

        [Menu("Reload plugin DLL on change")]
        public ToggleNode AutoReloadDllOnChanges { get; set; } = true;
    }
}