using PoeHUD.Framework;
using System.Collections.Generic;

namespace PoeHUD.Poe
{
    public abstract class FileInMemory
    {
        protected FileInMemory(Memory m, int address)
        {
            M = m;
            Address = address;
        }

        public Memory M { get; }
        public int Address { get; }
        private int NumberOfRecords => M.ReadInt(Address + 0x30, 0x20);

        protected IEnumerable<int> RecordAddresses()
        {
            int firstRec = M.ReadInt(Address + 0x30, 0x4);
            int lastRec = M.ReadInt(Address + 0x30, 0x8);
            int cnt = NumberOfRecords;

            int recLen = (lastRec - firstRec) / cnt;
            for (int i = 0; i < cnt; i++)
                yield return firstRec + i * recLen;
        }
    }
}