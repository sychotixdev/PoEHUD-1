using System;
using PoeHUD.Hud;

namespace PoeHUD.Poe.Components
{
    public class Chest : Component
    {
        public ChestRMO ChestStructure => GetObject<ChestRMO>(Address);
        public bool IsOpened => Address != 0 && ChestStructure.IsOpened == 1;
        public bool IsStrongbox => Address != 0 && ChestStructure.IsStrongbox > 0;
    }

    public class ChestRMO : StructuredRemoteMemoryObject<EnumOffsets.Chest>
    {
        public byte IsOpened => Structure.isOpened;
        public int IsStrongbox => Structure.isStrongbox;

    }
}