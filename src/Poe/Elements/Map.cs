namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);

        public Element LargeMap => ReadObjectAt<Element>(0x314 + OffsetBuffers);
        public float LargeMapShiftX => M.ReadFloat(LargeMap.Address + OffsetBuffers + 0x2A4);
        public float LargeMapShiftY => M.ReadFloat(LargeMap.Address + OffsetBuffers + 0x2A8);
        public float LargeMapZoom => M.ReadFloat(LargeMap.Address + OffsetBuffers + 0x2E8);

        public Element SmallMinimap => ReadObjectAt<Element>(0x31C + OffsetBuffers);
        public float SmallMinimapX => M.ReadFloat(SmallMinimap.Address + OffsetBuffers + 0x2A4);
        public float SmallMinimapY => M.ReadFloat(SmallMinimap.Address + OffsetBuffers + 0x2A8);
        public float SmallMinimapZoom => M.ReadFloat(SmallMinimap.Address + OffsetBuffers + 0x2E8);


        public Element OrangeWords => ReadObjectAt<Element>(0x334 + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x36C + OffsetBuffers);
    }
}