using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalData : RemoteMemoryObject
	{
		public BetrayalSyndicateLeadersData SyndicateLeadersData => ReadObjectAt<BetrayalSyndicateLeadersData>(0x9f0);

		public List<BetrayalSyndicateState> SyndicateStates
		{
			get
			{
				var betrayalStateAddr = M.ReadLong(Address + 0x718, 0x2D0);
				return M.ReadStructsArray<BetrayalSyndicateState>(betrayalStateAddr, betrayalStateAddr + BetrayalSyndicateState.STRUCT_SIZE * 14, BetrayalSyndicateState.STRUCT_SIZE, 20);
			}
		}

		public BetrayalEventData BetrayalEventData
		{
			get
			{
				var addr = M.ReadLong(Address + 0xA50, 0xAD8, 0xB48, 0x7B8);
				return addr == 0 ? null : GetObject<BetrayalEventData>(addr);
			}
		}
	}
}