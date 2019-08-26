using Newtonsoft.Json;
using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Models;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.RemoteMemoryObjects;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PoeHUD.Hud.Flasker;
using PoeHUD.Models.Enums;
using PoeHUD.Poe;
using Color = SharpDX.Color;
using Graphics = PoeHUD.Hud.UI.Graphics;
using RectangleF = SharpDX.RectangleF;

namespace PoeHUD.Hud.Health
{
    public class FlaskerPlugin : Plugin<FlaskerSettings>
    {
        public FlaskInformation FlaskInfo { get; set; } = null;
        public MiscBuffInfo MiscBuffInfo { get; set; } = null;


        public FlaskerPlugin(GameController gameController, Graphics graphics, FlaskerSettings settings)
            : base(gameController, graphics, settings)
        {
            /*CreatureType[] types = Enum.GetValues(typeof(CreatureType)).Cast<CreatureType>().ToArray();
            healthBars = new Dictionary<CreatureType, List<HealthBar>>(types.Length);
            foreach (CreatureType type in types)
            {
                healthBars.Add(type, new List<HealthBar>());
            }

            string json = File.ReadAllText("config/debuffPanel.json");
            debuffPanelConfig = JsonConvert.DeserializeObject<DebuffPanelConfig>(json);
            (new Coroutine(() => {foreach (var healthBar in healthBars)
                {
                    healthBar.Value.RemoveAll(hp => !hp.Entity.IsValid);
                } }, new WaitRender(1), nameof(HealthBarPlugin), "RemoveAll"))
                .AutoRestart(GameController.CoroutineRunner).Run();*/
        }

        public override void Render()
        {
            try
            {
                if (!Settings.Enable || !GameController.InGame)
                { return; }

                var playerLifeComponent = GameController.Game.IngameState.Data.LocalPlayer.GetComponent<Life>();

                // Is player dead
                if (playerLifeComponent.CurHP <= 0)
                    return;

                // If we are under the grace period, don't do anything
                var playerBuffs = playerLifeComponent.Buffs;
                if (playerBuffs.Any(x => x.Name == "grace_period"))
                    return;

                // Grab flasks
                var playerFlasks = GetFlasks();

                var flasksToUse = new List<PlayerFlask>();
                // First, check for life stuff
                if (playerLifeComponent.HPPercentage * 100 < Settings.InstantHPPotion)
                {
                    
                }
            }
            catch
            {
                // do nothing
            }
        }

        protected virtual void LoadSettingsFiles()
        {
            var flaskFilename =  @"/config/flaskinfo.json";
            var flaskBuffDetailsFileName =  @"/config/FlaskBuffDetails.json";

            FlaskInfo = LoadSettingFile<FlaskInformation>(flaskFilename);
            MiscBuffInfo = LoadSettingFile<MiscBuffInfo>(flaskBuffDetailsFileName);
        }

        public static TSettingType LoadSettingFile<TSettingType>(String fileName)
        {
            if (!File.Exists(fileName))
            {
                return default;
            }

            return JsonConvert.DeserializeObject<TSettingType>(File.ReadAllText(fileName));
        }

        private List<PlayerFlask> GetFlasks()
        {
            var flaskInventoryItems = GameController.Game.IngameState.ServerData.PlayerInventories
                .FirstOrDefault(x => x.Inventory.InventType == InventoryTypeE.Flask)?.Inventory?.InventorySlotItems;

            if (flaskInventoryItems == null)
                return null;

            List<PlayerFlask> playerFlasks = new List<PlayerFlask>();
            foreach (var inventoryItem in flaskInventoryItems)
            {
                PlayerFlask playerFlask = new PlayerFlask();
                
                Entity flaskEntity = inventoryItem?.Item;
                if (flaskEntity == null)
                    continue;

                var flaskPath = flaskEntity.Path;
                if (String.IsNullOrEmpty(flaskPath))
                {
                    continue;
                }

                var baseItem = GameController.Files.BaseItemTypes.Translate(flaskPath);
                if (baseItem == null)
                {
                    continue;
                }

                Charges flaskChargesStruct = flaskEntity.GetComponent<Charges>();
                Mods flaskMods = flaskEntity.GetComponent<Mods>();

                var useCharge = CalculateUseCharges(flaskChargesStruct.ChargesPerUse, flaskMods.ItemMods);
                if (useCharge > 0)
                    playerFlask.TotalUses = flaskChargesStruct.NumCharges / useCharge;

                var flaskBaseName = flaskEntity.GetComponent<Base>().Name;

                if (String.IsNullOrEmpty(flaskBaseName))
                {
                    continue;
                }

                if (!MiscBuffInfo.flaskNameToBuffConversion.TryGetValue(
                    flaskBaseName, out string flaskBuffOut))
                {
                    continue;
                }

                playerFlask.BuffString1 = flaskBuffOut;

                if (!MiscBuffInfo.flaskNameToBuffConversion2.TryGetValue(flaskBaseName, out flaskBuffOut))
                    playerFlask.BuffString2 = "";
                else playerFlask.BuffString2 = flaskBuffOut;

                HandleFlaskMods(playerFlask);
                playerFlasks.Add(playerFlask);
            }

            return playerFlasks;
        }

        private int CalculateUseCharges(float BaseUseCharges, List<ItemMod> flaskMods)
        {
            if (!GameController.EntityListWrapper.PlayerStats.TryGetValue(GameController.Instance.Files.Stats.records["flask_charges_used_+%"].ID, out int totalChargeReduction))
                totalChargeReduction = 0;

            if (totalChargeReduction > 0)
                BaseUseCharges = ((100 + totalChargeReduction) / 100) * BaseUseCharges;
            foreach (var mod in flaskMods)
            {
                if (mod.Name.ToLower().Contains("flaskchargesused"))
                    BaseUseCharges = ((100 + (float)mod.Value1) / 100) * BaseUseCharges;
            }
            return (int)Math.Floor(BaseUseCharges);
        }

        private void HandleFlaskMods(PlayerFlask flask)
        {
            //Checking flask action based on flask name type.
            if (FlaskInfo.FlaskTypes.TryGetValue(flask.Name, out FlaskActions flaskActionOut))
                flask.Action1 = flaskActionOut;

            ItemRarity flaskItemRarity = flask.Mods.ItemRarity;

            foreach (var mod in flask.Mods.ItemMods)
            {
                string modName = mod.Name;
                if (modName.ToLower().Contains("instant"))
                {
                    if (modName.Contains("FlaskPartialInstantRecovery"))
                        flask.InstantType = FlaskInstantType.Partial;
                    else if (modName.Contains("FlaskInstantRecoveryOnLowLife"))
                        flask.InstantType = FlaskInstantType.LowLife;
                    else if (modName.Contains("FlaskFullInstantRecovery"))
                        flask.InstantType = FlaskInstantType.Full;
                }

                // We are ignoring unique flask's secondary
                if (flaskItemRarity == ItemRarity.Unique)
                    continue;

                //Checking flask mods.
                if (FlaskInfo.FlaskMods.TryGetValue(modName, out FlaskActions action2) && action2 != FlaskActions.Ignore)
                    flask.Action2 = action2;
            }
        }

        private PlayerFlask FindFlaskMatchingAnyAction(List<PlayerFlask> flasks, Life playerLifeComponent, List<string> playerBuffs, List<FlaskActions> flaskActions, Boolean? instant = null, Boolean ignoreBuffs = false, Func<List<FlaskActions>> ignoreFlasksWithAction = null, Boolean isCleansing = false)
        {
            // We have no flasks or settings for flasks?
            if (flasks == null)
            {
                return null;
            }

            List<FlaskActions> ignoreFlaskActions = ignoreFlasksWithAction == null ? null : ignoreFlasksWithAction();

            var flaskList = flasks
                    .Where(x => 
                    CanUsePotion(x, playerLifeComponent, isCleansing)
                    && FlaskMatchesInstant(x, instant, playerLifeComponent)
                    && (ignoreBuffs || MissingFlaskBuff(x, playerBuffs))
                    ).OrderByDescending(x => flaskActions.Contains(x.Action1)).ThenByDescending(x => x.TotalUses).ToList();


            if (flaskList == null || !flaskList.Any())
            {
                return null;
            }

            return flaskList.FirstOrDefault();
        }

        public Boolean CanUsePotion(PlayerFlask flask, Life playerLifeComponent, bool ignoreActionType = false)
        {
            if (flask == null)
            {
                return false;
            }

            if (ignoreActionType)
                return true;

            if (flask.Action1 == FlaskActions.Life && playerLifeComponent.HPPercentage * 100 < 99)
            {
                return false;
            }

            if (flask.Action1 == FlaskActions.Mana && playerLifeComponent.MPPercentage * 100 < 99)
            {
                return false;
            }

            if (flask.Action1 == FlaskActions.Hybrid && !(playerLifeComponent.HPPercentage * 100 < 99 || playerLifeComponent.MPPercentage * 100 < 99))
            {
                return false;
            }

            return true;
        }


        private bool FlaskMatchesInstant(PlayerFlask playerFlask, Boolean? instant, Life playerLifeComponent)
        {
            return instant == null
                   || instant == false && CanUseFlaskAsRegen(playerFlask)
                   || instant == true && CanUseFlaskAsInstant(playerFlask, playerLifeComponent);
        }

        private bool CanUseFlaskAsInstant(PlayerFlask playerFlask, Life playerLifeComponent)
        {
            // If the flask is instant, no special logic needed
            return playerFlask.InstantType == FlaskInstantType.Partial
                   || playerFlask.InstantType == FlaskInstantType.Full
                   || playerFlask.InstantType == FlaskInstantType.LowLife && playerLifeComponent.HPPercentage * 100 < 35;
        }

        private bool CanUseFlaskAsRegen(PlayerFlask playerFlask)
        {
            return playerFlask.InstantType == FlaskInstantType.None
                   || playerFlask.InstantType == FlaskInstantType.Partial
                   || playerFlask.InstantType == FlaskInstantType.LowLife;
        }

        private bool MissingFlaskBuff(PlayerFlask playerFlask, List<string> playerBuffs)
        {
            return !playerBuffs.Any(x => x == playerFlask.BuffString1 || x == playerFlask.BuffString2);
        }
    }
}
