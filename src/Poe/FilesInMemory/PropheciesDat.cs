using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using PoeHUD.Poe.RemoteMemoryObjects;


namespace PoeHUD.Poe.FilesInMemory
{
    public class PropheciesDat : UniversalFileWrapper<ProphecyDat>
    {
        private Dictionary<int, ProphecyDat> ProphecyIndexDictionary = new Dictionary<int, ProphecyDat>();

        public PropheciesDat(Memory m, long address) 
            : base(m, address)
        {
        }

        public ProphecyDat GetProphecyById(int index)
        {
            CheckCache();

            ProphecyDat prophecy;
            ProphecyIndexDictionary.TryGetValue(index, out prophecy);
            return prophecy;
        }

        private int IndexCounter;
        protected override void EntryAdded(long addr, ProphecyDat entry)
        {
            entry.Index = IndexCounter++;
            ProphecyIndexDictionary.Add(entry.ProphecyId, entry);
        }
    }
}
