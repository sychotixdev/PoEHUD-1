using System;
using PoeHUD.Plugins;
using PoeHUD.Models;
using System.Reflection;
using PoeHUD.Hud.Menu;

namespace PoeHUD.Hud.PluginExtension
{
    public sealed class ExternalPlugin
    {
        private object PluginInstance;
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
            }
            catch (Exception e)
            {
                API.LogError($"Error in plugin constructor! Plugin: {PluginName}, Error: " + e.Message, 5);//TODO: Test this exception
                return;
            }

            var initMethod = PluginType.GetMethod("iInit");

            if (initMethod != null)
                initMethod.Invoke(PluginInstance, new object[] { API, this });
            else
            {
                API.LogError("Can't set up plugin!", 3);
                return;
            }

            //Note: Actually we don't need to invoke methods that is not overrided, so we will check the DeclaringType of method to find out that
            //Also we let the plugin to handle functions errors itself, so we will invoke a function that will catch all errors (check CheckOverridedMethod function)


            var renderMethod = CheckOverridedMethod("Render", "iRender");
            if(renderMethod != null)
                API.eRender += delegate { renderMethod.Invoke(PluginInstance, new object[0]); };


            var entityAddedMethod = CheckOverridedMethod("EntityAdded", "iEntityAdded");
            if (entityAddedMethod != null)
                API.eEntityAdded += delegate (EntityWrapper ew) { entityAddedMethod.Invoke(PluginInstance, new object[] { ew }); };


            var entityremovedMethod = CheckOverridedMethod("EntityRemoved", "iEntityRemoved");
            if (entityremovedMethod != null)
                API.eEntityRemoved += delegate (EntityWrapper ew) { entityremovedMethod.Invoke(PluginInstance, new object[] { ew }); };


            //This methods should be invoked for loading/saving options, init menu, etc.
            var closeMethod = typeof(BasePlugin).GetMethod("iOnClose", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            if (closeMethod != null)
                API.eClose += delegate { closeMethod.Invoke(PluginInstance, new object[0]); };

            var initialiseMethod = typeof(BasePlugin).GetMethod("iInitialise", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            if (initialiseMethod != null)
                API.eInitialise += delegate { initialiseMethod.Invoke(PluginInstance, new object[0]); };

            var menuInitMethod = typeof(BasePlugin).GetMethod("iInitialiseMenu", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            if (menuInitMethod != null)
                API.eInitMenu += delegate(MenuItem menu) { menuInitMethod.Invoke(PluginInstance, new object[] { menu }); };

            
       
            

            return;
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
