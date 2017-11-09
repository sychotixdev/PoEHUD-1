using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{
    public class PoeChatElement : Element
    {
        //private Element ChatBoxParent => GetObject<Element>(M.ReadLong(Address + 0xC78, 0x408));
        public Element ChatBoxParent => GetObject<Element>(M.ReadLong(Address + 0xAB0, 0xC28));
        public long TotalChatMessages => ChatBoxParent.ChildCount;
        public string this[int number]
        {
            get
            {
                var parentChildrenAddr = ChatBoxParent.Children[number].Address;
                int length = M.ReadInt(parentChildrenAddr + 0xC28);
                //int unknown = M.ReadInt(parentChildrenAddr + 0xC30);
                return M.ReadStringU(M.ReadLong(parentChildrenAddr + 0xC18), length * 2);
            }
        }

        public List<string> GetChatMessages()
        {
            List<string> rezult = new List<string>();
            for (int i = 0; i < TotalChatMessages; ++i)
                rezult.Add(this[i]);
            return rezult;
        }
    }
}
