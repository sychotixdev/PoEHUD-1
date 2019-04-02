using System.Runtime.InteropServices;
using PoeHUD.Framework;

namespace PoeHUD.Poe
{
    public class CachedValue<T> where T : struct
    {
        public readonly T Structure;

        public CachedValue(long address)
        {
            if ((ulong)address > 0)
            {
                Structure = Memory.Instance.IntptrToStruct<T>(address, Marshal.SizeOf(typeof(T)));
            }
        }
    }
}
