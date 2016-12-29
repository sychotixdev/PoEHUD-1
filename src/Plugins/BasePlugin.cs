using PoeHUD.Models;
using PoeHUD.Hud.PluginExtension;
using PoeHUD.Controllers;
using Graphics = PoeHUD.Hud.UI.Graphics;
using System;
using System.IO;
using PoeHUD.Hud.Menu;
using PoeHUD.Framework;

namespace PoeHUD.Plugins
{
    public class BasePlugin
    {
        public BasePlugin()
        {
            PluginName = GetType().Name;
        }
        public static PluginExtensionPlugin API;
        protected GameController GameController => API.GameController;
        protected Graphics Graphics => API.Graphics;
        protected Memory Memory => GameController.Memory;


        protected string PluginDirectory;
        protected string LocalPluginDirectory;
        public string PluginName;

        protected Action eSaveSettings = delegate { };
        protected Action eLoadSettings = delegate { };
        protected bool bClearLogOnStartup = true;

        public virtual bool bAllowRender => true;

        #region ExternalInvokeMethods
        private void iInitialise()
        {
            if (bClearLogOnStartup)
            {
                try
                {
                    File.Delete(logPath);//Clear log
                }
                catch (Exception e)
                {
                    LogError("Can't clear ErrorLog. Error: " + e.Message, 5);
                }
              
            }
            
            eLoadSettings();

            try { Initialise(); }
            catch (Exception e)
            {
                HandlePluginError("Initialise", e);
            }   
        }
        private void iRender()
        {
            if (!bAllowRender) return;

            try { Render(); }
            catch (Exception e)
            {
                HandlePluginError("Render", e);
            }
        }
        private void iEntityAdded(EntityWrapper entityWrapper)
        {
            try { EntityAdded(entityWrapper); }
            catch (Exception e)
            {
                HandlePluginError("EntityAdded", e);
            }
        }
        private void iEntityRemoved(EntityWrapper entityWrapper)
        {
            try { EntityRemoved(entityWrapper); }
            catch (Exception e)
            {
                HandlePluginError("EntityRemoved", e);
            }
        }
        private void iOnClose()
        { 
            try { OnClose(); }
            catch (Exception e)
            {
                HandlePluginError("OnClose", e);
            }
            eSaveSettings();
        }
        private void iInitialiseMenu(MenuItem menu)
        {
            try { InitialiseMenu(menu); }
            catch (Exception e)
            {
                HandlePluginError("InitialiseMenu", e);
            }
        }
        #endregion

        public virtual void Initialise() { }
        public virtual void Render() { }
        public virtual void EntityAdded(EntityWrapper entityWrapper) { }
        public virtual void EntityRemoved(EntityWrapper entityWrapper) { }
        public virtual void OnClose() { }
        public virtual void InitialiseMenu(MenuItem menu) { }

        public float PluginErrorDisplayTime = 3;
        private string LogFileName = "ErrorLog.txt";

        private string logPath => PluginDirectory + "\\" + LogFileName;

        private void HandlePluginError(string methodName, Exception exception)
        {
            LogError($"Error in function: '{methodName}' : {exception.Message}", PluginErrorDisplayTime);

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

        public static void LogError(string message, float displayTime)
        {
            if(API == null)
                return;

            API.LogError(message, displayTime);
        }
        public static void LogMessage(string message, float displayTime)
        {
            if (API == null)
                return;

            API.LogMessage(message, displayTime);
        }

        public void iInit(PluginExtensionPlugin api, ExternalPlugin pluginData)
        {
            API = api;
            PluginDirectory = pluginData.PluginDir;
            LocalPluginDirectory = PluginDirectory.Substring(PluginDirectory.IndexOf(@"\plugins\") + 1); 
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
