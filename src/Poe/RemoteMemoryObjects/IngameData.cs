namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameData : RemoteMemoryObject
    {
        public AreaTemplate CurrentArea => ReadObject<AreaTemplate>(Address + 8);
        public int CurrentAreaLevel => M.ReadInt(Address + 12);
        public int CurrentAreaHash => M.ReadInt(Address + 16);
        public Entity LocalPlayer => ReadObject<Entity>(Address + 1196);
        public EntityList EntityList => GetObject<EntityList>(Address + 1304);
    }
}