namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameData : RemoteMemoryObject
    {
        public AreaTemplate CurrentArea => ReadObject<AreaTemplate>(Address + 0x14);
        public int CurrentAreaLevel => CurrentArea.NominalLevel;
        public int CurrentAreaHash => M.ReadInt(Address + 0x30);
        public Entity LocalPlayer => ReadObject<Entity>(Address + 0x158);
        public EntityList EntityList => GetObject<EntityList>(Address + 0x1BC);
    }
}