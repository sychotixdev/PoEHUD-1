namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        public float ShiftX => M.ReadFloat(M.ReadLong(Address + 0x314 + OffsetBuffers) + OffsetBuffers + 0x2A4);
        public float ShiftY => M.ReadFloat(M.ReadLong(Address + 0x314 + OffsetBuffers) + OffsetBuffers + 0x2A8);
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);
        public Element LargeMap => ReadObjectAt<Element>(0x314 + OffsetBuffers);
        public Element SmallMinimap => ReadObjectAt<Element>(0x31C + OffsetBuffers);
        public Element OrangeWords => ReadObjectAt<Element>(0x334 + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x36C + OffsetBuffers);
    }
}