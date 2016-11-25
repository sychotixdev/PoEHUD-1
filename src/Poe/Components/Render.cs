using SharpDX;

namespace PoeHUD.Poe.Components
{
    public class Render : Component
    {
        public float X => Address != 0 ? M.ReadFloat(Address + 0x7C) : 0f;
        public float Y => Address != 0 ? M.ReadFloat(Address + 0x80) : 0f;
        public float Z => Address != 0 ? M.ReadFloat(Address + 0xCC) : 0f;
        public Vector3 Pos => new Vector3(X, Y, Z);

        public string DisplayName
        {
            get
            {
                if (Address == 0)
                {
                    return "";
                }
                int num = M.ReadInt(Address + 0xA0);
                return num < 8 ? M.ReadStringU(Address + 0x90, 0x10) : M.ReadStringU(M.ReadInt(Address + 0x90));
            }
        }
    }
}