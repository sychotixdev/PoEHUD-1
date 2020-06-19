using PoeHUD.Hud;
using SharpDX;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Components
{
    public class Render : Component
    {
        private RenderRMO RenderStructure => GetObject<RenderRMO>(Address);
        public float X => Address != 0 ? RenderStructure.X : 0f;
        public float Y => Address != 0 ? RenderStructure.Y : 0f;
        public float Z => Address != 0 ? RenderStructure.Z : 0f;
        public Vector3 Pos => new Vector3(X, Y, Z);

        public string Name => GetObject<NativeStringReader>(Address + 0xA0).Text;
        public Vector3 Bounds => new Vector3(RenderStructure.BoundX, RenderStructure.BoundY, RenderStructure.BoundZ);

    }

    public class RenderRMO : StructuredRemoteMemoryObject<EnumOffsets.Render>
    {
        public float X => Structure.x;
        public float Y => Structure.y;
        public float Z => Structure.z;
        public float BoundX => Structure.boundX;
        public float BoundY => Structure.boundY;
        public float BoundZ => Structure.boundZ;
        public long Name => (long)Structure.name;
    }
}
