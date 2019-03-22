using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct MapStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x10)]
        public long InternalPtr;
        [FieldOffset(0x18)]
        public byte Tier;
    }

    public class Map : StructuredRemoteMemoryObject<MapStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);
        public MapInternal Internal => GetObject<MapInternal>(Structure.InternalPtr);

        [StructLayout(LayoutKind.Explicit)]
        public struct MapInternalStruct
        {
            [FieldOffset(0x28)]
            public long AreaPtr;
        }

        public class MapInternal : StructuredRemoteMemoryObject<MapInternalStruct>
        {

        }

        public WorldArea Area => GameController.Instance.Files.WorldAreas.GetByAddress(Internal.Structure.AreaPtr);
        public int Tier => Structure.Tier;//let it be int to not break some plugins
        //public InventoryTabMapSeries MapSeries => (InventoryTabMapSeries)M.ReadByte(Address + 0x10, 0x9c);
    }

    public enum InventoryTabMapSeries : byte
    {
        Atlas_of_Worlds = 3,
        None = 0,
        Original = 1,
        The_Awakening = 2,
        War_for_the_Atlas = 4,
        Bestiary = 5,
    }
}