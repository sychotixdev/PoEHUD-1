using System;
using System.IO;
using System.Reflection;
using PoeHUD.Controllers;
using PoeHUD.Hud.Menu;
using PoeHUD.Plugins;
using ImGuiVector2 = System.Numerics.Vector2;
using ImGuiVector4 = System.Numerics.Vector4;

namespace PoeHUD.Hud.PluginExtension
{
    /// <inheritdoc />
    /// <summary>
    /// This class will load and process plugin that located in DLL file
    /// </summary>
    public class ExternalPluginHolder : PluginHolder
    {
        public enum PluginState
        {
            Unknown,
            Loaded,
            ErrorClassInstance,
            Reload_CantUnload,
            Reload_DllNotFound,
            Reload_ClassNotFound
        }

        private readonly string _dllPath;
        private readonly string _fullTypeName;

        //Saving all references to plugin. Will be destroyed on plugin reload
        internal BasePlugin BPlugin;
        private DateTime _lastWrite = DateTime.MinValue;

        public ExternalPluginHolder(PluginExtensionPlugin api, string dllPath, string fullTypeName) : base(Path.GetFileNameWithoutExtension(dllPath))
        {
            API = api;
            _dllPath = dllPath;
            _fullTypeName = fullTypeName;
            PluginDirectory = Path.GetDirectoryName(dllPath);

            ReloadPlugin(false);

            var dllChangeWatcher = new FileSystemWatcher
            {
                NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.CreationTime,
                Path = PluginDirectory,
                EnableRaisingEvents = true
            };

            dllChangeWatcher.Changed += DllChanged;
            api.eClose += () => dllChangeWatcher.Dispose();
        }

        public PluginState State { get; private set; } //Will be used by poehud main menu to display why plugin is not loaded/reloaded
        internal override bool CanBeEnabledInOptions => BPlugin != null && BPlugin.CanPluginBeEnabledInOptions;

        private void DllChanged(object sender, FileSystemEventArgs e)
        {
            if (!MainMenuWindow.Settings.AutoReloadDllOnChanges.Value) return;
            if (e.FullPath != _dllPath) return; //Watchin only dll file

            //Events being raised multiple times https://stackoverflow.com/questions/1764809/filesystemwatcher-changed-event-is-raised-twice
            var lastWriteTime = File.GetLastWriteTime(e.FullPath);

            if (Math.Abs((lastWriteTime - _lastWrite).TotalSeconds) < 1)
                return;

            _lastWrite = lastWriteTime;

            if (!File.Exists(_dllPath))
            {
                State = PluginState.Reload_DllNotFound;
                return;
            }

            try
            {
                ReloadPlugin(true);
                BasePlugin.LogMessage($"Reloaded dll: {Path.GetFileName(_dllPath)}", 3);
            }
            catch (Exception ex)
            {
                BasePlugin.LogError($"Cannot reload dll: {Path.GetFileName(_dllPath)}, Error: {ex.Message}", 3);
            }
        }

        public void ReloadPlugin(bool actualyReload)
        {
            if (BPlugin != null)
            {
                BPlugin._OnClose(); //saving settings, closing opened threads (on plugin side)

                API.eRender -= BPlugin._Render;
                API.eClose -= BPlugin._OnClose;
                API.eAreaChange -= BPlugin._AreaChange;
                API.eInitialise -= BPlugin._Initialise;
                BPlugin._OnPluginDestroyForHotReload();

                BPlugin = null;
                SettingPropertyDrawers.Clear();

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            Assembly asmToLoad;
            var debugCymboldFilePath = _dllPath.Replace(".dll", ".pdb");

            if (File.Exists(debugCymboldFilePath))
            {
                var dbgCymboldBytes = File.ReadAllBytes(debugCymboldFilePath);
                asmToLoad = Assembly.Load(File.ReadAllBytes(_dllPath), dbgCymboldBytes);
            }
            else
                asmToLoad = Assembly.Load(File.ReadAllBytes(_dllPath));

             var pluginType = asmToLoad.GetType(_fullTypeName);

            if (pluginType == null)
            {
                State = PluginState.Reload_ClassNotFound;
                return;
            }

            //Spawning a new plugin class instance   
            object pluginClassObj = null;

            try
            {
                pluginClassObj = Activator.CreateInstance(pluginType);
            }
            catch (Exception ex)
            {
                BasePlugin.LogMessage($"Error loading plugin {Path.GetFileNameWithoutExtension(_dllPath)}: " + ex.Message, 3);
                State = PluginState.ErrorClassInstance;
                return;
            }

            BPlugin = pluginClassObj as BasePlugin;
            BPlugin.InitPlugin(this);
            Settings = BPlugin._LoadSettings();

            if (!string.IsNullOrEmpty(BPlugin.PluginName))
                PluginName = BPlugin.PluginName;

            API.eRender += BPlugin._Render;
            API.eClose += BPlugin._OnClose;
            API.eInitialise += BPlugin._Initialise;
            API.eAreaChange += BPlugin._AreaChange;

            BPlugin._Initialise();

            if (actualyReload)
                BPlugin._AreaChange(GameController.Instance.Area);

            //foreach (var entity in GameController.Instance.EntityListWrapper.Entities.ToList())//TODO
            //{
            //    BPlugin._EntityAdded(entity);
            //}
        }

        internal override void OnPluginSelectedInMenu()
        {
            if (BPlugin == null) return;
            BPlugin._ForceInitialize(); //Added because if plugin is not enabled in options - menu will not be initialized, also possible errors cuz _Initialise was not called
            BPlugin._OnPluginSelectedInMenu();
        }

        internal override void DrawSettingsMenu()
        {
            if (BPlugin == null) return;

            try
            {
                BPlugin.DrawSettingsMenu();
            }
            catch (Exception e)
            {
                BPlugin.HandlePluginError("DrawSettingsMenu", e);
            }
        }
    }
}
