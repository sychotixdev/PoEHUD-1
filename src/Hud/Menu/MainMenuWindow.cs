using System;
//using SharpDX;
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

namespace PoeHUD.Hud
{
    public class MainMenuWindow
    {
        private string CurrentSelected = "";
        private int CurrentSelectedInt = 0;
        private ImGuiVector2 newcontentRegionArea;
        private ExternalPlugin SelectedPlugin;
        private float PluginNameWidth = 100;

        private Dictionary<string, List<ExternalPlugin>> InbuildPlugins = new Dictionary<string, List<ExternalPlugin>>();


        private readonly MenuSettings Settings;
        private readonly SettingsHub SettingsHub;

        public MainMenuWindow(MenuSettings settings, SettingsHub settingsHub)
        {
            Settings = settings;
            SettingsHub = settingsHub;

            if (Settings.MenuWindowSize == ImGuiVector2.Zero)
            {
                Settings.MenuWindowSize = new ImGuiVector2(500, 800);
                Settings.MenuWindowPos.X = GameController.Instance.Window.GetWindowRectangle().X - Settings.MenuWindowSize.X / 2;
            }

            InbuildPlugins.Add("Health bars", new List<ExternalPlugin>() {
                new ExternalPlugin("Main", settingsHub.HealthBarSettings),
                new ExternalPlugin("Players", settingsHub.HealthBarSettings.Players),
                new ExternalPlugin("Minions", settingsHub.HealthBarSettings.Minions),
                new ExternalPlugin("NormalEnemy", settingsHub.HealthBarSettings.NormalEnemy),
                new ExternalPlugin("MagicEnemy", settingsHub.HealthBarSettings.MagicEnemy),
                new ExternalPlugin("RareEnemy", settingsHub.HealthBarSettings.RareEnemy),
                new ExternalPlugin("UniqueEnemy", settingsHub.HealthBarSettings.UniqueEnemy),
            });


 
            InbuildPlugins.Add("Advanced Tooltip", new List<ExternalPlugin>() {
                //new ExternalPlugin("-", settingsHub.AdvancedTooltipSettings),
                new ExternalPlugin("Item level", settingsHub.AdvancedTooltipSettings.ItemLevel),
                new ExternalPlugin("Item mods", settingsHub.AdvancedTooltipSettings.ItemMods),
                new ExternalPlugin("Weapon Dps", settingsHub.AdvancedTooltipSettings.WeaponDps)
            });

            InbuildPlugins.Add("Item alert", new List<ExternalPlugin>()
            {
                new ExternalPlugin("Item alert", settingsHub.ItemAlertSettings),
                new ExternalPlugin("Border Settings", settingsHub.ItemAlertSettings.BorderSettings),
                new ExternalPlugin("Quality Armour Settings", settingsHub.ItemAlertSettings.QualityItems.Armour),
                new ExternalPlugin("Quality Flask", settingsHub.ItemAlertSettings.QualityItems.Flask),
                new ExternalPlugin("Quality SkillGem", settingsHub.ItemAlertSettings.QualityItems.SkillGem),
                new ExternalPlugin("Quality Weapon", settingsHub.ItemAlertSettings.QualityItems.Weapon),
            });

            InbuildPlugins.Add("Xph & area", new List<ExternalPlugin>() { new ExternalPlugin("Xph & area", settingsHub.XpRateSettings) });
            InbuildPlugins.Add("Preload alert", new List<ExternalPlugin>() { new ExternalPlugin("Preload alert", settingsHub.PreloadAlertSettings), });
            InbuildPlugins.Add("Monster alert", new List<ExternalPlugin>() { new ExternalPlugin("Preload alert", settingsHub.MonsterTrackerSettings), });
            InbuildPlugins.Add("Monster kills", new List<ExternalPlugin>() { new ExternalPlugin("Monster kills", settingsHub.KillCounterSettings), });
            InbuildPlugins.Add("Show dps", new List<ExternalPlugin>() { new ExternalPlugin("Monster kills", settingsHub.DpsMeterSettings), });
            InbuildPlugins.Add("Map Icons", new List<ExternalPlugin>() { new ExternalPlugin("Map Icons", settingsHub.MapIconsSettings), });
        }

        public void Render()
        {
            if (DrawInfoWindow("PoeHUD", ref Settings.IsOpened, Settings.MenuWindowPos.X, Settings.MenuWindowPos.Y, Settings.MenuWindowSize.X, Settings.MenuWindowSize.Y, WindowFlags.Default, Condition.Appearing))
            {
                ImGuiNative.igGetContentRegionAvail(out newcontentRegionArea);
                if (ImGui.BeginChild("PluginsList", new Vector2(PluginNameWidth + 60, newcontentRegionArea.Y), true, WindowFlags.Default))
                {
                    PluginNameWidth = 120;
  
                    if (ImGui.TreeNodeEx("Core Plugins", Settings.CorePluginsTreeState))
                    {
                        foreach (var defPlugin in InbuildPlugins)
                        {
                            if (defPlugin.Value.Count == 1)
                            {
                                DrawPlugin(defPlugin.Value[0], 20);
                            }
                            else if (ImGui.TreeNode($"{defPlugin.Key}"))
                            {
                                ImGuiNative.igIndent();
                                DrawPluginList(defPlugin.Value, 70);
                                ImGuiNative.igUnindent();
                                ImGui.TreePop();
                            }
                        }
                        ImGui.TreePop();
                        Settings.CorePluginsTreeState = TreeNodeFlags.DefaultOpen;

                        ImGui.Text("");
                    }
                    else
                    {
                        Settings.CorePluginsTreeState = (TreeNodeFlags)0;
                    }             
                 
                    if (ImGui.TreeNodeEx("Installed Plugins", Settings.InstalledPluginsTreeNode))
                    {
                        DrawPluginList(PluginExtensionPlugin.Plugins, 20);

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

                ImGuiNative.igGetContentRegionAvail(out newcontentRegionArea);
                if (ImGui.BeginChild("PluginOptions", new Vector2(newcontentRegionArea.X, newcontentRegionArea.Y), true, WindowFlags.Default))
                {
                    if(SelectedPlugin != null)
                    {
                        SelectedPlugin.DrawSettingsMenu();
                    }
                }
                ImGui.EndChild();

                Settings.MenuWindowSize = ImGui.GetWindowSize();
            }

            Settings.MenuWindowPos = ImGui.GetWindowPosition();
       
            ImGui.EndWindow();

        }

        private void DrawPluginList(List<ExternalPlugin> plugins, float offsetX)
        {
            foreach (var plugin in plugins)
            {
                DrawPlugin(plugin, offsetX);
            }
        }

        private void DrawPlugin(ExternalPlugin plugin, float offsetX)
        {
            plugin.Settings.Enable = ImGuiExtension.Checkbox($"##{plugin.PluginName}Enabled", plugin.Settings.Enable.Value);

            ImGui.SameLine();

            var labelSize = ImGui.GetTextSize(plugin.PluginName).X + offsetX;
            if (PluginNameWidth < labelSize)
                PluginNameWidth = labelSize;

            if (ImGui.Selectable(plugin.PluginName, SelectedPlugin == plugin))
                SelectedPlugin = plugin;
        }

        public static string ComboBox(string sideLabel, string currentSelectedItem, List<string> objectList, ComboFlags comboFlags = ComboFlags.HeightRegular)
        {
            if (ImGui.BeginCombo(sideLabel, currentSelectedItem, comboFlags))
            {
                var refObject = currentSelectedItem;
                for (var n = 0; n < objectList.Count; n++)
                {
                    var isSelected = refObject == objectList[n];
                    if (ImGui.Selectable(objectList[n], isSelected))
                    {
                        ImGui.EndCombo();
                        return objectList[n];
                    }

                    if (isSelected) ImGui.SetItemDefaultFocus();
                }

                ImGui.EndCombo();
            }

            return currentSelectedItem;
        }

        public bool DrawInfoWindow(string windowLabel, ref bool isOpened, float x, float y, float width, float height, WindowFlags flags, Condition conditions)
        {
            ImGui.SetNextWindowPos(new ImGuiVector2(width + x, height + y), conditions, new ImGuiVector2(1, 1));
            ImGui.SetNextWindowSize(new ImGuiVector2(width, height), conditions);
            return ImGui.BeginWindow(windowLabel, ref isOpened, flags);
        }
    }
}
