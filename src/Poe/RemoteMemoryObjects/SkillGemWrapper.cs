using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class SkillGemWrapper : RemoteMemoryObject
    {
        public string Name => M.ReadStringU(M.ReadLong(Address));
        public ActiveSkillWrapper ActiveSkill => ReadObject<ActiveSkillWrapper>(Address + 0x16d);
    }
}
