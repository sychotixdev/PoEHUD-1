using SharpDX;

namespace PoeHUD.Poe.Components
{
    using Models.Attributes;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit)]
    public struct PositionedStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x20)]
        public int GridX;
        [FieldOffset(0x24)]
        public int GridY;
        [FieldOffset(0x2c)]
        public float WorldX;
        [FieldOffset(0x30)]
        public float WorldY;
        [FieldOffset(0x39)]
        public byte Reaction;
        [FieldOffset(0x100)]
        public float Rotation;
    }

    public class Positioned : StructuredRemoteMemoryObject<PositionedStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public int GridX => Address != 0 ? Structure.GridX : 0;
        public int GridY => Address != 0 ? Structure.GridY : 0;
        public Vector2 GridPos => new Vector2(GridX, GridY);
   
        public float WorldX => Structure.WorldX;
        public float WorldY => Structure.WorldY;
        public Vector2 WorldPos => new Vector2(WorldX, WorldY);

        public float Rotation => Structure.Rotation;
        public float RotationDeg => Rotation * (180 / MathUtil.Pi);

        public byte Reaction => Structure.Reaction;
    }
}