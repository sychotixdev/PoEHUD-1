using PoeHUD.Hud;

namespace PoeHUD.Poe.Components
{
    public class Targetable : Component
    {
        private TargetableRMO TargetableStructure => GetObject<TargetableRMO>(Address);
        public bool isTargetable => Address != 0 && TargetableStructure.IsTargetable == 1;
    }

    public class TargetableRMO : StructuredRemoteMemoryObject<EnumOffsets.Target>
    {
        public byte IsTargetable => Structure.isTargetable;
    }
}
