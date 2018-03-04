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
    public class Quests : FileInMemory
    {
        //We mark this fields as private coz we don't allow to read them directly. Optimisation. Use methods instead
        private readonly Dictionary<string, Quest> QuestsDictionary = new Dictionary<string, Quest>(StringComparer.OrdinalIgnoreCase);
        private readonly List<Quest> QuestsList = new List<Quest>();

        public Quests(Memory m, long address)
            : base(m, address)
        {
        }

        public Quest GetQuestById(string questId)
        {
            CheckCache();

            Quest result;
            QuestsDictionary.TryGetValue(questId, out result);
            return result;
        }

        public Quest GetQuestByAddress(long address)
        {
            CheckCache();
            return QuestsList.Find(x => x.Address == address);
        }

        public void CheckCache()
        {
            if (QuestsDictionary.Count != 0)
                return;

            var idCounter = 0;
            foreach (long addr in RecordAddresses())
            {
                var r = GameController.Instance.Game.IngameState.GetObject<Quest>(addr);
                r.Id = M.ReadStringU(M.ReadLong(addr), 255);
                r.QuestId = idCounter++;

                if (!QuestsDictionary.ContainsKey(r.Id))
                {
                    QuestsDictionary.Add(r.Id, r);
                    QuestsList.Add(r);
                }
            }
        }
    }
}