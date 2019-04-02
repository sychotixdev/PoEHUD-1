using System.Runtime.InteropServices;
using PoeHUD.Controllers;

namespace PoeHUD.Poe
{
    public class PerFrameCachedValue<T> : RemoteMemoryObject where T : struct
    {
        private long _readFrame = -1;
        private T _readStructure;

        public T Structure
        {
            get
            {
                //we are not going to read struct if address is 0, just return the empty struct
                if (Address != 0 && _readFrame != GameController.Instance.RenderCount)
                {
                    _readStructure = M.IntptrToStruct<T>(Address, Marshal.SizeOf(typeof(T)));
                    _readFrame = GameController.Instance.RenderCount;
                }

                return _readStructure;
            }
        }
    }
}
