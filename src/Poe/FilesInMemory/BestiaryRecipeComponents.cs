using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.FilesInMemory
{
    public class BestiaryRecipeComponents : FileInMemory
    {
        //We mark this fields as private coz we don't allow to read them directly. Optimisation. Use methods instead
        private readonly Dictionary<int, BestiaryRecipeComponent> RecipeComponentsDictionary = new Dictionary<int, BestiaryRecipeComponent>();
        private readonly Dictionary<long, BestiaryRecipeComponent> RecipeComponentsAddressDictionary = new Dictionary<long, BestiaryRecipeComponent>();
        private readonly List<BestiaryRecipeComponent> RecipeComponentsList = new List<BestiaryRecipeComponent>();

        public List<BestiaryRecipeComponent> DebugList
        {
            get
            {
                CheckCache();
                return RecipeComponentsList;
            }
        }

        public BestiaryRecipeComponents(Memory m, long address)
            : base(m, address)
        {
        }

        public BestiaryRecipeComponent GetRecipeComponentById(int id)
        {
            CheckCache();

            BestiaryRecipeComponent result;
            RecipeComponentsDictionary.TryGetValue(id, out result);
            return result;
        }

        public BestiaryRecipeComponent GetRecipeComponentByAddress(long address)
        {
            CheckCache();
            BestiaryRecipeComponent result;
            RecipeComponentsAddressDictionary.TryGetValue(address, out result);
            return result;
        }

        public void CheckCache()
        {
            if (RecipeComponentsDictionary.Count != 0)
                return;

            var idCounter = 0;
            foreach (long addr in RecordAddresses())
            {
                var r = GameController.Instance.Game.IngameState.GetObject<BestiaryRecipeComponent>(addr);
                r.Id = idCounter++;

                if (!RecipeComponentsDictionary.ContainsKey(r.Id))
                {
                    RecipeComponentsAddressDictionary.Add(addr, r);
                    RecipeComponentsDictionary.Add(r.Id, r);
                    RecipeComponentsList.Add(r);
                }
            }
        }
    }
}