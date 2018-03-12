using Newtonsoft.Json;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.Settings;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace PoeHUD.Plugins
{
    public class BaseSettingsPlugin<TSettings> : BasePlugin where TSettings : SettingsBase, new()
    {
        public TSettings Settings { get; private set; }
        private string SettingsFileName = "config.ini";

        public BaseSettingsPlugin()
        {
            eSaveSettings += SaveSettings;
            eLoadSettings += LoadSettings;
        }

        private string SettingsFullPath
        {
            get { return PluginDirectory + "\\" + SettingsFileName; }
        }

        private void LoadSettings()
        {
            try
            {
                var settingsFullPath = SettingsFullPath;

                if (File.Exists(settingsFullPath))
                {
                    string json = File.ReadAllText(settingsFullPath);
                    Settings = JsonConvert.DeserializeObject<TSettings>(json, SettingsHub.jsonSettings);
                }

                if (Settings == null)//...also sometimes config contains only "null" word, so that will be a fix for that
                    Settings = new TSettings();
            }
            catch
            {
                LogError($"Plugin {PluginName} error load settings!", 3);
                Settings = new TSettings();
            }

            if (Settings.Enable == null)
                Settings.Enable = false;
            if (!GameController.pluginsSettings.TryGetValue(SettingsFileName, out _))
            {
                //GameController.pluginsSettings.Add(Settings.ToString().Split('.')[0],Settings);
                GameController.pluginsSettings.Add(Settings.GetType().Assembly.GetName().Name, Settings);
            }
        }

        private void SaveSettings()
        {
            try
            {
                var settingsDirName = Path.GetDirectoryName(SettingsFullPath);
                if (!Directory.Exists(settingsDirName))
                    Directory.CreateDirectory(settingsDirName);

                using (var stream = new StreamWriter(File.Create(SettingsFullPath)))
                {
                    string json = JsonConvert.SerializeObject(Settings, Formatting.Indented, SettingsHub.jsonSettings);
                    stream.Write(json);
                }
            }
            catch
            {
                LogError($"Plugin {PluginName} error save settings!", 3);
            }
        }

        public override bool bAllowRender
        {
            get
            {
                return Settings.Enable;
            }
        }
    }
}