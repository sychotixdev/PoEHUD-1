namespace PoeHUD.Hud.Settings
{
    public sealed class RangeNode<T> where T : struct
    {
        public RangeNode()
        {
        }

        public RangeNode(T value, T min, T max)
        {
            Value = value;
            Min = min;
            Max = max;
        }

        public T Value { get; set; }
        public T Min { get; set; }
        public T Max { get; set; }

        public static implicit operator T(RangeNode<T> node)
        {
            return node.Value;
        }
    }
}