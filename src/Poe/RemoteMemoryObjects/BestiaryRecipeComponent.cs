﻿using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;
using System.Text;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class BestiaryRecipeComponent : RemoteMemoryObject
    {
        public int Id { get; internal set; }

        private string recipeId = null;
        public string RecipeId => recipeId != null ? recipeId :
            recipeId = M.ReadStringU(M.ReadLong(Address));

        private int minLevel = -1;
        public int MinLevel => minLevel != -1 ? minLevel :
            minLevel = M.ReadInt(Address + 0x8);

        private BestiaryFamily bestiaryFamily;
        public BestiaryFamily BestiaryFamily => bestiaryFamily != null ? bestiaryFamily :
            bestiaryFamily = GameController.Instance.Files.BestiaryFamilies.GetByAddress(M.ReadLong(Address + 0x14));

        private BestiaryGroup bestiaryGroup;
        public BestiaryGroup BestiaryGroup => bestiaryGroup != null ? bestiaryGroup :
            bestiaryGroup = GameController.Instance.Files.BestiaryGroups.GetByAddress(M.ReadLong(Address + 0x24));

        private BestiaryGenus bestiaryGenus;
        public BestiaryGenus BestiaryGenus => bestiaryGenus != null ? bestiaryGenus :
            bestiaryGenus = GameController.Instance.Files.BestiaryGenuses.GetByAddress(M.ReadLong(Address + 0x58));

        //Can be null, not all have mods
        private ModsDat.ModRecord mod;
        public ModsDat.ModRecord Mod => mod != null ? mod :
            mod = GameController.Instance.Files.Mods.GetModByAddress(M.ReadLong(Address + 0x34));

        private BestiaryCapturableMonster bestiaryCapturableMonster;
        public BestiaryCapturableMonster BestiaryCapturableMonster => bestiaryCapturableMonster != null ? bestiaryCapturableMonster :
            bestiaryCapturableMonster = GameController.Instance.Files.BestiaryCapturableMonsters.GetByAddress(M.ReadLong(Address + 0x44));

        public override string ToString()
        {
            var debugStr = new StringBuilder();
            debugStr.Append($"Id: {Id}, ");


            if (MinLevel > 0)
                debugStr.Append($"MinLevel: {MinLevel}, ");

            if (Mod != null)
                debugStr.Append($"Mod: {Mod.ToString()}, ");

            if (BestiaryCapturableMonster != null)
                debugStr.Append($"MonsterName: {BestiaryCapturableMonster.MonsterName}, ");

            if (BestiaryFamily != null)
                debugStr.Append($"BestiaryFamily: {BestiaryFamily.Name}, ");

            if (BestiaryGroup != null)
                debugStr.Append($"BestiaryGroup: {BestiaryGroup.Name}, ");

            if (BestiaryGenus != null)
                debugStr.Append($"BestiaryGenus: {BestiaryGenus.Name}, ");

            return debugStr.ToString();
        }
    }
}