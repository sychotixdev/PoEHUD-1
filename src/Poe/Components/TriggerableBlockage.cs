using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.Components
{
    public class TriggerableBlockage : Component
    {
        public bool IsClosed => Address != 0 && M.ReadByte(Address + 0x30) == 1;

        public Point Min => new Point(M.ReadInt(Address + 0x58), M.ReadInt(Address + 0x5C));
        public Point Max => new Point(M.ReadInt(Address + 0x60), M.ReadInt(Address + 0x64));

        public byte[] Data
        {
            get
            {
                var start = M.ReadLong(Address + 0x38);
                var end = M.ReadLong(Address + 0x40);
                return M.ReadBytes(start, (int)(end - start));
            }
        }
    }
}
