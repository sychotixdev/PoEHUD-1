namespace PoeHUD.Poe.Elements
{
    public class PoeChatElement : Element
    {
        //private Element ChatBoxParent => GetObject<Element>(M.ReadLong(Address + 0xC78, 0x408));
        public Element ChatBoxParent => GetObject<Element>(M.ReadLong(Address + 0xAB0, 0xC28));
        public long totalChatMessages => ChatBoxParent.ChildCount;
        public string this[int number]
        {
            get
            {
                int string_length = M.ReadInt(ChatBoxParent.Children[number].Address + 0xC28);
                int unknown = +M.ReadInt(ChatBoxParent.Children[number].Address + 0xC30);
                return M.ReadStringU(M.ReadLong(ChatBoxParent.Children[number].Address + 0xC18), string_length * 2);
            }
        }
    }
}
