using PoeHUD.Models.Enums;
using System;
using PoeHUD.Controllers;
using PoeHUD.Hud;
using PoeHUD.Models;
namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class IngameState : StructuredRemoteMemoryObject<EnumOffsets.IngameState>
	{
        private Cache _cache => GameController.Instance.Cache;

		public IngameUIElements IngameUi => _cache.Enable && _cache.IngameUi != null ? _cache.IngameUi : _cache.Enable ? _cache.IngameUi = IngameUiReal : IngameUiReal;
		private IngameUIElements IngameUiReal => GetObject<IngameUIElements>((long)Structure.ingameUi); // also at 0xF8...

		public IngameData Data => _cache.Enable && _cache.Data != null ? _cache.Data : _cache.Enable ? _cache.Data = DataReal : DataReal;
		private IngameData DataReal => GetObject<IngameData>((long) Structure.ingameData);

        public bool InGame => ServerDataReal.IsInGame;

		public ServerData ServerData => _cache.Enable && _cache.ServerData != null ? _cache.ServerData : _cache.Enable ? _cache.ServerData = ServerDataReal : ServerDataReal;
		private ServerData ServerDataReal => GetObject<ServerData>((long)Structure.serverData);

		public Element UIRoot => _cache.Enable && _cache.UIRoot != null ? _cache.UIRoot : _cache.Enable ? _cache.UIRoot = UIRootReal : UIRootReal;
		private Element UIRootReal => GetObject<Element>((long)Structure.uiRoot);

        public Camera Camera => _cache.Enable && _cache.Camera != null ? _cache.Camera :
			_cache.Enable ? _cache.Camera = CameraReal : CameraReal;

		private Camera CameraReal => GetObject<Camera>((long)Structure.camera);
	}
}