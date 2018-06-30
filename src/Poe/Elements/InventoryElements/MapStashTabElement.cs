using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{

    public class MapStashTabElement : Element
    {
        private long mapListStartPtr => (Address != 0) ? M.ReadLong(Address + 0x9D8) : 0x00;
        private long mapListEndPtr => (Address != 0) ? M.ReadLong(Address + 0x9D8 + 0x08) : 0x00;

        public int TotalInventories => (int)((mapListEndPtr - mapListStartPtr) / 0x10);

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
