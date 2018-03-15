using Newtonsoft.Json;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.Settings;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using SharpDX;
using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.PluginExtension;
using PoeHUD.Models;
using System;
using System.IO;
using Graphics = PoeHUD.Hud.UI.Graphics;

namespace PoeHUD.Plugins
{
    public class BaseSettingsPlugin<TSettings> : BasePlugin where TSettings : SettingsBase, new()
    {
        internal override bool _allowRender => Settings.Enable.Value;

        #region Settings
        public TSettings Settings { get; private set; }
        private string SettingsFileName = "config.ini";

        private string SettingsFullPath => PluginDirectory + "\\" + SettingsFileName;

        internal override void _LoadSettings()
        {
            try
            {
                var settingsFullPath = SettingsFullPath;

                if (File.Exists(settingsFullPath))
                {
                    string json = File.ReadAllText(settingsFullPath);
                    Settings = JsonConvert.DeserializeObject<TSettings>(json, SettingsHub.jsonSettings);
                }

                if (Settings == null)
                    Settings = new TSettings();
            }
            catch
            {
                LogError($"Plugin {PluginName} error load settings!", 3);
                Settings = new TSettings();
            }

            if (Settings.Enable == null)//...also sometimes config Enable contains only "null" word, so that will be a fix for that
                Settings.Enable = false;


            if (GameController.pluginsSettings.ContainsKey(SettingsFullPath))//For hot reload
            {
                GameController.pluginsSettings.Remove(SettingsFullPath);
            }

            GameController.pluginsSettings.Add(SettingsFullPath, Settings);
        }

        internal override void _SaveSettings()
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
        #endregion

        //if you going to draw menu fully on ur side- override this
        public override void DrawSettingsMenu()
        {
            InitializeMenuOnce();
            DrawGeneratedSettingsMenu();
        }


        protected void DrawGeneratedSettingsMenu()
        {
            _ExternalPluginData.DrawGeneratedSettingsMenu();
        }

        private bool _initializeMenuOnce = false;
        protected void InitializeMenuOnce()
        {
            if (!_initializeMenuOnce)
            {
                _initializeMenuOnce = true;
                _ExternalPluginData.InitializeSettingsMenu(Settings);
            }
        }
    }
}