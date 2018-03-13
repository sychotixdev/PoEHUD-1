using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Hud.UI;
using PoeHUD.Hud.Settings;
using ImGuiNET;
using System.IO;
using Vector2 = System.Numerics.Vector2;

namespace PoeHUD.Hud.Menu.SettingsDrawers
{
    public abstract class BaseSettingsDrawer
    {
        internal int SettingId { get; set; }
        public string SettingName { get; set; }

        public Func<bool> IsVisible = delegate { return true; };

        internal string ImguiUniqLabel => $"{SettingName}##{SettingId}";

        public virtual void Draw() { }

        public readonly List<BaseSettingsDrawer> Children = new List<BaseSettingsDrawer>();
        internal float ChildHeight;
        internal float ChildLabelWidthMax;
    }

    //Label (EmptyNode)
    public class LabelSettingDrawer : BaseSettingsDrawer
    {
        public override void Draw() => ImGuiExtension.Label(SettingName);
    }

    //Button
    public class ButtonSettingDrawer : BaseSettingsDrawer
    {
        public ButtonNode Button;
        public ButtonSettingDrawer(ButtonNode button) => Button = button;

        public override void Draw()
        {
            if (ImGuiExtension.Button(ImguiUniqLabel)) Button.OnPressed();
        }
    }

    public class HotkeySettingDrawer : BaseSettingsDrawer
    {
        public HotkeyNode Hotkey;
        public HotkeySettingDrawer(HotkeyNode hotkey) => Hotkey = hotkey;

        public override void Draw()
        {
            var oldValue = ImGuiExtension.HotkeySelector(ImguiUniqLabel, Hotkey.Value);

            if (Hotkey.Value != oldValue)
            {
                Hotkey.Value = oldValue;
                try { Hotkey.OnValueChanged?.Invoke(); }
                catch (Exception ex) { DebugPlug.DebugPlugin.LogMsg("Error while invoking OnValueChanged in HotkeyNode", 5); }
            }
        }
    }

    public class CheckboxSettingDrawer : BaseSettingsDrawer
    {
        public ToggleNode Toggle;
        public CheckboxSettingDrawer(ToggleNode toggle) => Toggle = toggle;

        public override void Draw()
        {
            var oldValue = ImGuiExtension.Checkbox(ImguiUniqLabel, Toggle.Value);

            if (Toggle.Value != oldValue)
            {
                Toggle.Value = oldValue;
                try { Toggle.OnValueChanged?.Invoke(); }
                catch (Exception ex) { DebugPlug.DebugPlugin.LogMsg("Error while invoking OnValueChanged in ToggleNode", 5); }
            }
        }
    }

    public class ColorSettingDrawer : BaseSettingsDrawer
    {
        public ColorNode Color;
        public ColorSettingDrawer(ColorNode color) => Color = color;

        public override void Draw()
        {
            Color.Value = ImGuiExtension.ColorPicker(ImguiUniqLabel, Color.Value);
        }
    }


    public class StringListSettingDrawer : BaseSettingsDrawer
    {
        public ListNode List;
        public StringListSettingDrawer(ListNode list) => List = list;

        public override void Draw()
        {
            List.Value = ImGuiExtension.ComboBox(ImguiUniqLabel, List.Value, List.Values);
        }
    }


    public class BaseSettingsCustomDrawer : BaseSettingsDrawer
    {
        public Action DrawDelegate = delegate { ImGuiExtension.Label($"Not implemented in code"); };

        public override void Draw()
        {
            DrawDelegate();
        }
    }

    public class FilePickerDrawer : BaseSettingsDrawer
    {
        public FileNode FNode;
        public FilePickerDrawer(FileNode fNode)
        {
            FNode = fNode;
            var documentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            CurrentFolder = Path.Combine(documentsPath, @"My Games\Path of Exile");
            SelectedFile = FNode.Value;
        }
        
        public override void Draw()
        {
            if(ImGui.TreeNode(ImguiUniqLabel))
            {
                var selected = FNode.Value;
                if(DrawFolder(ref selected))
                {
                    FNode.Value = selected;
                }
            }
        }

        public string CurrentFolder { get; set; }
        public string SelectedFile { get; set; }
        private bool DrawFolder(ref string selected)
        {
            bool result = false;
            ImGui.Text("Current Folder: " + CurrentFolder);
            if (ImGui.BeginChildFrame(1, new Vector2(0, 300), WindowFlags.Default))
            {
                DirectoryInfo di = new DirectoryInfo(CurrentFolder);
                if (di.Exists)
                {
                    if (di.Parent != null)
                    {
                        ImGui.PushStyleColor(ColorTarget.Text, new System.Numerics.Vector4(1, 1, 0, 1));
                        if (ImGui.Selectable("../", false, SelectableFlags.DontClosePopups))
                        {
                            CurrentFolder = di.Parent.FullName;
                        }
                        ImGui.PopStyleColor();
                    }

                    foreach(var dict in di.GetDirectories())
                    {
                        ImGui.PushStyleColor(ColorTarget.Text, new System.Numerics.Vector4(1, 1, 0, 1));
                        if (ImGui.Selectable(dict.Name + "/", false, SelectableFlags.DontClosePopups))
                        {
                            CurrentFolder = dict.FullName;
                        }
                        ImGui.PopStyleColor();
                    }

                    foreach (var file in di.GetFiles("*.filter"))
                    {
                        bool isSelected = SelectedFile == file.FullName;
                        if (ImGui.Selectable(file.Name, isSelected, SelectableFlags.DontClosePopups))
                        {
                            selected = SelectedFile;
                            SelectedFile = file.FullName;
                            result = true;
                        }
                    }
                }
            }
            ImGui.EndChildFrame();
            return result;
        }
    }
}