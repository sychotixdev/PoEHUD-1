using PoeHUD.Models.Enums;
using System;
using PoeHUD.Controllers;
using PoeHUD.Hud;
using PoeHUD.Models;
namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class IngameState : StructuredRemoteMemoryObject<EnumOffsets.IngameState>
	{

		public IngameUIElements IngameUi => GetObject<IngameUIElements>((long)Structure.ingameUi); // also at 0xF8...

		public IngameData Data => GetObject<IngameData>((long)Structure.ingameData);

        public bool InGame => ServerData.IsInGame;

		public ServerData ServerData => GetObject<ServerData>((long)Structure.serverData);

        public Element UIRoot => GetObject<Element>((long)Structure.uiRoot);


        public Camera Camera => new Camera(Game, Structure.camera);

	}
}