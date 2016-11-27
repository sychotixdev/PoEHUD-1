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
        private int NumberOfRecords => M.ReadInt(Address + 0x48, 0x28);

        protected IEnumerable<long> RecordAddresses()
        {       
            long firstRec = M.ReadLong(Address + 0x48, 0x8);
            long lastRec = M.ReadLong(Address + 0x48, 0x10);
            int cnt = NumberOfRecords;
            //System.Windows.Forms.MessageBox.Show("firstRec: " + firstRec.ToString("x"));
            long recLen = (lastRec - firstRec) / cnt;
       
            //System.Windows.Forms.MessageBox.Show("recLen: " + recLen.ToString("x") + "|" + recLen);
            for (int i = 0; i < cnt; i++)
            {
                //System.Windows.Forms.MessageBox.Show("yield: " + (firstRec + i * recLen).ToString("x"));
                yield return firstRec + i * recLen;
            }
        }
    }
}