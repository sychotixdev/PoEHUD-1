using System.Collections.Generic;

namespace PoeHUD.Poe.Components
{
    public class Actor : Component
    {
        /// <summary>
        ///     Standing still = 2048 =bit 11 set
        ///     running = 2178 = bit 11 & 7
        ///     Maybe Bit-field : Bit 7 set = running
        /// </summary>
        public int ActionId => Address != 0 ? M.ReadInt(Address + 0xD8) : 1;

        public bool isMoving => (ActionId & 128) > 0;

        public List<long> Minions
        {
            get
            {
                var list = new List<long>();
                if (Address == 0)
                {
                    return list;
                }
                long num = M.ReadLong(Address + 0x300);
                long num2 = M.ReadLong(Address + 0x308);
                for (long i = num; i < num2; i += 8)
                {
                    long item = M.ReadLong(i);
                    list.Add(item);
                }
                return list;
            }
        }

        public bool HasMinion(Entity entity)
        {
            if (Address == 0)
            {
                return false;
            }
            long num = M.ReadLong(Address + 0x300);
            long num2 = M.ReadLong(Address + 0x308);
            for (long i = num; i < num2; i += 8)
            {
                long num3 = M.ReadLong(i);
                if (num3 == entity.Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}