using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Poe.RemoteMemoryObjects;
using System;
using System.Runtime.InteropServices;

namespace PoeHUD.Poe
{
    public abstract class StructuredRemoteMemoryObject<T> : RemoteMemoryObject where T : struct 
    {
        private T? _readStructure;
        private long ReadFrame = -1;
        public T Structure
        {
            get
            {
                if (_readStructure == null || ReadFrame != GameController.Instance.RenderCount)
                {
                    _readStructure = M.IntptrToStruct<T>(Address, Marshal.SizeOf(typeof(T)));
                    ReadFrame = GameController.Instance.RenderCount;
                }
                return _readStructure ?? new T();
            }
        }
    }
}