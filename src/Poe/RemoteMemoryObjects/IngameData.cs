namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameData : RemoteMemoryObject
    {
        public AreaTemplate CurrentArea => ReadObject<AreaTemplate>(Address + 0x8);
        public int CurrentAreaLevel => M.ReadInt(Address + 0xC);
        public int CurrentAreaHash => M.ReadInt(Address + 0x10);
        public Entity LocalPlayer => ReadObject<Entity>(Address + 0x4B8);
        public EntityList EntityList => GetObject<EntityList>(Address + 0x528);
    }
}