using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PoeHUD.Hud.Settings.Converters
{
    public class ToggleNodeConverter : CustomCreationConverter<ToggleNode>
    {
        public override bool CanWrite => true;
        public override bool CanRead => true;

        public override ToggleNode Create(Type objectType)
        {
            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return new ToggleNode(serializer.Deserialize<bool>(reader));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var toggleNode = value as ToggleNode;
            serializer.Serialize(writer, toggleNode != null && toggleNode.Value);
        }
    }
}