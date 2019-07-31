namespace PoeHUD.Poe.Components
{
    public class Chest : Component
    {
        public bool IsOpened => Address != 0 && M.ReadByte(Address + 0x58) == 1;
        public bool IsStrongbox => Address != 0 && M.ReadLong(Address + 0x98) > 0;
    }
}