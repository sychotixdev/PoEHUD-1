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
        private int NumberOfRecords => M.ReadInt(Address + 0x44);

        protected IEnumerable<int> RecordAddresses()
        {
            int firstRec = M.ReadInt(Address + 0x34);
            int lastRec = M.ReadInt(Address + 0x38);
            int cnt = NumberOfRecords;

            int recLen = (lastRec - firstRec) / cnt;
            for (int i = 0; i < cnt; i++)
                yield return firstRec + i * recLen;
        }
    }
}