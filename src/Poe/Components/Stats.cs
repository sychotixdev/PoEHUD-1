using System.Collections.Generic;
using PoeHUD.Models.Enums;

namespace PoeHUD.Poe.Components
{
    public class Stats : Component
    {
        public long statPtrStart => M.ReadLong(Address + 0x50);
        public long statPtrEnd => M.ReadLong(Address + 0x58);

        //Stats goes as sequence of 2 values, 4 byte each. First goes stat ID then goes stat value
        public Dictionary<PlayerStats, int> GetStats()
        {
            var result = new Dictionary<PlayerStats, int>();
            for(var addr = statPtrStart; addr < statPtrEnd; addr += 8)
            {
                var statId = M.ReadInt(addr);
                var statValue = M.ReadInt(addr + 4);

                result.Add((PlayerStats)statId, statValue);
            }
            return result;
        }
    }
}
