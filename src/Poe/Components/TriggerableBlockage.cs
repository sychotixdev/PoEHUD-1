using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct TriggerableBlockageStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x30)]
        public byte IsClosed;
        [FieldOffset(0x38)]
        public long DataStartPtr;
        [FieldOffset(0x40)]
        public long DataEndPtr;
        [FieldOffset(0x58)]
        public int MinX;
        [FieldOffset(0x5C)]
        public int MinY;
        [FieldOffset(0x60)]
        public int MaxX;
        [FieldOffset(0x64)]
        public int MaxY;
    }

    public class TriggerableBlockage : StructuredRemoteMemoryObject<TriggerableBlockageStruct>, Component
    {
        public Point Min => new Point(Structure.MinX, Structure.MinY);
        public Point Max => new Point(Structure.MaxX, Structure.MaxY);

        public byte[] Data
        {
            get
            {
                var start = Structure.DataStartPtr;
                var end = Structure.DataEndPtr;
                return M.ReadBytes(start, (int)(end - start));
            }
        }

        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public bool IsClosed => Address != 0 && Structure.IsClosed == 1;
    }
}
