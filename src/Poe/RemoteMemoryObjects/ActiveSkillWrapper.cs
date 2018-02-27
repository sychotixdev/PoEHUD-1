using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ActiveSkillWrapper : RemoteMemoryObject
    {
        public string InternalName => M.ReadStringU(M.ReadLong(Address));
        public string DisplayName => M.ReadStringU(M.ReadLong(Address + 0x8));
        public string Description => M.ReadStringU(M.ReadLong(Address + 0x10));
        public string SkillName => M.ReadStringU(M.ReadLong(Address + 0x18));
        public string Icon => M.ReadStringU(M.ReadLong(Address + 0x20));

        public List<int> CastTypes
        {
            get
            {
                var result = new List<int>();
                var castTypesCount = M.ReadInt(Address + 0x28);
                var readAddr = M.ReadLong(Address + 0x30);

                for (int i = 0; i < castTypesCount; i++)
                {
                    result.Add(M.ReadInt(readAddr));
                    readAddr += 4;
                }
                return result;
            }
        }

        public List<int> SkillTypes
        {
            get
            {
                var result = new List<int>();
                var skillTypesCount = M.ReadInt(Address + 0x38);
                var readAddr = M.ReadLong(Address + 0x40);

                for (int i = 0; i < skillTypesCount; i++)
                {
                    result.Add(M.ReadInt(readAddr));
                    readAddr += 4;
                }
                return result;
            }
        }

        public string LongDescription => M.ReadStringU(M.ReadLong(Address + 0x50));
        public string AmazonLink => M.ReadStringU(M.ReadLong(Address + 0x60));
    }
}
