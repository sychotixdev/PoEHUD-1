using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{
    public class HPbarElement : Element
    {
        public Entity MonsterEntity => ReadObject<Entity>(Address + 0x96C);
        public new List<HPbarElement> Children => GetChildren<HPbarElement>();
    }
}