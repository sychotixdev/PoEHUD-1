using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Poe.RemoteMemoryObjects;
using System;
using System.Runtime.InteropServices;

namespace PoeHUD.Poe
{
    public abstract class StructuredRemoteMemoryObject<T> : RemoteMemoryObject where T : struct 
    {
        private long renderCountWhenRead = 0;
        private T? _readStructure;
        public T Structure
        {
            get
            {
                if (_readStructure == null || renderCountWhenRead != GameController.Instance.RenderCount)
                {
                    _readStructure = M.IntptrToStruct<T>(Address, Marshal.SizeOf(typeof(T)));
                    renderCountWhenRead = GameController.Instance.RenderCount;
                }
                return _readStructure ?? new T();
            }
        }
    }
}