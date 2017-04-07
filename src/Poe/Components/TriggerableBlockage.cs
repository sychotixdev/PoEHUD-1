using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.Components
{
    public class TriggerableBlockage : Component
    {
        public bool IsClosed => Address != 0 && M.ReadByte(Address + 0x30) == 1;
    }
}
