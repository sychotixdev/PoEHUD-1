using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.Components
{
    public class Shrine : Component
    {
        public bool IsAvailable => Address != 0 && M.ReadByte(Address + 0x1c) == 0;
    }
}
