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
    public class BestiaryCapturableMonster : RemoteMemoryObject
    {
        public int Id { get; internal set; }

        private string monsterName;
        public string MonsterName => monsterName != null ? monsterName :
            monsterName = M.ReadStringU(M.ReadLong(Address + 0x20));

        private MonsterVariety monsterVariety;
        public MonsterVariety MonsterVariety => monsterVariety != null ? monsterVariety :
            monsterVariety = GameController.Instance.Files.MonsterVarieties.GetByAddress(M.ReadLong(Address + 0x8));

        private BestiaryGroup bestiaryGroup;
        public BestiaryGroup BestiaryGroup => bestiaryGroup != null ? bestiaryGroup :
            bestiaryGroup = GameController.Instance.Files.BestiaryGroups.GetByAddress(M.ReadLong(Address + 0x18));

        public long BestiaryEncountersPtr => M.ReadLong(Address + 0x30);

        private BestiaryCapturableMonster bestiaryCapturableMonsterKey;
        public BestiaryCapturableMonster BestiaryCapturableMonsterKey => bestiaryCapturableMonsterKey != null ? bestiaryCapturableMonsterKey :
            bestiaryCapturableMonsterKey = GameController.Instance.Files.BestiaryCapturableMonsters.GetByAddress(M.ReadLong(Address + 0x6a));

        private BestiaryGenus bestiaryGenus;
        public BestiaryGenus BestiaryGenus => bestiaryGenus != null ? bestiaryGenus :
            bestiaryGenus = GameController.Instance.Files.BestiaryGenuses.GetByAddress(M.ReadLong(Address + 0x61));

        public override string ToString()
        {
            return $"Nane: {MonsterName}, Group: {BestiaryGroup.Name}, Family: {BestiaryGroup.Family.Name}, MonsterVariety.Name: {MonsterVariety.MonsterName}," +
                $" MonsterVariety.Id: {MonsterVariety.VarietyId}, MonsterVariety.TypeIndex: {MonsterVariety.BaseMonsterTypeIndex}";
        }
    }
}
