using System.Collections.Generic;
using System;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using PoeHUD.Models;

namespace PoeHUD.Poe.Components
{
    public class DeployedObject
    {
        internal DeployedObject(int objId, ushort skillId)
        {
            ObjectId = objId;
            SkillId = skillId;
            Entity = GameController.Instance.EntityListWrapper.GetEntityById(objId);
        }
        public int ObjectId { get; private set; }
        public ushort SkillId { get; private set; }
        public EntityWrapper Entity { get; private set; }
        public ActorSkill Skill => GameController.Instance.Player.GetComponent<Actor>().ActorSkills.Find(x => x.Id == SkillId);
    }
}