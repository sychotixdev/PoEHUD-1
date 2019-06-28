namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class DeployedObject
    {
        internal DeployedObject(uint objId, ushort objectKey)
        {
            ObjectId = objId;
            ObjectKey = objectKey;
        }
        public uint ObjectId { get; private set; }
        public ushort ObjectKey { get; private set; }
        //public EntityWrapper Entity => GameController.Instance.EntityListWrapper.GetEntityById(ObjectKey);//TODO: Not supported atm after changing area cache
        //public ActorSkill Skill => GameController.Instance.Player.GetComponent<Actor>().ActorSkills.Find(x => x.Id == ObjectKey);
    }
}