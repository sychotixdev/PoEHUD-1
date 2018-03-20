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
    public class PropheciesDat : UniversalFileWrapper<Prophecy>
    {
        private Dictionary<int, Prophecy> ProphecyIndexDictionary = new Dictionary<int, Prophecy>();

        public PropheciesDat(Memory m, long address) 
            : base(m, address)
        {
        }

        public Prophecy GetProphecyById(int index)
        {
            CheckCache();

            Prophecy prophecy;
            ProphecyIndexDictionary.TryGetValue(index, out prophecy);
            return prophecy;
        }

        private int IndexCounter;
        protected override void EntryAdded(long addr, Prophecy entry)
        {
            entry.Index = IndexCounter++;
            ProphecyIndexDictionary.Add(entry.ProphecyId, entry);
        }
    }
}
