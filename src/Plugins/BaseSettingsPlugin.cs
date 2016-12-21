using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Controllers;
using PoeHUD.Hud.Interfaces;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using SharpDX;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using PoeHUD.Hud.Menu;
using System.Reflection;
using MenuItem = PoeHUD.Hud.Menu.MenuItem;
using PoeHUD.Hud.PluginExtension;

namespace PoeHUD.Plugins
{
    public class BaseSettingsPlugin<TSettings> : BasePlugin where TSettings : SettingsBase, new()
    {
        protected TSettings Settings { get; private set; }
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

        public override void InitialiseMenu(RootButton mainMenu)
        {
            var menu = MenuPlugin.AddChild(mainMenu, PluginName, Settings.Enable);
            var settingsProps = Settings.GetType().GetProperties();

            foreach (var property in settingsProps)
            {
                var menuAttrib = property.GetCustomAttribute<MenuAttribute>();

                if(menuAttrib != null)
                {
                    var propType = property.PropertyType;

                    if (propType == typeof(ToggleNode))
                    {
                        ToggleNode option = property.GetValue(Settings) as ToggleNode;
                        MenuPlugin.AddChild(menu, menuAttrib.MenuName, option);
                    }
                    else if (propType == typeof(ColorNode))
                    {
                        ColorNode option = property.GetValue(Settings) as ColorNode;
                        MenuPlugin.AddChild(menu, menuAttrib.MenuName, option);
                    }                    
                    else if (propType.IsGenericType)
                    {
                        //Actually we can use reflection to find correct method in MenuPlugin by argument types and invoke it, but I don't have enough time for this way..
                        /*
                        var method = typeof(MenuPlugin).GetMethods();
                        method.ToList().Find(x => x.Name == "AddChild");
                        */

                        var genericType = propType.GetGenericTypeDefinition();

                        if (genericType == typeof(RangeNode<>))
                        {
                            var genericParameter = propType.GenericTypeArguments;

                            if (genericParameter.Length > 0)
                            {
                                var argType = genericParameter[0];

                                if (argType == typeof(int))
                                {
                                    RangeNode<int> option = property.GetValue(Settings) as RangeNode<int>;
                                    MenuPlugin.AddChild(menu, menuAttrib.MenuName, option);
                                }
                                else if (argType == typeof(float))
                                {
                                    RangeNode<float> option = property.GetValue(Settings) as RangeNode<float>;
                                    MenuPlugin.AddChild(menu, menuAttrib.MenuName, option);
                                }
                                else
                                    LogError($"Generic node argument '{argType.Name}' is not defined in code. Node type: " + propType.Name, 5);
                            }
                            else
                                LogError("Can't get GenericTypeArguments from option type: " + propType.Name, 5);
                        }
                        else
                            LogError("Generic option node is not defined in code: " + genericType.Name, 5);
                        
                    }
                    else
                        LogError("Type of option node is not defined: " + propType.Name, 5);
                }
            }
        }

 
    }
}
