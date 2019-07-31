using PoeHUD.Poe.Elements;
using System.Collections.Generic;
using PoeHUD.Controllers;
using System;
using System.Linq;
using PoeHUD.Hud;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class IngameUIElements : StructuredRemoteMemoryObject<EnumOffsets.IngameUIElements>
	{
        public Element FlaskBar => GetObject<Element>(GetObject<IngameUIElementsFlaskBarPart2>((long)Structure.flaskBarPart1).FlaskBarPart2);
        
		public Map Map => GetObject<Map>((long)Structure.map);
    }

    public class IngameUIElementsFlaskBarPart2 : StructuredRemoteMemoryObject<EnumOffsets.IngameUIElementsFlaskBarPart2>
    {
        public long FlaskBarPart2 => (long)Structure.flaskBarPart2;
    }
}

