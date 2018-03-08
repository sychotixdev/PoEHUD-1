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
    public class QuestStates : UniversalFileWrapper<QuestState>
    {
        public QuestStates(Memory m, long address)
            : base(m, address)
        {
        }

        private Dictionary<string, Dictionary<int, QuestState>> QuestStatesDictionary;
        public QuestState GetQuestState(string questId, int stateId)
        {
            var dictionary = default(Dictionary<int, QuestState>);
            if (QuestStatesDictionary == null)
            {
                CheckCache();
                var qStates = EntriesList;
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