namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalEventState : RemoteMemoryObject
	{
		public BetrayalTarget Target1 => ReadObjectAt<BetrayalTarget>(0xAB8);
		public BetrayalTarget Target2 => ReadObjectAt<BetrayalTarget>(0xAD8);
		public BetrayalTarget Target3 => ReadObjectAt<BetrayalTarget>(0xAE8);
		public BetrayalChoiceAction Action => ReadObjectAt<BetrayalChoiceAction>(0xAC8);
	}
}
