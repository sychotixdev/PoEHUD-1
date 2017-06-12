namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        public float ShiftX => M.ReadFloat(M.ReadLong(Address + 0x2E4 + OffsetBuffers) + OffsetBuffers + 0x274);
        public float ShiftY => M.ReadFloat(M.ReadLong(Address + 0x2E4 + OffsetBuffers) + OffsetBuffers + 0x278);
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);
        public Element LargeMap => ReadObjectAt<Element>(0x2E4 + OffsetBuffers);
        public Element SmallMinimap => ReadObjectAt<Element>(0x2EC + OffsetBuffers);

        //MapProperties ?? 0x2F4 

        public Element OrangeWords => ReadObjectAt<Element>(0x304 + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x33C + OffsetBuffers);
    }
}