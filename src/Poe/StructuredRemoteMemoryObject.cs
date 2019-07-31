using PoeHUD.Framework;
using PoeHUD.Poe.RemoteMemoryObjects;
using System;
using PoeHUD.Models.Attributes;

namespace PoeHUD.Poe
{
    public abstract class StructuredRemoteMemoryObject<T> : RemoteMemoryObject where T : struct
    {
        private PerFrameCachedValue<T> _cachedStructValue;
        [HideInReflection]
        public T Structure => _cachedStructValue?.Structure ?? (_cachedStructValue = new PerFrameCachedValue<T>(Address)).Structure;
    }
}