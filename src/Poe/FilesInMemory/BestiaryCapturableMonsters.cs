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
    public class BestiaryCapturableMonsters : FileInMemory
    {
        //We mark this fields as private coz we don't allow to read them directly. Optimisation. Use methods instead
        private readonly Dictionary<int, BestiaryCapturableMonster> MonstersDictionary = new Dictionary<int, BestiaryCapturableMonster>();
        private readonly List<BestiaryCapturableMonster> MonstersList = new List<BestiaryCapturableMonster>();

        public List<BestiaryCapturableMonster> DebugList
        {
            get
            {
                CheckCache();
                return MonstersList;
            }
        }

        public BestiaryCapturableMonsters(Memory m, long address)
            : base(m, address)
        {
        }

        public BestiaryCapturableMonster GetMonsterById(int id)
        {
            CheckCache();

            BestiaryCapturableMonster result;
            MonstersDictionary.TryGetValue(id, out result);
            return result;
        }

        public BestiaryCapturableMonster GetMonsterByAddress(long address)
        {
            CheckCache();
            return MonstersList.Find(x => x.Address == address);
        }

        public void CheckCache()
        {
            if (MonstersDictionary.Count != 0)
                return;

            var idCounter = 0;
            foreach (long addr in RecordAddresses())
            {
                var r = GameController.Instance.Game.IngameState.GetObject<BestiaryCapturableMonster>(addr);
                r.Id = idCounter++;

                if (!MonstersDictionary.ContainsKey(r.Id))
                {
                    MonstersDictionary.Add(r.Id, r);
                    MonstersList.Add(r);
                }
            }
        }
    }
}