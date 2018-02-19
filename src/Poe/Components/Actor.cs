using System.Collections.Generic;
using System;

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

        public ActionFlags Action => Address != 0 ? (ActionFlags)M.ReadInt(Address + 0xD8) : ActionFlags.None;

        public bool isMoving => (ActionId & 128) > 0;

        public bool isAttacking => (ActionId & 2) > 0;

        public List<int> Minions
        {
            get
            {
                var list = new List<int>();
                if (Address == 0)
                {
                    return list;
                }
                long num = M.ReadLong(Address + 0x310);
                long num2 = M.ReadLong(Address + 0x318);
                for (long i = num; i < num2; i += 8)
                {
                    // using int instead of long because first 4 bytes are id
                    // second 4 bytes are wierd number which depend on socket number/location.
                    int item = M.ReadInt(i);
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
            long num = M.ReadLong(Address + 0x308);
            long num2 = M.ReadLong(Address + 0x310);
            for (long i = num; i < num2; i += 8)
            {
                int num3 = M.ReadInt(i);
                if (num3 == (int)(entity.Id >> 32))
                {
                    return true;
                }
            }
            return false;
        }

        [Flags]
        public enum ActionFlags
        {
            None = 0,
            UsingAbility = 2,
            AbilityCooldownActive = 16,
            Dead = 64,
            Moving = 128,
            WashedUpState = 256,
            LocalPlayer = 2048
        }
    }
}
