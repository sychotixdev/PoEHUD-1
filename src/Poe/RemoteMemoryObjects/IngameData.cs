using System;
using PoeHUD.Controllers;
using System.Collections.Generic;
using PoeHUD.Hud;
using PoeHUD.Models.Enums;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameData : StructuredRemoteMemoryObject<EnumOffsets.IngameData>
    {
        public uint CurrentAreaHash => Structure.currentAreaHash;

        public Entity LocalPlayer => GetObject<Entity>((long)Structure.localPlayer);
        public EntityList EntityList => new EntityList(Game, M, Structure.entityList);
    }
}