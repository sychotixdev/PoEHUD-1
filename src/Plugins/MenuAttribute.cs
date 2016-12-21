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
        public string MenuName = null;
        public MenuAttribute(string menuName)
        {
            MenuName = menuName;
        }
    }
}
