using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class BestiaryRecipe : RemoteMemoryObject
    {
        public int Id { get; internal set; }

        private string recipeId = null;
        public string RecipeId => recipeId != null ? recipeId : 
            recipeId = M.ReadStringU(M.ReadLong(Address));

        private string description = null;
        public string Description => description != null ? description : 
            description = M.ReadStringU(M.ReadLong(Address + 0x8));

        public bool RequireSpecialMonster => Components.Count == 4;

        private BestiaryRecipeComponent specialMonster;
        public BestiaryRecipeComponent SpecialMonster
        {
            get
            {
                if (!RequireSpecialMonster) return null;
                if(specialMonster == null)
                    specialMonster = Components.FirstOrDefault();

                return specialMonster;
            }
        }

        private List<BestiaryRecipeComponent> components;
        public List<BestiaryRecipeComponent> Components
        {
            get
            {
                if (components == null)
                {
                    var count = M.ReadInt(Address + 0x10);
                    var pointers = M.ReadSecondPointerArray_Count(M.ReadLong(Address + 0x18), count);
                    components = pointers.Select(x => GameController.Instance.Files.BestiaryRecipeComponents.GetRecipeComponentByAddress(x)).ToList();
                }
                return components;
            }
        }

        public override string ToString()
        {
            return Description + " : " + RecipeId;
        }
    }
}
