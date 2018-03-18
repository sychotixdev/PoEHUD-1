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
using PoeHUD.Hud.Menu.SettingsDrawers;
using System.Diagnostics;
using PoeHUD.Hud;

namespace PoeHUD.Plugins
{
    public class BasePlugin
    {
        internal BasePlugin()
        {
            PluginName = GetType().Name;
        }
        public string PluginDirectory { get; internal set; }
        public string LocalPluginDirectory { get; private set; }
        public string PluginName;

        internal PluginHolder _ExternalPluginData;

        //Diagnostics
        internal Stopwatch DiagnosticTimer;
        internal long AwerageMs;
        internal long TopMs;
        internal long CurrentMs;

        internal void InitPlugin(PluginHolder pluginData)
        {
            _ExternalPluginData = pluginData;
            PluginDirectory = pluginData.PluginDirectory;
            LocalPluginDirectory = PluginDirectory.Substring(PluginDirectory.IndexOf($@"\{PluginExtensionPlugin.PluginsDirectory}\") + 1);
            DiagnosticTimer = new Stopwatch();
        }

        //For modification of default rendering of settings
        public List<BaseSettingsDrawer> SettingsDrawers => _ExternalPluginData.SettingPropertyDrawers;

        public static PluginExtensionPlugin API;
        public GameController GameController => API.GameController;
        public Graphics Graphics => API.Graphics;
        public Memory Memory => GameController.Memory;

        public virtual void Initialise() { }
        public virtual void Render() { }
        public virtual void EntityAdded(EntityWrapper entityWrapper) { }
        public virtual void EntityRemoved(EntityWrapper entityWrapper) { }
        public virtual void OnClose() { }
        public virtual void OnPluginSelectedInMenu() { }

        public virtual bool CanPluginBeEnabledInOptions { get; protected set; } = true;

        #region PluginMethods
        internal virtual bool _allowRender => true;
        private bool _initialized = false;

        internal void _Initialise()
        {
            //If plugin disabled dont init when start
            if (!_allowRender) return;

            _ForceInitialize();
        }

        //This will be also called when plugin is disabled, 
        //but selected in main menu for settings rendering. We should initialize before generating the menu
        internal void _ForceInitialize()
        {
            if (_initialized) return;
            _initialized = true;

            try { Initialise(); }
            catch (Exception e) { HandlePluginError("Initialise", e); }

            try { InitializeSettingsMenu(); }
            catch (Exception e) { HandlePluginError("InitializeSettingsMenu", e); }
        }


        internal void _Render()
        {
            if (!_allowRender) return;

            if (!_initialized) _Initialise();//init if load disabled plugin

            if (MainMenuWindow.Settings.DeveloperMode.Value)
                DiagnosticTimer.Restart();
            try { Render(); }
            catch (Exception e) { HandlePluginError("Render", e); }

            if (MainMenuWindow.Settings.DeveloperMode.Value)
            {
                DiagnosticTimer.Stop();
                CurrentMs = DiagnosticTimer.ElapsedMilliseconds;
                AwerageMs += (CurrentMs - AwerageMs) / 10;
                TopMs = Math.Max(TopMs, CurrentMs);
            }
        }

        internal void _EntityAdded(EntityWrapper entityWrapper)
        {
            if (!_initialized || !_allowRender)
                return;

            try { EntityAdded(entityWrapper); }
            catch (Exception e) { HandlePluginError("EntityAdded", e); }
        }

        internal void _EntityRemoved(EntityWrapper entityWrapper)
        {
            if (!_initialized || !_allowRender) return;

            try { EntityRemoved(entityWrapper); }
            catch (Exception e) { HandlePluginError("EntityRemoved", e); }
        }

        internal void _OnClose()
        {
            if (!_initialized) return;

            try { OnClose(); }
            catch (Exception e) { HandlePluginError("OnClose", e); }

            try { _SaveSettings(); }
            catch (Exception e) { HandlePluginError("SaveSettings", e); }
        }

        internal virtual void _OnPluginSelectedInMenu()
        {
            try { OnPluginSelectedInMenu(); }
            catch (Exception e) { HandlePluginError("OnPluginSelectedInMenu", e); }
        }

        #endregion

        internal virtual SettingsBase _LoadSettings() { return null; }
        internal virtual void _SaveSettings() { }

        #region Error Logging
        public float PluginErrorDisplayTime = 2;
        private string LogFileName = "ErrorLog.txt";
        private string logPath => PluginDirectory + "\\" + LogFileName;

        internal void HandlePluginError(string methodName, Exception exception)
        {
            LogError($"Plugin: '{PluginName}', Error in function: '{methodName}' : '{exception.Message}'", PluginErrorDisplayTime);

            try
            {
                using (StreamWriter w = File.AppendText(logPath))
                {
                    w.Write("\r\nLog Entry : ");
                    w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                    w.WriteLine($" Method error: {methodName} : {exception.ToString()}");
                    w.WriteLine("-------------------------------");
                }
            }
            catch (Exception e)
            {
                LogError(" Can't save error log. Error: " + e.Message, 5);
            }
        }
        #endregion

        #region Logging
        public static void LogError(string message, float displayTime) => LogError((object)message, displayTime);
        public static void LogMessage(string message, float displayTime) => LogMessage((object)message, displayTime);
        public static void LogError(object message, float displayTime)
        {
            if (message == null)
                LogMessage("null", displayTime, Color.Red);
            else
                LogMessage(message.ToString(), displayTime, Color.Red);
        }
        public static void LogMessage(object message, float displayTime)
        {
            if (message == null)
                LogMessage("null", displayTime, Color.White);
            else
                LogMessage(message.ToString(), displayTime, Color.White);
        }
        public static void LogWarning(object message, float displayTime)
        {
            if (message == null)
                LogMessage("null", displayTime, Color.Yellow);
            else
                LogMessage(message.ToString(), displayTime, Color.Yellow);
        }
        public static void LogMessage(object message, float displayTime, Color color)
        {
            if (message == null)
                DebugPlug.DebugPlugin.LogMsg("null", displayTime, color);
            else
                DebugPlug.DebugPlugin.LogMsg(message.ToString(), displayTime, color);
        }
        #endregion



        public virtual void DrawSettingsMenu() { }
        public virtual void InitializeSettingsMenu() { }
    }
}
