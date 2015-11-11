namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        public float ShiftX => M.ReadFloat(M.ReadInt(Address + 0x168 + OffsetBuffers) + 0x8F8);
        public float ShiftY => M.ReadFloat(M.ReadInt(Address + 0x168 + OffsetBuffers) + 0x8FC);
        public Element SmallMinimap => ReadObjectAt<Element>(0x16C + OffsetBuffers);
        public Element MapProperties => ReadObjectAt<Element>(0x170 + OffsetBuffers);
        public Element LargeMap => ReadObjectAt<Element>(0x168 + OffsetBuffers);
        public Element OrangeWords => ReadObjectAt<Element>(0x174 + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x18c + OffsetBuffers);
    }
}