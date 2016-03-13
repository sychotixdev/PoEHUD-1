namespace PoeHUD.Poe.Components
{
    public class Player : Component
    {
        public string PlayerName
        {
            get
            {
                if (Address == 0)
                {
                    return "";
                }
                int NameLength = M.ReadInt(Address + 0x20);
                if (NameLength > 512)
                {
                    return "";
                }
                return NameLength < 8 ? M.ReadStringU(Address + 0x10, NameLength * 2) : M.ReadStringU(M.ReadInt(Address + 0x10), NameLength * 2);
            }
        }

        public long XP => Address != 0 ? M.ReadUInt(Address + 0x30) : 0L;
        public int Level => Address != 0 ? M.ReadInt(Address + 0x40) : 1;
    }
}