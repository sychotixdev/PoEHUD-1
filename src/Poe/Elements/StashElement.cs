using PoeHUD.Poe.RemoteMemoryObjects;
using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{
    public class StashElement : Element
    {
        public long TotalStashes => StashInventoryPanel.ChildCount;

        public Element ExitButton => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0xA90)) : null;

        // Nice struct starts at 0xB80 till 0xBD0 and all are 8 byte long pointers.
        private Element StashTitlePanel => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0xAB0, 0xB80)) : null;
        private Element StashInventoryPanel => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0xAB0, 0xB90)) : null;
        public Element ViewAllStashButton => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0xAB0, 0xB98)) : null;
        public Element ViewAllStashPanel => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0xAB0, 0xBA0, 0xB78)) : null; // going extra inside.
        public int IndexVisibleStash => M.ReadInt(Address+0xAB0,0xBD8);
        public Inventory VisibleStash => GetVisibleStash();
        private Inventory GetVisibleStash()
        {
            return GetStashInventoryByIndex(IndexVisibleStash);
        }

        public List<string> AllStashNames => GetAllStashNames();
        private List<string> GetAllStashNames()
        {
            List<string> ret = new List<string>();
            for (int i = 0; i < TotalStashes; i++)
            {
                ret.Add(GetStashName(i));
            }
            return ret;
        }

        public Inventory GetStashInventoryByIndex(int index)
        {
            if (index >= TotalStashes)
                return null;
            if (StashInventoryPanel.Children[index].ChildCount == 0)
                return null;
            return StashInventoryPanel.Children[index].Children[0].Children[0].AsObject<Inventory>();
        }
        public string GetStashName(int index)
        {
            if (index >= TotalStashes || index < 0)
                return string.Empty;
            return ViewAllStashPanel.Children[index].AsObject<EntityLabel>().Text;
        }
    }
}
