namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        public float ShiftX => M.ReadFloat(M.ReadInt(Address + 0x200 + OffsetBuffers) + OffsetBuffers + 0x188);
        public float ShiftY => M.ReadFloat(M.ReadInt(Address + 0x200 + OffsetBuffers) + OffsetBuffers + 0x18C);
        public Element BlueWords => ReadObjectAt<Element>(0x1CC + OffsetBuffers);//not right, but it's not used
        public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);
        public Element LargeMap => ReadObjectAt<Element>(0x200 + OffsetBuffers);
        public Element SmallMinimap => ReadObjectAt<Element>(0x204 + OffsetBuffers);
        public Element OrangeWords => ReadObjectAt<Element>(0x210 + OffsetBuffers);
    }
}