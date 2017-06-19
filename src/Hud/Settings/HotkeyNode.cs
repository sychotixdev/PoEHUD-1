using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PoeHUD.Hud.Settings
{
    public class HotkeyNode
    {
        [JsonIgnore]
        public Action OnValueChanged = delegate { };
        private Keys value;

        public HotkeyNode()
        {
            value = Keys.Space;
        }

        public HotkeyNode(Keys value)
        {
            Value = value;
        }

        public Keys Value
        {
            get { return value; }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                
                    try
                    {
                        OnValueChanged();
                    }
                    catch
                    {
                        DebugPlug.DebugPlugin.LogMsg("Error in function that subscribed for: HotkeyNode.OnValueChanged", 10, SharpDX.Color.Red);
                    }
                }
            }
        }

        public static implicit operator Keys(HotkeyNode node)
        {
            return node.Value;
        }

        public static implicit operator HotkeyNode(Keys value)
        {
            return new HotkeyNode(value);
        }
    }
}
