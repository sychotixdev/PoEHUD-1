namespace PoeHUD.Hud.Settings
{
    public abstract class SettingsBase
    {
        public SettingsBase()
        {
            Enable = true;
        }
        public ToggleNode Enable { get; set; }
    }
}