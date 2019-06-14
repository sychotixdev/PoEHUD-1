using SharpDX;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Components
{
    public class Render : Component
    {
        public float X => Address != 0 ? M.ReadFloat(Address + 0x90) : 0f;
        public float Y => Address != 0 ? M.ReadFloat(Address + 0x94) : 0f;
        public float Z => Address != 0 ? M.ReadFloat(Address + 0x98) : 0f;
        public Vector3 Pos => new Vector3(X, Y, Z);

        public string Name => GetObject<NativeStringReader>(Address + 0xB0).Text;
        public Vector3 Bounds => new Vector3(M.ReadFloat(Address + 0x9C), M.ReadFloat(Address + 0xA0), M.ReadFloat(Address + 0xA4));
        public Vector3 MeshRoration => new Vector3(M.ReadFloat(Address + 0xD0), M.ReadFloat(Address + 0xD4), M.ReadFloat(Address + 0xD8));

        public float TerrainHeight => M.ReadFloat(Address + 0xEC);
    }
}
