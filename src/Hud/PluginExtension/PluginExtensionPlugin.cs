using PoeHUD.Controllers;
using System;
using PoeHUD.Hud.Interfaces;
using PoeHUD.Models;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using PoeHUD.Plugins;
using Graphics = PoeHUD.Hud.UI.Graphics;
using PoeHUD.Hud.Menu;

namespace PoeHUD.Hud.PluginExtension
{
    public class PluginExtensionPlugin : IPlugin
    {
        public readonly GameController GameController;
        public readonly Graphics Graphics;
        public PluginExtensionPlugin(GameController gameController, Graphics graphics)
        {
            GameController = gameController;
            Graphics = graphics;
            SearchPlugins();
            InitPlugins();
            gameController.EntityListWrapper.EntityAdded += OnEntityAdded;
            gameController.EntityListWrapper.EntityRemoved += OnEntityRemoved;
            MenuPlugin.eInitMenu += delegate (RootButton menu) { eInitMenu(menu); };
        }
        
        public event Action eInitialise = delegate { };
        public event Action eRender = delegate { };
        public event Action<EntityWrapper> eEntityAdded = delegate { };
        public event Action<EntityWrapper> eEntityRemoved = delegate { };
        public event Action<RootButton> eInitMenu = delegate { };
        public event Action eClose = delegate { };

        private void SearchPlugins()
        {
            DirectoryInfo PluginsDir = new DirectoryInfo("plugins");
            if (!PluginsDir.Exists) return;

            foreach (var pluginDirectory in PluginsDir.GetDirectories())
            {
                var directoryDlls = pluginDirectory.GetFiles("*.dll", SearchOption.TopDirectoryOnly);

                foreach (var dll in directoryDlls)
                    TryLoadDll(dll.FullName, pluginDirectory.FullName);
            }
        }
        private void TryLoadDll(string path, string dir)
        {
            var myAsm = Assembly.LoadFrom(path);
            if (myAsm == null) return;

            var asmTypes = myAsm.GetTypes();
            if (asmTypes.Length == 0) return;

            foreach (var type in asmTypes)
            {
                if (type.IsSubclassOf(typeof(BasePlugin)))
                {
                    new ExternalPlugin(type, this, dir);
                    LogMessage("Loaded plugin: " + type.Name, 3);
                }
            }
        }

        #region PluginMethods
        public void InitPlugins()
        {
            eInitialise();
        }
        public void Render()
        {
            eRender();
        }
        private void OnEntityAdded(EntityWrapper entityWrapper)
        {
            eEntityAdded(entityWrapper);
        }
        private void OnEntityRemoved(EntityWrapper entityWrapper)
        {
            eEntityRemoved(entityWrapper);
        }
        public void Dispose()
        {
            eClose();
        }
        #endregion



        public void LogError(string message, float displayTime)
        {
            DebugPlug.DebugPlugin.LogMsg(message, displayTime, SharpDX.Color.Red);
        }
        public void LogMessage(string message, float displayTime)
        {
            DebugPlug.DebugPlugin.LogMsg(message, displayTime);
        }
    }
}
