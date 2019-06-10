using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalEventData : RemoteMemoryObject
	{
		public BetrayalTarget Target1 => GameController.Instance.Files.BetrayalTargets.GetByAddress(M.ReadLong(Address + 0x2D0));
		public BetrayalTarget Target2 => GameController.Instance.Files.BetrayalTargets.GetByAddress(M.ReadLong(Address + 0x2F0));
		public BetrayalTarget Target3 => GameController.Instance.Files.BetrayalTargets.GetByAddress(M.ReadLong(Address + 0x300));
		public BetrayalChoiceAction Action => GameController.Instance.Files.BetrayalChoiseActions.GetByAddress(M.ReadLong(Address + 0x2E0));
	}
}