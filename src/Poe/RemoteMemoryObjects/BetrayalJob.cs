namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalJob : RemoteMemoryObject
	{
		public string Id => M.ReadStringU(M.ReadLong(Address));
		public string Name => M.ReadStringU(M.ReadLong(Address + 0x8));
		public string Art => M.ReadStringU(M.ReadLong(Address + 0x20));

		public override string ToString()
		{
			return Name;
		}
	}
}