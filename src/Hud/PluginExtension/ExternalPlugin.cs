using PoeHUD.Plugins;
using System;
using System.Reflection;

namespace PoeHUD.Hud.PluginExtension
{
    public sealed class ExternalPlugin
    {
        private object PluginInstance;
        public BasePlugin BPlugin;
        public string PluginDir; //Will be used for loading resources (images, sounds, etc.) from plugin floder
        private Type PluginType;
        private PluginExtensionPlugin API;

        public string PluginName { get { return PluginType.Name; } }

        public ExternalPlugin(Type type, PluginExtensionPlugin api, string pluginDir)
        {
            PluginDir = pluginDir;
            PluginType = type;
            API = api;
            InitPlugin();
        }

        //////////////////////////////////////////////////////
        //Also can be used for restarting the plugin
        public void InitPlugin()
        {
            try
            {
                PluginInstance = Activator.CreateInstance(PluginType);
                BPlugin = PluginInstance as BasePlugin;
            }
            catch (Exception e)
            {
                API.LogError($"Error in plugin constructor! Plugin: {PluginName}, Error: " + e.Message, 5);//TODO: Test this exception
                return;
            }

            BPlugin.iInit(API, this);
            API.eRender += BPlugin.iRender;
            API.eEntityAdded += BPlugin.iEntityAdded;
            API.eEntityRemoved += BPlugin.iEntityRemoved;
            API.eClose += BPlugin.iOnClose;
            API.eInitialise += BPlugin.iInitialise;
            API.eInitMenu += BPlugin.iInitialiseMenu;
        }

        
        private MethodInfo CheckOverridedMethod(string overrMethodName, string invokeMethodName)
        {
            var overrMethod = PluginType.GetMethod(overrMethodName);

            if (overrMethod != null && overrMethod.DeclaringType != typeof(BasePlugin))
            {
                var invokeMethod =  typeof(BasePlugin).GetMethod(invokeMethodName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);

                if (invokeMethod == null)
                    API.LogError($"Can't find base method {invokeMethodName} in plugin: {PluginName} !", 5);
                else
                    return invokeMethod;
            }
            return null;
        }
        
        //////////////////////////////////////////////////////    
    }
}
