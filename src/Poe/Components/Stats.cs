namespace PoeHUD.Poe.Components
{
    public class Stats : Component
    {
        public int coldResistance => M.ReadInt(Address + 0x50, 0x154);
        public int fireResistance => M.ReadInt(Address + 0x50, 0x15C);
        public int lightningResistance => M.ReadInt(Address + 0x50, 0x164);
        public int chaosResistance => M.ReadInt(Address + 0x50, 0x16C);
    }
}
