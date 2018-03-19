using System;
using Newtonsoft.Json;
using PoeHUD.Hud.Menu;
using System.Collections.Generic;

namespace PoeHUD.Hud.Settings
{
    public class ListNode
    {
        [JsonIgnore]
        public Action<string> OnValueSelected = delegate { };
        [JsonIgnore]
        public Action<string> OnValueSelectedPre = delegate { };

        private string value;

        public ListNode()
        {
        }

        public string Value
        {
            get { return value; }
            set
            {
                if (this.value != value)
                {
                    try
                    {
                        OnValueSelectedPre(value);
                    }
                    catch
                    {
                        DebugPlug.DebugPlugin.LogMsg("Error in function that subscribed for: ListNode.OnValueSelectedPre", 10, SharpDX.Color.Red);
                    }

                    this.value = value;

                    try
                    {
                        OnValueSelected(value);
                    }
                    catch (Exception ex)
                    {
                        DebugPlug.DebugPlugin.LogMsg($"Error in function that subscribed for: ListNode.OnValueSelected. Error: {ex.Message}", 10, SharpDX.Color.Red);
                    }
                }
            }
        }

        public static implicit operator string(ListNode node)
        {
            return node.Value;
        }

        public List<string> Values = new List<string>();

        public void SetListValues(List<string> values)
        {
            Values = values;
        }
    }
}
