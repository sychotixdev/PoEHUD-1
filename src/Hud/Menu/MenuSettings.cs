using PoeHUD.Hud.Settings;
using SharpDX;
using ImGuiVector2 = System.Numerics.Vector2;
using ImGuiNET;

namespace PoeHUD.Hud.Menu
{
    public sealed class MenuSettings : SettingsBase
    {
        public MenuSettings()
        {
            Enable = true;
            X = 10; Y = 85;
        }
        public float X { get; set; }
        public float Y { get; set; }

        public ImGuiVector2 MenuWindowPos;
        public ImGuiVector2 MenuWindowSize;
        public bool IsOpened = true;

        public TreeNodeFlags CorePluginsTreeState;
        public TreeNodeFlags InstalledPluginsTreeNode;
    }
}