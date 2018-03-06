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
    public class BestiaryGroups : FileInMemory
    {
        //We mark this fields as private coz we don't allow to read them directly. Optimisation. Use methods instead
        private readonly Dictionary<long, BestiaryGroup> BestiaryGroupAddressDictionary = new Dictionary<long, BestiaryGroup>();
        private readonly List<BestiaryGroup> BestiaryGroupList = new List<BestiaryGroup>();

        public List<BestiaryGroup> DebugList
        {
            get
            {
                CheckCache();
                return BestiaryGroupList;
            }
        }

        public BestiaryGroups(Memory m, long address)
            : base(m, address)
        {
        }

        public BestiaryGroup GetBestiaryGroupByAddress(long address)
        {
            CheckCache();
            BestiaryGroup result;
            BestiaryGroupAddressDictionary.TryGetValue(address, out result);
            return result;
        }

        public void CheckCache()
        {
            if (BestiaryGroupAddressDictionary.Count != 0)
                return;

            var idCounter = 0;
            foreach (long addr in RecordAddresses())
            {
                var r = GameController.Instance.Game.IngameState.GetObject<BestiaryGroup>(addr);
                r.Id = idCounter++;

                BestiaryGroupAddressDictionary.Add(addr, r);
                BestiaryGroupList.Add(r);
            }
        }
    }
}