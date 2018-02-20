using System;
using System.Collections.Generic;
using PoeHUD.Models.Enums;

namespace PoeHUD.Poe.Components
{
    public class Stats : Component
    {
        public long statPtrStart => M.ReadLong(Address + 0x50);
        public long statPtrEnd => M.ReadLong(Address + 0x58);

        public Dictionary<PlayerStats, int> StatDictionary => GetStats();

        //Stats goes as sequence of 2 values, 4 byte each. First goes stat ID then goes stat value
        public Dictionary<PlayerStats, int> GetStats()
        {
            int key = 0;
            int value = 0;
            int total_stats = (int)(statPtrEnd - statPtrStart);
            var bytes = M.ReadBytes(statPtrStart, total_stats);
            var result = new Dictionary<PlayerStats, int>(total_stats/8);
            for (int i = 0; i < bytes.Length; i += 8)
            {
                key = BitConverter.ToInt32(bytes, i);
                value = BitConverter.ToInt32(bytes, i + 0x04);
                result[(PlayerStats)key] = value;
            }
            return result;
        }
    }
}
