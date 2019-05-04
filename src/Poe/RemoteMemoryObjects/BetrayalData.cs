using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalData : RemoteMemoryObject
	{
		public BetrayalSyndicateLeadersData SyndicateLeadersData => GetObject<BetrayalSyndicateLeadersData>(M.ReadLong(Address + 0x288));

		public List<BetrayalSyndicateState> SyndicateStates
		{
			get
			{
				var betrayalStateAddr = M.ReadLong(Address + 0x2D0);
				return M.ReadStructsArray<BetrayalSyndicateState>(betrayalStateAddr, betrayalStateAddr + BetrayalSyndicateState.STRUCT_SIZE * 14, BetrayalSyndicateState.STRUCT_SIZE, 20);
			}
		}

		public BetrayalEventData BetrayalEventData
		{
			get
			{
				var addr = M.ReadLong(Address + 0x2E8, 0x2F0);
				return addr == 0 ? null : GetObject<BetrayalEventData>(addr);
			}
		}
	}
}