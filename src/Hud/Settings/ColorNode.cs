using SharpDX;

namespace PoeHUD.Hud.Settings
{
    public sealed class ColorNode
    {
        public ColorNode() {}

        public ColorNode(uint color)
        {
            Value = Color.FromAbgr(color);
        }

        public ColorNode(Color color)
        {
            Value = color;
        }

        public Color Value { get; set; }

        public static implicit operator Color(ColorNode node)
        {
            return node.Value;
        }

        public static implicit operator ColorNode(uint value)
        {
            return new ColorNode(value);
        }

        public static implicit operator ColorNode(Color value)
        {
            return new ColorNode(value);
        }

        public static implicit operator ColorNode(ColorBGRA value)
        {
            return new ColorNode(value);
        }
    }
}