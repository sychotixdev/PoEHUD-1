using System;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Controllers;

namespace PoeHUD.Models.Legacy
{
    [Obsolete]
    public class LegacyInventory
    {
        private readonly Poe.RemoteMemoryObjects.Inventory InternalInventory;
        private readonly GameController Poe;

        public int Width => InternalInventory.Width;

        public int Height => InternalInventory.Height;

        public List<EntityWrapper> Items
        {
            get
            {
                return InternalInventory.Items.Select(current => new EntityWrapper(Poe, current)).ToList();
            }
        }

        public LegacyInventory(GameController poe, Poe.RemoteMemoryObjects.Inventory internalInventory)
        {
            Poe = poe;
            InternalInventory = internalInventory;
        }

        public LegacyInventory(GameController poe, int address) : this(poe, poe.Game.GetObject<Poe.RemoteMemoryObjects.Inventory>(address))
        {
        }
    }
}