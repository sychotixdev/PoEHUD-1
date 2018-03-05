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
    public class BestiaryGenuses : FileInMemory
    {
        //We mark this fields as private coz we don't allow to read them directly. Optimisation. Use methods instead
        private readonly Dictionary<long, BestiaryGenus> GenusAddressDictionary = new Dictionary<long, BestiaryGenus>();
        private readonly List<BestiaryGenus> GenusList = new List<BestiaryGenus>();

        public List<BestiaryGenus> DebugList
        {
            get
            {
                CheckCache();
                return GenusList;
            }
        }

        public BestiaryGenuses(Memory m, long address)
            : base(m, address)
        {
        }

        public BestiaryGenus GetGenusByAddress(long address)
        {
            CheckCache();
            BestiaryGenus result;
            GenusAddressDictionary.TryGetValue(address, out result);
            return result;
        }

        public void CheckCache()
        {
            if (GenusAddressDictionary.Count != 0)
                return;

            var idCounter = 0;
            foreach (long addr in RecordAddresses())
            {
                var r = GameController.Instance.Game.IngameState.GetObject<BestiaryGenus>(addr);
                r.Id = idCounter++;

                GenusAddressDictionary.Add(addr, r);
                GenusList.Add(r);
            }
        }
    }
}