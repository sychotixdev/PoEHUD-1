using System;
using Newtonsoft.Json;

namespace PoeHUD.Hud.Settings
{
    public sealed class ToggleNode
    {
        [JsonIgnore]
        public Action OnValueChanged = delegate { };
        private bool value;

        public ToggleNode()
        {
        }

        public ToggleNode(bool value)
        {
            Value = value;
        }

        public void SetValueNoEvent(bool newValue)
        {
            value = newValue;
        }

        public bool Value
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
                    catch (Exception)
                    {
                        DebugPlugin.DebugPlugin.LogMsg("Error in function that subscribed for: ToggleNode.OnValueChanged", 10, SharpDX.Color.Red);
                    }
                }
            }
        }

        public static implicit operator bool(ToggleNode node)
        {
            return node.Value;
        }

        public static implicit operator ToggleNode(bool value)
        {
            return new ToggleNode(value);
        }
    }
}