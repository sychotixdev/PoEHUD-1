namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        public float ShiftX => M.ReadFloat(M.ReadInt(Address + 0x274 + OffsetBuffers) + OffsetBuffers + 0x1FC);
        public float ShiftY => M.ReadFloat(M.ReadInt(Address + 0x274 + OffsetBuffers) + OffsetBuffers + 0x200);
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);
        public Element LargeMap => ReadObjectAt<Element>(0x274 + OffsetBuffers);
        public Element SmallMinimap => ReadObjectAt<Element>(0x278 + OffsetBuffers);
        public Element OrangeWords => ReadObjectAt<Element>(0x28 + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x2A0 + OffsetBuffers);
    }
}