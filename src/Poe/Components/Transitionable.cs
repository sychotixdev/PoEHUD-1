namespace PoeHUD.Poe.Components
{
    public class Transitionable : Component
    {
        public byte Flag1 => M.ReadByte(Address + 0x120);
        public byte Flag2 => M.ReadByte(Address + 0x124);
    }
}