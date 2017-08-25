namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        public float ShiftX => M.ReadFloat(M.ReadInt(Address + 0x26C + OffsetBuffers) + OffsetBuffers + 0x1F4);
        public float ShiftY => M.ReadFloat(M.ReadInt(Address + 0x26C + OffsetBuffers) + OffsetBuffers + 0x1F8);
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);
        public Element LargeMap => ReadObjectAt<Element>(0x26C + OffsetBuffers);
        public Element SmallMinimap => ReadObjectAt<Element>(0x270 + OffsetBuffers);
        public Element OrangeWords => ReadObjectAt<Element>(0x27C + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x298 + OffsetBuffers);
    }
}