namespace PoeHUD.Poe.Components
{
    public class Chest : Component
    {
        public bool IsOpened => Address != 0 && M.ReadByte(Address + 0x40) == 1;
        public bool IsLocked => Address != 0 && M.ReadByte(Address + 0x41) > 1;
        public bool IsStrongbox => Address != 0 && M.ReadInt(Address + 0x60) > 0;

        public string SubStructAddr => M.ReadLong(Address + 0x20).ToString("x");

        public bool DestroyingAfterOpen => Address != 0 && M.ReadByte(Address + 0x20, 0x20) == 1;
        public bool IsLarge => Address != 0 && M.ReadByte(Address + 0x20, 0x21) == 1;
        public bool Stompable => Address != 0 && M.ReadByte(Address + 0x20, 0x22) == 1;
        public bool OpenOnDamage => Address != 0 && M.ReadByte(Address + 0x20, 0x25) == 1;
    }
}