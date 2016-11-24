namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameData : RemoteMemoryObject
    {
        public AreaTemplate CurrentArea => ReadObject<AreaTemplate>(Address + 0x8);
        public int CurrentAreaLevel => M.ReadInt(Address + 0x18);
        public int CurrentAreaHash => M.ReadInt(Address + 0x38);//or 1C or 5C
        public Entity LocalPlayer => ReadObject<Entity>(Address + 0x144);
        public EntityList EntityList => GetObject<EntityList>(Address + 0x1B4);
    }
}