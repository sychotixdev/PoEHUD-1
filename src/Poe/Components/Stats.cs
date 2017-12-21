using PoeHUD.Models.Enums;

namespace PoeHUD.Poe.Components
{
    public class Stats : Component
    {
        public bool getStat(PlayerStats key, out int value)
        {
            long ptrStart = M.ReadLong(Address + 0x50);
            long ptrEnd = M.ReadLong(Address + 0x58);
            for (long i = ptrStart; i < ptrEnd; i+=8)
            {
                if (M.ReadInt(i) == (int)key)
                {
                    value = M.ReadInt(i + 0x04);
                    return true;
                }
            }
            value = 0;
            return false;
        }
    }
}
