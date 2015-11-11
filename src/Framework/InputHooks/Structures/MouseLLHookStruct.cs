using System.Drawing;
using System.Runtime.InteropServices;

namespace PoeHUD.Framework.InputHooks.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct MouseLLHookStruct
    {
        public Point Point;
        public int MouseData;
        public int Flags;
        public int Time;
        public int ExtraInfo;
    }
}