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
    public class BestiaryRecipes : FileInMemory
    {
        //We mark this fields as private coz we don't allow to read them directly. Optimisation. Use methods instead
        private readonly Dictionary<int, BestiaryRecipe> RecipesDictionary = new Dictionary<int, BestiaryRecipe>();
        private readonly List<BestiaryRecipe> RecipesList = new List<BestiaryRecipe>();

        public List<BestiaryRecipe> DebugList
        {
            get
            {
                CheckCache();
                return RecipesList;
            }
        }

        public BestiaryRecipes(Memory m, long address)
            : base(m, address)
        {
        }

        public BestiaryRecipe GetRecipeById(int id)
        {
            CheckCache();

            BestiaryRecipe result;
            RecipesDictionary.TryGetValue(id, out result);
            return result;
        }

        public BestiaryRecipe GetRecipeByAddress(long address)
        {
            CheckCache();
            return RecipesList.Find(x => x.Address == address);
        }

        public void CheckCache()
        {
            if (RecipesDictionary.Count != 0)
                return;

            var idCounter = 0;
            foreach (long addr in RecordAddresses())
            {
                var r = GameController.Instance.Game.IngameState.GetObject<BestiaryRecipe>(addr);
                r.Id = idCounter++;

                if (!RecipesDictionary.ContainsKey(r.Id))
                {
                    RecipesDictionary.Add(r.Id, r);
                    RecipesList.Add(r);
                }
            }
        }
    }
}