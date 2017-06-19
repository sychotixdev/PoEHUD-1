using System;
using Newtonsoft.Json;

namespace PoeHUD.Hud.Settings
{
    public class ButtonNode
    {
        [JsonIgnore]
        public Action OnPressed = delegate { };

        public ButtonNode()
        {
        }
    }
}