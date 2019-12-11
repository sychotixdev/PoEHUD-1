using PoeHUD.Framework;
using System.Collections.Generic;

namespace PoeHUD.Poe
{
    public abstract class FileInMemory
    {
        protected FileInMemory(Memory m, long address)
        {
            M = m;
            Address = address;
        }

        public Memory M { get; }
        public long Address { get; }
        private int NumberOfRecords => M.ReadInt(Address + 0x38, 0x20);

        protected IEnumerable<long> RecordAddresses()
        {       
            long firstRec = M.ReadLong(Address + 0x38, 0x0);
            long lastRec = M.ReadLong(Address + 0x38, 0x8);
            int cnt = NumberOfRecords;
            long recLen = (lastRec - firstRec) / cnt;
       
            for (int i = 0; i < cnt; i++)
            {
                yield return firstRec + i * recLen;
            }
        }
    }
}