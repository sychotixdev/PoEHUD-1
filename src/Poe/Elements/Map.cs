namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        public float ShiftX => M.ReadFloat(M.ReadInt(Address + 0x184 + OffsetBuffers) + 0x904);
        public float ShiftY => M.ReadFloat(M.ReadInt(Address + 0x184 + OffsetBuffers) + 0x908);
        public Element SmallMinimap => ReadObjectAt<Element>(0x188 + OffsetBuffers);
        public Element MapProperties => ReadObjectAt<Element>(0x180 + OffsetBuffers);
        public Element LargeMap => ReadObjectAt<Element>(0x184 + OffsetBuffers);
        public Element OrangeWords => ReadObjectAt<Element>(0x194 + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x1B0 + OffsetBuffers);
    }
}