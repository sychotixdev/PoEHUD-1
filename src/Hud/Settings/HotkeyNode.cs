using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PoeHUD.Hud.Settings
{
    public class HotkeyNode
    {
        [JsonIgnore]
        public Action OnValueChanged;
        private Keys value;

        public HotkeyNode()
        {
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
                    OnValueChanged?.Invoke();
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
