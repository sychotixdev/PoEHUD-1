using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.Components
{
    public class Animated : Component
    {

        public List<long> ComponentPointers
        {
            get
            {
                var objAddr = M.ReadLong(Address + 0x78);
                var start = M.ReadLong(objAddr + 0x8);
                var end = M.ReadLong(objAddr + 0x10);

                return M.ReadPointersArray(start, end);
            }
        }

        public List<string> ComponentPointersDbg => ComponentPointers.Select(x => x.ToString("x")).ToList();
    }
}
