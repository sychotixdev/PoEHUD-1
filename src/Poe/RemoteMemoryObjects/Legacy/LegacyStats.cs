using System;

namespace PoeHUD.Poe.RemoteMemoryObjects.Legacy
{
    [Obsolete]
    public class LegacyStats : RemoteMemoryObject
    {
        public int this[int stat]
        {
            get
            {
                if (Address == 0)
                {
                    return -1;
                }
                int result;
                if (GetStat(stat, out result))
                {
                    return result;
                }
                return -1;
            }
        }

        private bool GetStat(int stat, out int result)
        {
            int num = M.ReadInt(Address + 16);
            int num2 = M.ReadInt(num + 16);
            int i = M.ReadInt(num + 20) - num2 >> 3;
            while (i > 0)
            {
                int num3 = i / 2;
                if (M.ReadInt(num2 + 8 * num3) >= stat)
                {
                    i /= 2;
                }
                else
                {
                    num2 += 8 * num3 + 8;
                    i += -1 - num3;
                }
            }
            if (M.ReadInt(num + 20) != num2 && M.ReadInt(num2) == stat)
            {
                result = M.ReadInt(num2 + 4);
                return true;
            }
            if (M.ReadInt(num + 8) != 0 && GetStat2(stat, out result))
            {
                return true;
            }
            result = 0;
            return false;
        }

        private bool GetStat2(int stat, out int res)
        {
            int num = M.ReadInt(Address + 16, 8);
            int num2;
            while (true)
            {
                num2 = M.ReadInt(num + 36);
                int i = (M.ReadInt(num + 40) - num2) / 28;
                while (i > 0)
                {
                    int num3 = i / 2;
                    if (M.ReadInt(num2 + 28 * num3) >= stat)
                    {
                        i /= 2;
                    }
                    else
                    {
                        num2 += 28 * num3 + 28;
                        i += -1 - num3;
                    }
                }
                if (M.ReadInt(num2) == stat)
                {
                    break;
                }
                num = M.ReadInt(num + 12);
                if (num == 0)
                {
                    goto Block_4;
                }
            }
            res = M.ReadInt(num2 + 4);
            return true;
        Block_4:
            res = 0;
            return false;
        }
    }
}