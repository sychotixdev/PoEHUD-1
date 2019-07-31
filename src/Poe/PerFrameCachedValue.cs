using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using PoeHUD.Framework;

namespace PoeHUD.Poe
{
    public class PerFrameCachedValue<T> where T : struct
    {
        private long _readFrame = -1;
        private T _readStructure;
        private readonly long _address;

        public PerFrameCachedValue(long address)
        {
            _address = address;
        }

        public T Structure
        {
            get
            {
                //we are not going to read struct if address is 0, just return the empty struct
                if ((ulong)_address > 0 && _readFrame != GameController.Instance.RenderCount)
                {
                    _readStructure = Memory.Instance.IntptrToStruct<T>(_address, Marshal.SizeOf(typeof(T)));
                    _readFrame = GameController.Instance.RenderCount;
                }

                return _readStructure;
            }
        }
    }
}