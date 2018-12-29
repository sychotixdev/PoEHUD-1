using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalRank : RemoteMemoryObject
	{
		public string Id => M.ReadStringU(M.ReadLong(Address));
		public string Name => M.ReadStringU(M.ReadLong(Address + 0x8));
		public int Unknown => M.ReadInt(Address + 0x10);
		public string Art => M.ReadStringU(M.ReadLong(Address + 0x14));

		public override string ToString()
		{
			return Name;
		}
	}
}
