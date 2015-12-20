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
                int num = M.ReadInt(Address + 0x20);
                if (num > 512)
                {
                    return "";
                }
                return num < 8 ? M.ReadStringU(Address + 0x10, num * 2) : M.ReadStringU(M.ReadInt(Address + 0x10), num * 2);
            }
        }

        public long XP => Address != 0 ? M.ReadUInt(Address + 0x34) : 0L;
        public int Level => Address != 0 ? M.ReadInt(Address + 0x44) : 1;
    }
}