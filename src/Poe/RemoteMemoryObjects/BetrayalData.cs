using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalData : RemoteMemoryObject
	{
		public List<BetrayalSyndicateState> BetrayalStates
		{
			get
			{
				//This offsets seems good too https://dl.dropboxusercontent.com/s/2csb82ba4mmm2ee/StructureSpiderAdvanced_2018-12-29_02-42-18.png
				var betrayalStateAddr = M.ReadLong(Address + 0x110, 0x178, 0x178, 0x178, 0x4A0);
				return M.ReadStructsArray<BetrayalSyndicateState>(betrayalStateAddr,betrayalStateAddr + BetrayalSyndicateState.STRUCT_SIZE * 14, BetrayalSyndicateState.STRUCT_SIZE, 20);
			}
		}

		public BetrayalEventState BetrayalEventStates => GetObject<BetrayalEventState>(M.ReadLong(Address + 0xA50, 0xAD8, 0xB48, 0x7B8));
	}
}
