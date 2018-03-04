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
    public class QuestStates : FileInMemory
    {
        private readonly List<QuestState> QuestStatesList = new List<QuestState>();

        public QuestStates(Memory m, long address)
            : base(m, address)
        {
        }

        public void CheckCache()
        {
            if (QuestStatesList.Count != 0)
                return;

            foreach (long addr in RecordAddresses())
            {
                var r = GameController.Instance.Game.IngameState.GetObject<QuestState>(addr);
                QuestStatesList.Add(r);
            }
        }


        private Dictionary<string, Dictionary<int, QuestState>> QuestStatesDictionary;
        public QuestState GetQuestState(string questId, int stateId)
        {
            var dictionary = default(Dictionary<int, QuestState>);
            if (QuestStatesDictionary == null)
            {
                CheckCache();
                var qStates = QuestStatesList;
                QuestStatesDictionary = new Dictionary<string, Dictionary<int, QuestState>>();
                try
                {
                    foreach (QuestState item in qStates)
                    {
                        if (!QuestStatesDictionary.TryGetValue(item.Quest.Id, out dictionary))
                        {
                            dictionary = new Dictionary<int, QuestState>();
                            QuestStatesDictionary.Add(item.Quest.Id.ToLowerInvariant(), dictionary);
                        }
                        dictionary.Add(item.QuestStateId, item);
                    }
                }
                catch (Exception)
                {
                    QuestStatesDictionary = null;
                    throw;
                }
            }
            QuestState result;
            if (QuestStatesDictionary.TryGetValue(questId.ToLowerInvariant(), out dictionary) && dictionary.TryGetValue(stateId, out result))
            {
                return result;
            }
            return null;
        }
    }
}