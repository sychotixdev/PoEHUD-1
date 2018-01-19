namespace PoeHUD.Poe
{
    public abstract class Component : RemoteMemoryObject
    {
        protected Entity Owner => ReadObject<Entity>(Address + 8);
    }
}