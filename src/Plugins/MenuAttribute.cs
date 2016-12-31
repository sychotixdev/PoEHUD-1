using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Plugins
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MenuAttribute : Attribute
    {
        public string MenuName = "";
        public int index = -1;
        public int parentIndex = -1;

        public MenuAttribute(string menuName)
        {
            MenuName = menuName;
        }
        public MenuAttribute(string menuName, int index)
        {
            MenuName = menuName;
            this.index = index;
        }
        public MenuAttribute(string menuName, int index, int parentIndex)
        {
            MenuName = menuName;
            this.index = index;
            this.parentIndex = parentIndex;
        }
    }
}
