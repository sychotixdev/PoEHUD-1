using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Hud;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Components
{
    public class Base : Component
    {
        private BaseRMO ChargesStructure => GetObject<BaseRMO>(Address);

        public string Name
        {
            get
            {
                return NativeStringReader.ReadString(ChargesStructure.NamePointer + 0x18);
            }
        }

        public class BaseRMO : StructuredRemoteMemoryObject<EnumOffsets.Base>
        {
            public int NamePointer => Structure.namePointer;

        }

        // 0x8 - link to base item
        // +0x10 - Name
        // +0x30 - Use hint
        // +0x50 - Link to Data/BaseItemTypes.dat

        // 0xC (+4) fileref to visual identity
    }
}
