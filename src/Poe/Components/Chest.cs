namespace PoeHUD.Poe.Components
{
    public class Chest : Component
    {
        public bool IsOpened => Address != 0 && M.ReadByte(Address + 0x24) == 1;
        public bool IsStrongbox => Address != 0 && M.ReadInt(Address + 0x3C) != 0;
    }
}