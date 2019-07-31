using PoeHUD.Hud;

namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);

        protected MapRMO _mapRMO = null;
        protected MapRMO MapStructure => _mapRMO ?? GetObject<MapRMO>(Address);

        public MapInfo LargeMap => GetObject<MapInfo>(MapStructure.LargeMap);

        public Element SmallMinimap => GetObject<Element>(MapStructure.SmallMinimap);

        public Element OrangeWords => GetObject<Element>(MapStructure.OrangeWords);
    }

    public class MapRMO : StructuredRemoteMemoryObject<EnumOffsets.Map>
    {
        public long LargeMap => (long)Structure.largeMap;
        public long SmallMinimap => (long)Structure.smallMinimap;
        public long OrangeWords => (long)Structure.orangeWords;

    }

    public class MapInfo : Element
    {
        protected MapInfoRMO _mapInfoRMO = null;
        protected MapInfoRMO MapInfoStructure => _mapInfoRMO ?? GetObject<MapInfoRMO>(Address);

        public float MapShiftX => MapInfoStructure.MapShiftX;
        public float MapShiftY => MapInfoStructure.MapShiftY;
        public float MapZoom => MapInfoStructure.MapZoom;
    }

    public class MapInfoRMO : StructuredRemoteMemoryObject<EnumOffsets.MapInfo>
    {
        public float MapShiftX => Structure.mapShiftX;
        public float MapShiftY => Structure.mapShiftY;
        public float MapZoom => Structure.mapZoom;

    }
}