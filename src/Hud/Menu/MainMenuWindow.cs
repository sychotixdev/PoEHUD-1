using System;
using SharpDX.Direct3D9;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.Settings;
using PoeHUD.Models.Enums;
using PoeHUD.Plugins;
using PoeHUD.Poe;
using PoeHUD.Models;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.Elements;
using PoeHUD.Poe.EntityComponents;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Poe.FilesInMemory;
using System.Windows.Forms;
using ImGuiNET;
using ImGuiVector2 = System.Numerics.Vector2;
using ImGuiVector4 = System.Numerics.Vector4;
using Vector2 = System.Numerics.Vector2;
using PoeHUD.Hud.PluginExtension;
using PoeHUD.Controllers;
using PoeHUD.Hud.UI;
using PoeHUD.Hud.Themes;

namespace PoeHUD.Hud
{
    public class MainMenuWindow
    {
        private string CurrentSelected = "";
        private int CurrentSelectedInt = 0;
        private ImGuiVector2 newcontentRegionArea;
        private BaseExternalPlugin SelectedPlugin;
        private float PluginNameWidth = 100;

        private InbuildPluginMenu CoreMenu;
        public static CoreSettings Settings;
        private readonly SettingsHub SettingsHub;

        public MainMenuWindow(CoreSettings settings, SettingsHub settingsHub)
        {
            Settings = settings;
            SettingsHub = settingsHub;

            if (Settings.MenuWindowSize == ImGuiVector2.Zero)
            {
                Settings.MenuWindowSize = new ImGuiVector2(500, 800);
                Settings.MenuWindowPos.X = GameController.Instance.Window.GetWindowRectangle().X - Settings.MenuWindowSize.X / 2;
            }

            CoreMenu = new InbuildPluginMenu() { Plugin = new BaseExternalPlugin("Core", settingsHub.MenuSettings) };
            CoreMenu.Childs.Add(new InbuildPluginMenu()
            {
                Plugin = new BaseExternalPlugin("Health bars", settingsHub.HealthBarSettings),
                Childs = new List<InbuildPluginMenu>()
                {
                    new InbuildPluginMenu(){ Plugin = new BaseExternalPlugin("Players", settingsHub.HealthBarSettings.Players) },
                    new InbuildPluginMenu(){ Plugin =  new BaseExternalPlugin("Minions", settingsHub.HealthBarSettings.Minions) },
                    new InbuildPluginMenu(){ Plugin =  new BaseExternalPlugin("NormalEnemy", settingsHub.HealthBarSettings.NormalEnemy) },
                    new InbuildPluginMenu(){ Plugin = new BaseExternalPlugin("MagicEnemy", settingsHub.HealthBarSettings.MagicEnemy) },
                    new InbuildPluginMenu(){ Plugin = new BaseExternalPlugin("RareEnemy", settingsHub.HealthBarSettings.RareEnemy) },
                    new InbuildPluginMenu(){ Plugin = new BaseExternalPlugin("UniqueEnemy", settingsHub.HealthBarSettings.UniqueEnemy) },
                }
            });

            CoreMenu.Childs.Add(new InbuildPluginMenu()
            {
                Plugin = new BaseExternalPlugin("Advanced Tooltip", settingsHub.AdvancedTooltipSettings),
                Childs = new List<InbuildPluginMenu>()
                {
                    new InbuildPluginMenu(){ Plugin = new BaseExternalPlugin("Item level", settingsHub.AdvancedTooltipSettings.ItemLevel) },
                    new InbuildPluginMenu(){ Plugin = new BaseExternalPlugin("Item mods", settingsHub.AdvancedTooltipSettings.ItemMods) },
                    new InbuildPluginMenu(){ Plugin = new BaseExternalPlugin("Weapon Dps", settingsHub.AdvancedTooltipSettings.WeaponDps) },
                }
            });

            CoreMenu.Childs.Add(new InbuildPluginMenu()
            {
                Plugin = new BaseExternalPlugin("Item alert", settingsHub.ItemAlertSettings),
                Childs = new List<InbuildPluginMenu>()
                {
                    new InbuildPluginMenu(){ Plugin = new BaseExternalPlugin("Border Settings", settingsHub.ItemAlertSettings.BorderSettings) },
                    new InbuildPluginMenu(){ Plugin = new BaseExternalPlugin("Quality Armour Settings", settingsHub.ItemAlertSettings.QualityItems.Armour)},
                    new InbuildPluginMenu(){ Plugin = new BaseExternalPlugin("Quality Flask", settingsHub.ItemAlertSettings.QualityItems.Flask) },
                    new InbuildPluginMenu(){ Plugin = new BaseExternalPlugin("Quality SkillGem", settingsHub.ItemAlertSettings.QualityItems.SkillGem) },
                    new InbuildPluginMenu(){ Plugin = new BaseExternalPlugin("Quality Weapon", settingsHub.ItemAlertSettings.QualityItems.Weapon) }
                }
            });

            CoreMenu.Childs.Add(new InbuildPluginMenu() { Plugin = new BaseExternalPlugin("Xph & area", settingsHub.XpRateSettings) });
            CoreMenu.Childs.Add(new InbuildPluginMenu() { Plugin = new BaseExternalPlugin("Preload alert", settingsHub.PreloadAlertSettings) });
            CoreMenu.Childs.Add(new InbuildPluginMenu() { Plugin = new BaseExternalPlugin("Monster alert", settingsHub.MonsterTrackerSettings) });
            CoreMenu.Childs.Add(new InbuildPluginMenu() { Plugin = new BaseExternalPlugin("Monster kills", settingsHub.KillCounterSettings) });
            CoreMenu.Childs.Add(new InbuildPluginMenu() { Plugin = new BaseExternalPlugin("Show dps", settingsHub.DpsMeterSettings) });
            CoreMenu.Childs.Add(new InbuildPluginMenu() { Plugin = new BaseExternalPlugin("Map Icons", settingsHub.MapIconsSettings) });
            CoreMenu.Childs.Add(new InbuildPluginMenu() { Plugin = new BaseExternalPlugin("Perfomance", settingsHub.PerformanceSettings) });


        
            var themeEditorDraw = new ThemeEditor();
            themeEditorDraw.CanBeDisabled = false;
            CoreMenu.Childs.Add(new InbuildPluginMenu() { Plugin = themeEditorDraw });
        }

 
        private class InbuildPluginMenu
        {
            public BaseExternalPlugin Plugin;
            public List<InbuildPluginMenu> Childs = new List<InbuildPluginMenu>();
        }

        
        public void Render()
        {
            if (!Settings.Enable.Value) return;

            var opened = Settings.Enable.Value;
            Settings.IsCollapsed = !DrawInfoWindow("PoeHUD", ref opened,
                Settings.MenuWindowPos.X, Settings.MenuWindowPos.Y, Settings.MenuWindowSize.X, Settings.MenuWindowSize.Y,
                 WindowFlags.Default, Condition.Appearing);
            Settings.Enable.Value = opened;

            if (!Settings.IsCollapsed)
            {
                ImGuiNative.igGetContentRegionAvail(out newcontentRegionArea);
                if (ImGui.BeginChild("PluginsList", new Vector2(PluginNameWidth + 60, newcontentRegionArea.Y), true, WindowFlags.Default))
                {
                    PluginNameWidth = 120;
                    var coreOpened = ImGui.TreeNodeEx("", Settings.CorePluginsTreeState);

                    ImGui.SameLine();
                    if (ImGui.Selectable(CoreMenu.Plugin.PluginName, SelectedPlugin == CoreMenu.Plugin))
                        SelectedPlugin = CoreMenu.Plugin;

                    if (coreOpened)
                    {
                        foreach (var defPlugin in CoreMenu.Childs)
                        {
                            if (defPlugin.Childs.Count == 0)
                            {
                                DrawPlugin(defPlugin.Plugin, 20);
                            }
                            else 
                            {
                                defPlugin.Plugin.Settings.Enable = 
                                    ImGuiExtension.Checkbox($"##{defPlugin.Plugin.PluginName}Enabled", defPlugin.Plugin.Settings.Enable.Value);

                                ImGui.SameLine();
                                var pluginOpened = ImGui.TreeNodeEx($"##{defPlugin.Plugin.PluginName}", TreeNodeFlags.OpenOnArrow);
                                ImGui.SameLine();

                                var labelSize = ImGui.GetTextSize(defPlugin.Plugin.PluginName).X + 30;
                                if (PluginNameWidth < labelSize)
                                    PluginNameWidth = labelSize;

                                if (ImGui.Selectable(defPlugin.Plugin.PluginName, SelectedPlugin == defPlugin.Plugin))
                                    SelectedPlugin = defPlugin.Plugin;

                                if (pluginOpened)
                                {
                                    foreach (var plugin in defPlugin.Childs)
                                        DrawPlugin(plugin.Plugin, 30);

                                    ImGuiNative.igUnindent();
                                }
                            }
                        }
                        ImGui.TreePop();
                        Settings.CorePluginsTreeState = TreeNodeFlags.DefaultOpen | TreeNodeFlags.OpenOnArrow;

                        ImGui.Text("");
                    }
                    else
                    {
                        Settings.CorePluginsTreeState = TreeNodeFlags.OpenOnArrow;
                    }             
                 
                    if (ImGui.TreeNodeEx("Installed Plugins", Settings.InstalledPluginsTreeNode))
                    {
                        foreach (var plugin in PluginExtensionPlugin.Plugins)
                        {
                            DrawPlugin(plugin, 20);
                        }

                        ImGui.TreePop();
                        Settings.InstalledPluginsTreeNode = TreeNodeFlags.DefaultOpen;
                    }
                    else
                    {
                        Settings.InstalledPluginsTreeNode = (TreeNodeFlags)0;
                    }
                }

                ImGui.EndChild();
                ImGui.SameLine();


                if (SelectedPlugin != null)
                {
                    ImGuiNative.igGetContentRegionAvail(out newcontentRegionArea);
                    ImGui.BeginChild("PluginOptions", new Vector2(newcontentRegionArea.X, newcontentRegionArea.Y), true, WindowFlags.Default);

                    var extPlugin = SelectedPlugin as ExternalPlugin;
                    if (Settings.DeveloperMode.Value && extPlugin != null)
                    {
                        if (ImGuiExtension.Button("Reload Plugin"))
                            extPlugin.ReloadPlugin();
                    }
                    SelectedPlugin.DrawSettingsMenu();

                    ImGui.EndChild();
                }

                Settings.MenuWindowSize = ImGui.GetWindowSize();
            }

            Settings.MenuWindowPos = ImGui.GetWindowPosition(); 
            ImGui.EndWindow();

            if (Settings.ShowImguiDemo.Value)
            {
                bool tmp = Settings.ShowImguiDemo.Value;
                ImGuiNative.igShowDemoWindow(ref tmp);
                Settings.ShowImguiDemo.Value = tmp;
            }

        }

        private void DrawPlugin(BaseExternalPlugin plugin, float offsetX)
        {
            if (plugin.CanBeDisabled)//for theme plugin
            {
                plugin.Settings.Enable = ImGuiExtension.Checkbox($"##{plugin.PluginName}Enabled", plugin.Settings.Enable.Value);
                ImGui.SameLine();
            }

            var labelSize = ImGui.GetTextSize(plugin.PluginName).X + offsetX;
            if (PluginNameWidth < labelSize)
                PluginNameWidth = labelSize;

            if (ImGui.Selectable(plugin.PluginName, SelectedPlugin == plugin))
                SelectedPlugin = plugin;
        }

        public bool DrawInfoWindow(string windowLabel, ref bool isOpened, float x, float y, float width, float height, WindowFlags flags, Condition conditions)
        {
            ImGui.SetNextWindowPos(new ImGuiVector2(width + x, height + y), conditions, new ImGuiVector2(1, 1));
            ImGui.SetNextWindowSize(new ImGuiVector2(width, height), conditions);
            ImGuiNative.igSetNextWindowCollapsed(Settings.IsCollapsed, Condition.Appearing);
            return ImGui.BeginWindow(windowLabel, ref isOpened, flags);
        }
    }
}
