using PoeHUD.Plugins;
using System;
using System.Reflection;
using System.IO;
using PoeHUD.Hud.Menu.SettingsDrawers;
using PoeHUD.Hud.UI;
using PoeHUD.Hud.Settings;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using ImGuiNET;
using ImGuiVector2 = System.Numerics.Vector2;
using ImGuiVector4 = System.Numerics.Vector4;
using Vector2 = System.Numerics.Vector2;

namespace PoeHUD.Hud.PluginExtension
{
    public sealed class ExternalPlugin
    {
        public readonly string PluginDir; //Will be used for loading resources (images, sounds, etc.) from plugin floder
        private PluginExtensionPlugin API;

        private readonly string FullTypeName;
        private readonly string DllPath;
        internal PluginDataInstance PluginInstance = new PluginDataInstance();  //Saving all references to plugin. Will be destroyed on plugin reload.
        private DateTime DllTimeVersion;
        internal SettingsBase Settings;
        private bool IsCorePlugin;

        public List<BaseSettingsDrawer> GetSettingsDrawers()
        {
            return PluginInstance.SettingPropertyDrawers;
        }

        public string PluginName { get; internal set; } = "NoName";

        public PluginState State { get; private set; }//Will be used by poehud main menu to display why plugin is not loaded/reloaded

        public ExternalPlugin(PluginExtensionPlugin api, string dllPath, string fullTypeName)
        {
            API = api;
            DllPath = dllPath;
            FullTypeName = fullTypeName;

            PluginDir = Path.GetDirectoryName(dllPath);

            var dllInfo = new FileInfo(DllPath);
            DllTimeVersion = dllInfo.LastWriteTime;

            PluginName = Path.GetFileNameWithoutExtension(DllPath);

            ReloadPlugin();
            API.eCheckPluginsDllReload += API_eCheckPluginsDllReload;
        }

        public ExternalPlugin(string pluginName, SettingsBase settings)//for buildin plugins
        {
            IsCorePlugin = true;
            Settings = settings;
            PluginName = pluginName;
            InitializeSettingsMenu(settings, true);
        }

        private void API_eCheckPluginsDllReload()
        {
            var dllInfo = new FileInfo(DllPath);
            if ((dllInfo.LastWriteTime - DllTimeVersion).Seconds > 2)
            {
                DllTimeVersion = dllInfo.LastWriteTime;
                BasePlugin.LogMessage("Reloading dll: " + DllPath, 3);
                ReloadPlugin();
            }
        }

        public void ReloadPlugin()
        {
            if (PluginInstance.BPlugin != null)
            {
                PluginInstance.BPlugin._OnClose();//saving settings, closing opened threads (on plugin side)

                API.eRender -= PluginInstance.BPlugin._Render;
                API.eEntityAdded -= PluginInstance.BPlugin._EntityAdded;
                API.eEntityRemoved -= PluginInstance.BPlugin._EntityRemoved;
                API.eClose -= PluginInstance.BPlugin._OnClose;
                API.eInitialise -= PluginInstance.BPlugin._Initialise;
                PluginInstance = null;

                GC.Collect();
            }

            var myAsm = Assembly.Load(File.ReadAllBytes(DllPath));
            if (myAsm == null)
            {
                State = PluginState.Reload_DllNotFound;
                return;
            }

            var pluginType = myAsm.GetType(FullTypeName);
            if (pluginType == null)
            {
                State = PluginState.Reload_ClassNotFound;
                return;
            }

            //Spawning a new plugin class instance   
            var pluginClassObj = Activator.CreateInstance(pluginType);

            PluginInstance = new PluginDataInstance();
            PluginInstance.BPlugin = pluginClassObj as BasePlugin;
            PluginInstance.BPlugin.InitPlugin(this);
            PluginInstance.BPlugin._LoadSettings();

            if (!string.IsNullOrEmpty(PluginInstance.BPlugin.PluginName))
                PluginName = PluginInstance.BPlugin.PluginName;

            PluginInstance.BPlugin.InitializeSettingsMenu();

            API.eRender += PluginInstance.BPlugin._Render;
            API.eEntityAdded += PluginInstance.BPlugin._EntityAdded;
            API.eEntityRemoved += PluginInstance.BPlugin._EntityRemoved;
            API.eClose += PluginInstance.BPlugin._OnClose;
            API.eInitialise += PluginInstance.BPlugin._Initialise;
        }

        public enum PluginState
        {
            Unknown,
            Loaded,
            Reload_CantUnload,
            Reload_DllNotFound,
            Reload_ClassNotFound
        }

        //Saving all references to plugin. Will be destroyed on plugin reload
        //Actualy works even without this)
        public class PluginDataInstance
        {
            public BasePlugin BPlugin;
            public readonly List<BaseSettingsDrawer> SettingPropertyDrawers = new List<BaseSettingsDrawer>();
        }

        internal void DrawSettingsMenu()
        {
            if(IsCorePlugin)
            {
                DrawGeneratedSettingsMenu();
            }
            else
            {
                if (PluginInstance.BPlugin == null) return;
                PluginInstance.BPlugin.DrawSettingsMenu();
            }
        }

        internal void DrawGeneratedSettingsMenu()
        {
            DrawDrawers(PluginInstance.SettingPropertyDrawers, null);
            ChildUniqId = 0;
        }

        private int ChildUniqId;
        private void DrawDrawers(List<BaseSettingsDrawer> drawers, BaseSettingsDrawer owner)
        {
            float childSize = 20;
            foreach (var drawer in drawers)
            {
                if (!drawer.IsVisible()) continue;
           
                if(drawer.Children.Count > 0)
                {
                    ImGuiNative.igGetContentRegionAvail(out var newcontentRegionArea);

                    //We are not going to make IF on this childs coz we don't want inteface jumping while scrollings
                    ImGui.BeginChild($"##{ChildUniqId++}", new Vector2(newcontentRegionArea.X, drawer.ChildHeight + 20), true, WindowFlags.NoScrollWithMouse);

                    drawer.Draw();
                    childSize += 20;

                    ImGui.SameLine();
                    ImGui.Text("");
                    ImGui.SameLine();

                    ImGuiNative.igGetContentRegionAvail(out newcontentRegionArea);
                    ImGui.BeginChild($"##{ChildUniqId++}", new Vector2(newcontentRegionArea.X, drawer.ChildHeight), false, WindowFlags.NoScrollWithMouse);

                    DrawDrawers(drawer.Children, drawer);
                    childSize += drawer.ChildHeight;
                    ImGui.EndChild();
                    ImGui.EndChild();
                }
                else
                {
                    drawer.Draw();
                    childSize += 21;
                }
            }

            if (owner != null)
                owner.ChildHeight = childSize;
        }

        
        public int GetUniqDrawerId()
        {
            return Enumerable.Range(100000, 1000).Except(Drawers.Keys).FirstOrDefault();
        }

        private Dictionary<int, BaseSettingsDrawer> Drawers = new Dictionary<int, BaseSettingsDrawer>();
        internal void InitializeSettingsMenu(SettingsBase settings, bool ignoreAttribute = false)//ignoreAttribute - for Core plugins
        {
            PluginInstance.SettingPropertyDrawers.Clear();
            Drawers.Clear();

            Settings = settings;
            var settingsProps = settings.GetType().GetProperties();

            foreach (var property in settingsProps)
            {
                if (property.Name == "Enable") continue;

                var menuAttrib = property.GetCustomAttribute<MenuAttribute>();
                if(ignoreAttribute && menuAttrib == null)
                    menuAttrib = new MenuAttribute(System.Text.RegularExpressions.Regex.Replace(property.Name, "(\\B[A-Z])", " $1"));//fix camel case

                if (menuAttrib != null)
                {
                    BaseSettingsDrawer drawer = null;
                    var propType = property.PropertyType;

                    if (propType == typeof(ButtonNode) || propType.IsSubclassOf(typeof(ButtonNode)))
                    {
                        drawer = new ButtonSettingDrawer(property.GetValue(settings) as ButtonNode);
                    }
                    else if (propType == typeof(EmptyNode) || propType.IsSubclassOf(typeof(EmptyNode)))
                    {
                        drawer = new LabelSettingDrawer();
                    }
                    else if (propType == typeof(HotkeyNode) || propType.IsSubclassOf(typeof(HotkeyNode)))
                    {
                        drawer = new HotkeySettingDrawer(property.GetValue(settings) as HotkeyNode);
                    }
                    else if (propType == typeof(ToggleNode) || propType.IsSubclassOf(typeof(ToggleNode)))
                    {
                        drawer = new CheckboxSettingDrawer(property.GetValue(settings) as ToggleNode);
                    }
                    else if (propType == typeof(ColorNode) || propType.IsSubclassOf(typeof(ColorNode)))
                    {
                        drawer = new ColorSettingDrawer(property.GetValue(settings) as ColorNode);
                    }
                    else if (propType == typeof(ListNode) || propType.IsSubclassOf(typeof(ListNode)))
                    {
                        drawer = new StringListSettingDrawer(property.GetValue(settings) as ListNode);
                    }
                    else if (propType.IsGenericType)
                    {
                        var genericType = propType.GetGenericTypeDefinition();

                        if (genericType == typeof(RangeNode<>))
                        {
                            var genericParameter = propType.GenericTypeArguments;

                            if (genericParameter.Length > 0)
                            {
                                var argType = genericParameter[0];
                                var valueDrawer = new BaseSettingsCustomDrawer();

                                if (argType == typeof(int))
                                {
                                    var rangeInt = property.GetValue(settings) as RangeNode<int>;
                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = ImGuiExtension.IntSlider(valueDrawer.ImguiUniqLabel, rangeInt.Value, rangeInt.Min, rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(float))
                                {
                                    var rangeInt = property.GetValue(settings) as RangeNode<float>;
                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = ImGuiExtension.FloatSlider(valueDrawer.ImguiUniqLabel, rangeInt.Value, rangeInt.Min, rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(double))
                                {
                                    var rangeInt = property.GetValue(settings) as RangeNode<double>;
                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = ImGuiExtension.FloatSlider(valueDrawer.ImguiUniqLabel, (float)rangeInt.Value, (float)rangeInt.Min, (float)rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(byte))
                                {
                                    var rangeInt = property.GetValue(settings) as RangeNode<byte>;
                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = (byte)ImGuiExtension.IntSlider(valueDrawer.ImguiUniqLabel, rangeInt.Value, rangeInt.Min, rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(long))
                                {
                                    var rangeInt = property.GetValue(settings) as RangeNode<long>;
                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = ImGuiExtension.IntSlider(valueDrawer.ImguiUniqLabel, (int)rangeInt.Value, (int)rangeInt.Min, (int)rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(short))
                                {
                                    var rangeInt = property.GetValue(settings) as RangeNode<short>;
                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = (short)ImGuiExtension.IntSlider(valueDrawer.ImguiUniqLabel, rangeInt.Value, rangeInt.Min, rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(ushort))
                                {
                                    var rangeInt = property.GetValue(settings) as RangeNode<ushort>;
                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = (ushort)ImGuiExtension.IntSlider(valueDrawer.ImguiUniqLabel, rangeInt.Value, rangeInt.Min, rangeInt.Max);
                                    };
                                }
                                else
                                    BasePlugin.LogError($"{PluginName}: Generic node argument for range node '{argType.Name}' is not defined in code. Range node type: " + propType.Name, 5);

                                drawer = valueDrawer;
                            }
                            else
                                BasePlugin.LogError($"{PluginName}: Can't get GenericTypeArguments from option type: " + propType.Name, 5);
                        }
                        else
                            BasePlugin.LogError($"{PluginName}: Generic option node is not defined in code: " + genericType.Name, 5);

                    }
                    else
                        BasePlugin.LogError($"{PluginName}: Type of option node is not defined: " + propType.Name, 5);

                    if (drawer != null)
                    {           
                        drawer.SettingName = menuAttrib.MenuName;

                        if(menuAttrib.index == -1)
                            drawer.SettingId = GetUniqDrawerId();
                        else
                            drawer.SettingId = menuAttrib.index;

                        if(Drawers.ContainsKey(drawer.SettingId))
                        {
                            BasePlugin.LogError($"{PluginName}: Already contain child with id {menuAttrib.parentIndex}. Trying to fix... Property " + property.Name, 5);
                            drawer.SettingId = GetUniqDrawerId();
                        }
                        Drawers.Add(drawer.SettingId, drawer);

                        if (menuAttrib.parentIndex != -1)
                        {
                            if(Drawers.TryGetValue(menuAttrib.parentIndex, out var parent))
                            {
                                parent.Children.Add(drawer);
                                continue;
                            }
                            BasePlugin.LogError($"{PluginName}: Can't find child with id {menuAttrib.parentIndex} to parent node. Property " + property.Name, 5);
                        }
                        PluginInstance.SettingPropertyDrawers.Add(drawer);
                    }
                    else
                    {
                        BasePlugin.LogError($"{PluginName}: Type of option node is not defined: " + propType.Name, 5);
                    }
                }
            }
        }
    }
}