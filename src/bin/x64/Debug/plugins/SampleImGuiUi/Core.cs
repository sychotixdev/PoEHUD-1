using ImGuiNET;
using PoeHUD.Plugins;

namespace SampleImGuiUi
{
    public class Core : BaseSettingsPlugin<ImGuiSetting>
    {

        public override void Initialise() { base.Initialise(); }
        public override void Render()
        {
            base.Render();
            SampleUI();
        }
        public void SampleUI()
        {
            ImGui.SetNextWindowSize(new System.Numerics.Vector2(500, 500), Condition.Appearing);
            ImGui.SetNextWindowPos(new System.Numerics.Vector2(960 + 250, 540 + 250), Condition.Appearing, new System.Numerics.Vector2(1, 1));
            ImGui.BeginWindow("Sample UI", WindowFlags.Default);
            byte[] buffer = new byte[100];
            ImGui.InputText("Testing", buffer, 100, InputTextFlags.Default, null);
            ImGui.EndWindow();
        }
    }
}
