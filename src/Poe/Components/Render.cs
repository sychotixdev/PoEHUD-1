using SharpDX;

namespace PoeHUD.Poe.Components
{
    public class Render : Component
    {
        public float X => Address != 0 ? M.ReadFloat(Address + 0x70) : 0f;
        public float Y => Address != 0 ? M.ReadFloat(Address + 0x74) : 0f;
        public float Z => Address != 0 ? M.ReadFloat(Address + 0xCC) : 0f;
        public Vector3 Pos => new Vector3(X, Y, Z);
    }
}