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
    public class BestiaryFamilies : FileInMemory
    {
        //We mark this fields as private coz we don't allow to read them directly. Optimisation. Use methods instead
        private readonly Dictionary<long, BestiaryFamily> FamilyAddressDictionary = new Dictionary<long, BestiaryFamily>();
        private readonly List<BestiaryFamily> FamilyList = new List<BestiaryFamily>();

        public List<BestiaryFamily> DebugList
        {
            get
            {
                CheckCache();
                return FamilyList;
            }
        }

        public BestiaryFamilies(Memory m, long address)
            : base(m, address)
        {
        }

        public BestiaryFamily GetFamilyByAddress(long address)
        {
            CheckCache();
            BestiaryFamily result;
            FamilyAddressDictionary.TryGetValue(address, out result);
            return result;
        }

        public void CheckCache()
        {
            if (FamilyAddressDictionary.Count != 0)
                return;

            var idCounter = 0;
            foreach (long addr in RecordAddresses())
            {
                var r = GameController.Instance.Game.IngameState.GetObject<BestiaryFamily>(addr);
                r.Id = idCounter++;

                FamilyAddressDictionary.Add(addr, r);
                FamilyList.Add(r);
            }
        }
    }
}