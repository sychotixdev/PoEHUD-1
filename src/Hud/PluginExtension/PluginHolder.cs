using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using ImGuiNET;
using PoeHUD.Controllers;
using PoeHUD.Hud.Menu.SettingsDrawers;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using PoeHUD.Plugins;
using ImGuiVector2 = System.Numerics.Vector2;
using ImGuiVector4 = System.Numerics.Vector4;

namespace PoeHUD.Hud.PluginExtension
{
    /// <summary>
    ///     This class will process internal plugin (inside PoeHud)
    /// </summary>
    public class PluginHolder
    {
        private readonly List<StashTabNode> _stashTabNodesToUnload = new List<StashTabNode>();
        internal readonly List<BaseSettingsDrawer> SettingPropertyDrawers = new List<BaseSettingsDrawer>();
        private int _childUniqId;
        protected PluginExtensionPlugin API;

        public PluginHolder(string pluginName)
        {
            PluginName = pluginName;
        }

        public PluginHolder(string pluginName, SettingsBase settings) : this(pluginName) //for buildin plugins
        {
            Settings = settings;
            InitializeSettingsMenu(true);
        }

        public string PluginDirectory { get; internal set; } //Will be used for loading resources (images, sounds, etc.) from plugin floder
        internal SettingsBase Settings { get; set; }
        internal virtual bool CanBeEnabledInOptions { get; set; } = true; //For theme plugin
        public List<BaseSettingsDrawer> SettingsDrawers => SettingPropertyDrawers;
        public string PluginName { get; internal set; } = "%PluginName%";

        private List<int> DrawersIds
        {
            get { return GetAllDrawers().Select(x => x.SettingId).ToList(); }
        }

        //Called by main menu to draw plugin settings in right part of window
        internal virtual void DrawSettingsMenu()
        {
            DrawGeneratedSettingsMenu();
        }

        internal void DrawGeneratedSettingsMenu()
        {
            DrawSettingsRecursively(SettingPropertyDrawers, null);
            _childUniqId = 0;
        }

        internal virtual void OnPluginSelectedInMenu()
        {
        }

        private void DrawSettingsRecursively(List<BaseSettingsDrawer> drawers, BaseSettingsDrawer owner)
        {
            float childSize = 20;

            foreach (var drawer in drawers.ToList())
            {
                if (!drawer.IsVisibleFunc()) continue;

                if (drawer.Children.Count > 0)
                {
                    ImGuiNative.igGetContentRegionAvail(out var newcontentRegionArea);

                    //We are not going to make IF on this childs coz we don't want inteface jumping while scrollings
                    ImGui.BeginChild($"##{_childUniqId++}", new ImGuiVector2(newcontentRegionArea.X, drawer.ChildHeight + 40), true,
                        WindowFlags.NoScrollWithMouse);

                    drawer.DrawWithTooltip();
                    childSize += 30;
                    ImGui.Text("    ");
                    ImGui.SameLine();

                    ImGuiNative.igGetContentRegionAvail(out var newcontentRegionArea2);

                    ImGui.BeginChild($"##{_childUniqId++}", new ImGuiVector2(newcontentRegionArea2.X, drawer.ChildHeight), false,
                        WindowFlags.NoScrollWithMouse);

                    DrawSettingsRecursively(drawer.Children, drawer);
                    childSize += drawer.ChildHeight + 15;
                    ImGui.EndChild();
                    ImGui.EndChild();
                }
                else
                {
                    drawer.DrawWithTooltip();
                    childSize += 21;
                }
            }

            if (owner != null)
                owner.ChildHeight = childSize;
        }

        public int GetUniqDrawerId()
        {
            return Enumerable.Range(100000, 1000).Except(DrawersIds).FirstOrDefault();
        }

        private List<BaseSettingsDrawer> GetAllDrawers()
        {
            var result = new List<BaseSettingsDrawer>();
            GetDrawersRecurs(SettingPropertyDrawers, result);
            return result;
        }

        private void GetDrawersRecurs(List<BaseSettingsDrawer> drawers, List<BaseSettingsDrawer> result)
        {
            foreach (var drawer in drawers)
            {
                if (!result.Contains(drawer))
                    result.Add(drawer);
                else
                {
                    BasePlugin.LogError($"{PluginName}: Possible staskoverflow or duplicating drawers detected while generating menu. " +
                                        $"Drawer SettingName: {drawer.SettingName}, Id: {drawer.SettingId}", 5);
                }
            }

            drawers.ForEach(x => GetDrawersRecurs(x.Children, result));
        }

        internal void InitializeSettingsMenu(bool ignoreAttribute = false) //ignoreAttribute - for Core plugins
        {
            SettingPropertyDrawers.Clear();
            _stashTabNodesToUnload.ForEach(StashTabController.UnregisterStashNode);
            _stashTabNodesToUnload.Clear();

            var settingsProps = Settings.GetType().GetProperties();

            foreach (var property in settingsProps)
            {
                if (property.Name == "Enable") continue;

                if (property.GetCustomAttribute<IgnoreMenuAttribute>() != null) continue;

                var menuAttrib = property.GetCustomAttribute<MenuAttribute>();

                if (ignoreAttribute && menuAttrib == null)
                    menuAttrib = new MenuAttribute(Regex.Replace(property.Name, "(\\B[A-Z])", " $1")); //fix camel case

                if (menuAttrib != null)
                {
                    BaseSettingsDrawer drawer = null;
                    var drawerId = menuAttrib.index == -1 ? GetUniqDrawerId() : menuAttrib.index;

                    if (DrawersIds.Contains(drawerId))
                    {
                        BasePlugin.LogError($"{PluginName}: Already contain settings child with id {menuAttrib.parentIndex}. " +
                                            $"Fixed by giving a new uniq ID. Property: {property.Name}", 5);
                    }

                    var propType = property.PropertyType;

                    if (propType == typeof(ButtonNode) || propType.IsSubclassOf(typeof(ButtonNode)))
                        drawer = new ButtonSettingDrawer(property.GetValue(Settings) as ButtonNode, menuAttrib.MenuName, drawerId);
                    else if (propType == typeof(TextNode) || propType.IsSubclassOf(typeof(TextNode)))
                        drawer = new TextSettingsDrawer(property.GetValue(Settings) as TextNode, menuAttrib.MenuName, drawerId);
                    else if (propType == typeof(EmptyNode) || propType.IsSubclassOf(typeof(EmptyNode)))
                        drawer = new LabelSettingDrawer(menuAttrib.MenuName, drawerId);
                    else if (propType == typeof(HotkeyNode) || propType.IsSubclassOf(typeof(HotkeyNode)))
                        drawer = new HotkeySettingDrawer(property.GetValue(Settings) as HotkeyNode, menuAttrib.MenuName, drawerId);
                    else if (propType == typeof(ToggleNode) || propType.IsSubclassOf(typeof(ToggleNode)))
                        drawer = new CheckboxSettingDrawer(property.GetValue(Settings) as ToggleNode, menuAttrib.MenuName, drawerId);
                    else if (propType == typeof(ColorNode) || propType.IsSubclassOf(typeof(ColorNode)))
                        drawer = new ColorSettingDrawer(property.GetValue(Settings) as ColorNode, menuAttrib.MenuName, drawerId);
                    else if (propType == typeof(ListNode) || propType.IsSubclassOf(typeof(ListNode)))
                        drawer = new ComboBoxSettingDrawer(property.GetValue(Settings) as ListNode, menuAttrib.MenuName, drawerId);
                    else if (propType == typeof(FileNode) || propType.IsSubclassOf(typeof(FileNode)))
                        drawer = new FilePickerDrawer(property.GetValue(Settings) as FileNode, menuAttrib.MenuName, drawerId);
                    else if (propType == typeof(StashTabNode) || propType.IsSubclassOf(typeof(StashTabNode)))
                    {
                        var stashNode = property.GetValue(Settings) as StashTabNode;
                        _stashTabNodesToUnload.Add(stashNode);
                        StashTabController.RegisterStashNode(stashNode);
                        drawer = new StashTabNodeSettingDrawer(stashNode, menuAttrib.MenuName, drawerId);
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
                                var valueDrawer = new CustomSettingsDrawer(menuAttrib.MenuName, drawerId);

                                if (argType == typeof(int))
                                {
                                    var rangeInt = property.GetValue(Settings) as RangeNode<int>;

                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = ImGuiExtension.IntSlider(valueDrawer.ImguiUniqLabel, rangeInt.Value, rangeInt.Min,
                                            rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(float))
                                {
                                    var rangeInt = property.GetValue(Settings) as RangeNode<float>;

                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = ImGuiExtension.FloatSlider(valueDrawer.ImguiUniqLabel, rangeInt.Value, rangeInt.Min,
                                            rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(double))
                                {
                                    var rangeInt = property.GetValue(Settings) as RangeNode<double>;

                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = ImGuiExtension.FloatSlider(valueDrawer.ImguiUniqLabel, (float) rangeInt.Value,
                                            (float) rangeInt.Min, (float) rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(byte))
                                {
                                    var rangeInt = property.GetValue(Settings) as RangeNode<byte>;

                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = (byte) ImGuiExtension.IntSlider(valueDrawer.ImguiUniqLabel, rangeInt.Value, rangeInt.Min,
                                            rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(long))
                                {
                                    var rangeInt = property.GetValue(Settings) as RangeNode<long>;

                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = ImGuiExtension.IntSlider(valueDrawer.ImguiUniqLabel, (int) rangeInt.Value,
                                            (int) rangeInt.Min, (int) rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(short))
                                {
                                    var rangeInt = property.GetValue(Settings) as RangeNode<short>;

                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = (short) ImGuiExtension.IntSlider(valueDrawer.ImguiUniqLabel, rangeInt.Value,
                                            rangeInt.Min, rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(ushort))
                                {
                                    var rangeInt = property.GetValue(Settings) as RangeNode<ushort>;

                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        rangeInt.Value = (ushort) ImGuiExtension.IntSlider(valueDrawer.ImguiUniqLabel, rangeInt.Value,
                                            rangeInt.Min, rangeInt.Max);
                                    };
                                }
                                else if (argType == typeof(ImGuiVector2))
                                {
                                    var vect = property.GetValue(Settings) as RangeNode<ImGuiVector2>;

                                    valueDrawer.DrawDelegate = delegate
                                    {
                                        var val = vect.Value;
                                        ImGui.SliderVector2(valueDrawer.ImguiUniqLabel, ref val, vect.Min.X, vect.Max.X, "%.0f", 1);
                                        vect.Value = val;
                                    };
                                }
                                else
                                {
                                    BasePlugin.LogError(
                                        $"{PluginName}: Generic node argument for range node '{argType.Name}' is not defined in code. Range node type: " +
                                        propType.Name, 5);
                                }

                                drawer = valueDrawer;
                            }
                            else
                                BasePlugin.LogError($"{PluginName}: Can't get GenericTypeArguments from option type: {propType.Name}", 5);
                        }
                        else
                            BasePlugin.LogError($"{PluginName}: Generic option node is not defined in code: {genericType.Name}", 5);
                    }
                    else
                        BasePlugin.LogError($"{PluginName}: Type of option node is not defined: {propType.Name}", 5);

                    if (drawer != null)
                    {
                        drawer.SettingTooltip = menuAttrib.Tooltip;

                        if (menuAttrib.parentIndex != -1)
                        {
                            var parent = GetAllDrawers().Find(x => x.SettingId == menuAttrib.parentIndex);

                            if (parent != null)
                            {
                                parent.Children.Add(drawer);
                                continue;
                            }

                            BasePlugin.LogError(
                                $"{PluginName}: Can't find child with id {menuAttrib.parentIndex} to parent node. Property {property.Name}", 5);
                        }

                        SettingPropertyDrawers.Add(drawer);
                    }
                    else
                        BasePlugin.LogError($"{PluginName}: Type of option node is not defined: {propType.Name}", 5);
                }
            }
        }

        public override string ToString()
        {
            return PluginName;
        }
    }
}
