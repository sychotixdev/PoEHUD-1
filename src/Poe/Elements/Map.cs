namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        public float ShiftX => M.ReadFloat(M.ReadInt(Address + 0x1FC + OffsetBuffers) + OffsetBuffers + 0x184);
        public float ShiftY => M.ReadFloat(M.ReadInt(Address + 0x1FC + OffsetBuffers) + OffsetBuffers + 0x188);
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);
        public Element LargeMap => ReadObjectAt<Element>(0x1FC + OffsetBuffers);
        public Element SmallMinimap => ReadObjectAt<Element>(0x200 + OffsetBuffers);
        public Element OrangeWords => ReadObjectAt<Element>(0x20C + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x22C + OffsetBuffers);
    }
}