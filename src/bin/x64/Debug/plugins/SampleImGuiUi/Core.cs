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
            bool isopened = false;
            ImGuiNative.igShowDemoWindow(ref isopened);
        }
    }
}
