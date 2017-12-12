using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{
    public class PoeChatElement : Element
    {
        public long TotalMessageCount => ChildCount;
        public EntityLabel this[int index]
        {
            get
            {
                if (index < TotalMessageCount)
                    return Children[index].AsObject<EntityLabel>();
                return null;
            }
        }
    }
}
