using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class QuestState : RemoteMemoryObject
    {
        //public string Id { get; internal set; }
        public long QuestPtr => M.ReadLong(Address + 0x8);
        public Quest Quest => GameController.Instance.Files.Quests.GetByAddress(QuestPtr);

        public int QuestStateId => M.ReadInt(Address + 0x10);
        public int TestOffset => M.ReadInt(Address + 0x14);


        public string QuestStateText => M.ReadStringU(M.ReadLong(Address + 0x2c));
        public string QuestProgressText => M.ReadStringU(M.ReadLong(Address + 0x34));

        public override string ToString()
        {
            return $"Id: {QuestStateId}, Quest.Id: {Quest.Id}, ProgressText {QuestProgressText}, QuestName: {Quest.Name}";
        }
    }
}


