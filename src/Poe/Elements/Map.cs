namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        public float ShiftX => M.ReadFloat(M.ReadInt(Address + 0x248 + OffsetBuffers) + OffsetBuffers + 0x1D0);
        public float ShiftY => M.ReadFloat(M.ReadInt(Address + 0x248 + OffsetBuffers) + OffsetBuffers + 0x1D4);
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);
        public Element LargeMap => ReadObjectAt<Element>(0x248 + OffsetBuffers);
        public Element SmallMinimap => ReadObjectAt<Element>(0x24C + OffsetBuffers);
        public Element OrangeWords => ReadObjectAt<Element>(0x258 + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x278 + OffsetBuffers);
    }
}