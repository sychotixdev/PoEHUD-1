using PoeHUD.Controllers;
using PoeHUD.Hud.Interfaces;
using PoeHUD.Hud.Menu;
using PoeHUD.Models;
using PoeHUD.Plugins;
using System;
using System.IO;
using System.Reflection;
using Trinet.Core.IO.Ntfs;
using Graphics = PoeHUD.Hud.UI.Graphics;

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
            MenuPlugin.eInitMenu += InitMenuForPlugins;
        }
        
        private void InitMenuForPlugins(RootButton mainMenu)
        {
            var pluginsMenu = MenuPlugin.AddChild(mainMenu, "Plugins", true);
            eInitMenu(pluginsMenu);
        }

        public event Action eInitialise = delegate { };
        public event Action eRender = delegate { };
        public event Action<EntityWrapper> eEntityAdded = delegate { };
        public event Action<EntityWrapper> eEntityRemoved = delegate { };
        public event Action<MenuItem> eInitMenu = delegate { };
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
            if(ProcessFile_Real(path))
            {
                LogMessage("Can't unblock plugin: " + path, 5);
                return;
            }

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

        private const string ZoneName = "Zone.Identifier";
        static bool ProcessFile_Real(string path)
        {
            bool result = FileSystem.AlternateDataStreamExists(path, ZoneName);
            if (result)
            {
                // Clear the read-only attribute, if set:
                FileAttributes attributes = File.GetAttributes(path);
                if (FileAttributes.ReadOnly == (FileAttributes.ReadOnly & attributes))
                {
                    attributes &= ~FileAttributes.ReadOnly;
                    File.SetAttributes(path, attributes);
                }

                result = FileSystem.DeleteAlternateDataStream(path, ZoneName);

                result = FileSystem.AlternateDataStreamExists(path, ZoneName);//Check again
            }

            return result;
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



        public void LogError(object message, float displayTime)
        {
            DebugPlug.DebugPlugin.LogMsg(message, displayTime, SharpDX.Color.Red);
        }
        public void LogMessage(object message, float displayTime)
        {
            DebugPlug.DebugPlugin.LogMsg(message, displayTime);
        }
    }
}
