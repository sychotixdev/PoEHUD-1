namespace PoeHUD.Poe
{
    public abstract class StructuredRemoteMemoryObject<T> : RemoteMemoryObject where T : struct
    {
        private readonly PerFrameCachedValue<T> _cachedStructValue = new PerFrameCachedValue<T>();
        public T Structure => _cachedStructValue.Structure;
    }
}