using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Hud.UI;
using PoeHUD.Hud.Settings;
using ImGuiNET;

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


    public class BaseSettingsCustomDrawer: BaseSettingsDrawer
    {
        public Action DrawDelegate = delegate { ImGuiExtension.Label($"Not implemented in code"); };

        public override void Draw()
        {
            DrawDelegate();
        }
    }
}