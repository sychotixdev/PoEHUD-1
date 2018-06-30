using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{
    public class MapSubInventoryInfo
    {
        public int MapTier;
        public int MapId;
        public int MapCount;

        public override string ToString()
        {
            return "MapTier:" + MapTier + " MapId:" + MapId + " MapCound:" + MapCount;
        }
    }

    public class MapStashTabElement : Element
    {
        private Dictionary<int, string> MapIdToMapBaseName = new Dictionary<int, string>() {
            //{2, "cat"},
        };

        private long mapListStartPtr => (Address != 0) ? M.ReadLong(Address + 0x9D8) : 0x00;
        private long mapListEndPtr => (Address != 0) ? M.ReadLong(Address + 0x9D8 + 0x08) : 0x00;
        public int TotalInventories => (int)((mapListEndPtr - mapListStartPtr) / 0x10);

        public Dictionary<string, MapSubInventoryInfo> MapsCount => GetMapsCount();
        private Dictionary<string, MapSubInventoryInfo> GetMapsCount()
        {
            var result = new Dictionary<string, MapSubInventoryInfo>();
            for (int i = 0; i < TotalInventories; i++)
            {
                MapSubInventoryInfo subInventory = new MapSubInventoryInfo();
                subInventory.MapTier = SubInventoryMapTier(i);
                subInventory.MapId = SubInventoryMapId(i);
                subInventory.MapCount = SubInventoryMapCount(i);
                if (subInventory.MapCount > 0)
                    result.Add(subInventory.MapId.ToString(), subInventory);
                    //result.Add(MapIdToMapBaseName[subInventory.MapId], subInventory);
            }
            return result;
        }

        public int SubInventoryMapTier(int index)
        {
            return M.ReadInt(mapListStartPtr + (index * 0x10), 0x00);
        }
        public int SubInventoryMapId(int index)
        {
            return M.ReadInt(mapListStartPtr + (index * 0x10), 0x04);
        }
        public int SubInventoryMapCount(int index)
        {
            return M.ReadInt(mapListStartPtr + (index * 0x10), 0x08);
        }
    }
}
