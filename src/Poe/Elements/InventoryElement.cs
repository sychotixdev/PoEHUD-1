using PoeHUD.Models.Enums;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Elements
{
    public class InventoryElement : Element
    {
        private InventoryList AllInventories => GetObjectAt<InventoryList>(OffsetBuffers + 0x3FC);
        public Inventory this[InventoryIndex k]
        {
            get
            {
                return AllInventories[k];
            }
        }
    }
}