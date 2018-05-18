namespace PoeHUD.Poe.Components
{
    public class NPC : Component
    {
        public bool HasIconOverhead => M.ReadLong(Address + 0x48) != 0;
        public bool IsIgnoreHidden => M.ReadByte(Address + 0x20) == 1;
        public bool IsMinimapLabelVisible => M.ReadByte(Address + 0x21) == 1;
    }
}