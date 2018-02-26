using SharpDX;

namespace PoeHUD.Poe.Components
{
    public class Positioned : Component
    {
        public int GridX => Address != 0 ? M.ReadInt(Address + 0x20) : 0;
        public int GridY => Address != 0 ? M.ReadInt(Address + 0x24) : 0;
        public Vector2 GridPos => new Vector2(GridX, GridY);
        public Vector2 WorldPos => new Vector2(WorldX, WorldY);

        public float Rotation => M.ReadFloat(Address + 0xf8);
        public float WorldX => M.ReadFloat(Address + 0x2c);
        public float WorldY => M.ReadFloat(Address + 0x30);

        // Use these from Render Component, they also contain Z axis.
        //public float X => Address != 0 ? M.ReadFloat(Address + 0x2c) : 0f;
        //public float Y => Address != 0 ? M.ReadFloat(Address + 0x30) : 0f;
    }
}