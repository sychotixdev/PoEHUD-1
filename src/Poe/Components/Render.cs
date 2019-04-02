using SharpDX;
using PoeHUD.Poe.RemoteMemoryObjects;
using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct RenderStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x78)]
        public float X;
        [FieldOffset(0x7C)]
        public float Y;
        [FieldOffset(0x80)]
        public float Z;
        [FieldOffset(0x84)]
        public float BoundsX;
        [FieldOffset(0x88)]
        public float BoundsY;
        [FieldOffset(0x8C)]
        public float BoundsZ;
        [FieldOffset(0x98)]
        public float NamePtr;
        [FieldOffset(0xB8)]
        public float MeshRotationX;
        [FieldOffset(0xBC)]
        public float MeshRotationY;
        [FieldOffset(0xC0)]
        public float MeshRotationZ;
        [FieldOffset(0xD4)]
        public float TerrainHeight;

    }

    public class Render : StructuredRemoteMemoryObject<RenderStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public float X => Address != 0 ? Structure.X : 0f;
        public float Y => Address != 0 ? Structure.Y : 0f;
        public float Z => Address != 0 ? Structure.Z : 0f;
        public Vector3 Pos => new Vector3(X, Y, Z);

        public string Name => GetObject<NativeStringReader>(Address + 0x98).Text;
        public Vector3 Bounds => new Vector3(Structure.BoundsX, Structure.BoundsY, Structure.BoundsZ);
        public Vector3 MeshRoration => new Vector3(Structure.MeshRotationX, Structure.MeshRotationY, Structure.MeshRotationZ);

        public float TerrainHeight => Structure.TerrainHeight;
    }
}
