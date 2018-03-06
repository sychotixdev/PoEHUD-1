using System.Collections.Generic;
using System;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using PoeHUD.Models;

namespace PoeHUD.Poe.Components
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
        public EntityWrapper Entity => GameController.Instance.EntityListWrapper.GetEntityById(ObjectKey);
        //public ActorSkill Skill => GameController.Instance.Player.GetComponent<Actor>().ActorSkills.Find(x => x.Id == ObjectKey);
    }
}