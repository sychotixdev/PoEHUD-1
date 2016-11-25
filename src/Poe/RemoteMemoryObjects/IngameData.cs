namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameData : RemoteMemoryObject
    {
        public AreaTemplate CurrentArea => ReadObject<AreaTemplate>(Address + 0x10);
        public int CurrentAreaLevel => M.ReadInt(Address + 0x18);
        public int CurrentAreaHash => M.ReadInt(Address + 0x38);
        public Entity LocalPlayer => ReadObject<Entity>(Address + 0x144);
        public EntityList EntityList => GetObject<EntityList>(Address + 0x1B4);
    }
}