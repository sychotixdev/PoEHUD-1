namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        public float ShiftX => M.ReadFloat(M.ReadLong(Address + 0x2EC + OffsetBuffers) + OffsetBuffers + 0x27C);
        public float ShiftY => M.ReadFloat(M.ReadLong(Address + 0x2EC + OffsetBuffers) + OffsetBuffers + 0x280);
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);
        public Element LargeMap => ReadObjectAt<Element>(0x2EC + OffsetBuffers);
        public Element SmallMinimap => ReadObjectAt<Element>(0x2F4 + OffsetBuffers);

        //MapProperties ?? 0x2F4 

        public Element OrangeWords => ReadObjectAt<Element>(0x30C + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x344 + OffsetBuffers);
    }
}