namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        public float ShiftX => M.ReadFloat(M.ReadInt(Address + 0x24C + OffsetBuffers) + OffsetBuffers + 0x1D4);
        public float ShiftY => M.ReadFloat(M.ReadInt(Address + 0x24C + OffsetBuffers) + OffsetBuffers + 0x1D8);
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);
        public Element LargeMap => ReadObjectAt<Element>(0x24C + OffsetBuffers);
        public Element SmallMinimap => ReadObjectAt<Element>(0x250 + OffsetBuffers);
        public Element OrangeWords => ReadObjectAt<Element>(0x25C + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x27C + OffsetBuffers);
    }
}