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
using System.Runtime.InteropServices;
using System.Threading;
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
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        public FlaskInformation FlaskInfo { get; set; } = null;
        public MiscBuffInfo MiscBuffInfo { get; set; } = null;


        public FlaskerPlugin(GameController gameController, Graphics graphics, FlaskerSettings settings)
            : base(gameController, graphics, settings)
        {
            try
            {
                LoadSettingsFiles();

                (new Coroutine(Run
                        , new WaitTime(150), nameof(FlaskerPlugin), "FlaskerPlugin Run"))
                    .AutoRestart(GameController.CoroutineRunner).Run();
            }
            catch (Exception e)
            {
                PluginLogger.LogError($"Exception! {e.ToString()}",5);
            }
        }

        public override void Render()
        {
            
        }

        public void Run()
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
                if (playerLifeComponent.HPPercentage * 100 < Settings.InstantHPPotion.Value)
                {
                    PluginLogger.LogError("Should use instant hp.", 5);
                    var foundFlask = FindFlaskMatchingAnyAction(playerFlasks, playerLifeComponent, playerBuffs, new List<FlaskActions>() { FlaskActions.Life }, true, true) ?? FindFlaskMatchingAnyAction(playerFlasks, playerLifeComponent, playerBuffs, new List<FlaskActions>() { FlaskActions.Hybrid }, true, true);
                    if (foundFlask != null && !flasksToUse.Contains(foundFlask))
                        flasksToUse.Add(foundFlask);
                    // Else, do we need to check for non-instant here?
                }
                else if (playerLifeComponent.HPPercentage * 100 < Settings.HPPotion.Value && playerBuffs.All(x => x.Name != "flask_effect_life"))
                {
                    PluginLogger.LogError("Should use hp.", 5);
                    var foundFlask = FindFlaskMatchingAnyAction(playerFlasks, playerLifeComponent, playerBuffs, new List<FlaskActions>() { FlaskActions.Life }, false) ?? FindFlaskMatchingAnyAction(playerFlasks, playerLifeComponent, playerBuffs, new List<FlaskActions>() { FlaskActions.Hybrid }, false);
                    if (foundFlask != null && !flasksToUse.Contains(foundFlask))
                        flasksToUse.Add(foundFlask);
                }

                // Next, check mana stuff
                if (playerLifeComponent.MPPercentage * 100 < Settings.InstantManaPotion.Value)
                {
                    PluginLogger.LogError("Should use instant mp.", 5);
                    var foundFlask = FindFlaskMatchingAnyAction(playerFlasks, playerLifeComponent, playerBuffs, new List<FlaskActions>() { FlaskActions.Mana }, true, true) ?? FindFlaskMatchingAnyAction(playerFlasks, playerLifeComponent, playerBuffs, new List<FlaskActions>() { FlaskActions.Hybrid }, true, true);
                    if (foundFlask != null && !flasksToUse.Contains(foundFlask))
                        flasksToUse.Add(foundFlask);
                    // Else, do we need to check for non-instant here?
                }
                else if (playerLifeComponent.MPPercentage * 100 < Settings.ManaPotion.Value && playerBuffs.All(x => x.Name != "flask_effect_mana"))
                {
                    PluginLogger.LogError("Should use mp.", 5);
                    var foundFlask = FindFlaskMatchingAnyAction(playerFlasks, playerLifeComponent, playerBuffs, new List<FlaskActions>() { FlaskActions.Mana }, false) ?? FindFlaskMatchingAnyAction(playerFlasks, playerLifeComponent, playerBuffs, new List<FlaskActions>() { FlaskActions.Hybrid }, false);
                    if (foundFlask != null && !flasksToUse.Contains(foundFlask))
                        flasksToUse.Add(foundFlask);
                }

                // Now check for cleansing

                // Now check for defensive

                // Now check for offsensive

                // now check for speed

                // Use flasks

                foreach(var flask in flasksToUse)
                {
                    Keys flaskKey = Keys.D1;
                    switch (flask.Index)
                    {
                        case 0:
                            flaskKey = Settings.Flask1;
                            break;
                        case 1:
                            flaskKey = Settings.Flask2;
                            break;
                        case 2:
                            flaskKey = Settings.Flask3;
                            break;
                        case 3:
                            flaskKey = Settings.Flask4;
                            break;
                        case 4:
                            flaskKey = Settings.Flask5;
                            break;
                    }

                    SendMessage(GameController.Window.Process.MainWindowHandle, 0x100, (int)flaskKey, 0);
                    Thread.Sleep(15);
                }

            }
            catch (Exception e)
            {
                // do nothing
                PluginLogger.LogError($"Flasker Exception: {e.ToString()}", 5);
            }
        }

        protected void LoadSettingsFiles()
        {
            var flaskFilename =  @"config/flaskinfo.json";
            var flaskBuffDetailsFileName =  @"config/FlaskBuffDetails.json";

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
            var flaskInventoryItems = GameController.Game.IngameState.ServerData.PlayerInventories?
                .FirstOrDefault(x => x.Inventory.InventType == InventoryTypeE.Flask)?.Inventory?.InventorySlotItems;

            if (flaskInventoryItems == null)
            {
                PluginLogger.LogError($"flaskInventoryItems was null PlayerInventories: { GameController.Game.IngameState.ServerData.PlayerInventories == null} " 
                                      + $"flaskInventory: {GameController.Game.IngameState.ServerData.PlayerInventories?.FirstOrDefault(x => x.Inventory.InventType == InventoryTypeE.Flask) == null} " 
                                      + $"inventoryType: {GameController.Game.IngameState.ServerData.PlayerInventories?.FirstOrDefault(x => x.Inventory.InventType == InventoryTypeE.Flask)?.Inventory == null} "
                                      + $"inventorySlotItems: {GameController.Game.IngameState.ServerData.PlayerInventories?.FirstOrDefault(x => x.Inventory.InventType == InventoryTypeE.Flask)?.Inventory?.InventorySlotItems == null} ", 5);
                return null;
            }

            List<PlayerFlask> playerFlasks = new List<PlayerFlask>();
            foreach (var inventoryItem in flaskInventoryItems)
            {
                PlayerFlask playerFlask = new PlayerFlask();

                PluginLogger.LogError("InventorySlotItem: " + inventoryItem?.ToString(), 5);

                Entity flaskEntity = inventoryItem?.Item;
                if (flaskEntity == null)
                {
                    PluginLogger.LogError("item null: " + inventoryItem?.ToString(), 5);
                    continue;
                }

                playerFlask.Index = (int)inventoryItem.InventoryPosition.X;


                var flaskPath = flaskEntity.Path;
                if (String.IsNullOrEmpty(flaskPath))
                {
                    PluginLogger.LogError("flask path null: " + inventoryItem?.ToString(), 5);
                    continue;
                }

                var baseItem = GameController.Files.BaseItemTypes.Translate(flaskPath);
                if (baseItem == null)
                {
                    PluginLogger.LogError("base item null: " + inventoryItem?.ToString(), 5);
                    continue;
                }

                Charges flaskChargesStruct = flaskEntity.GetComponent<Charges>();
                if (flaskChargesStruct == null)
                {
                    PluginLogger.LogError("flask charges null: " + inventoryItem?.ToString(), 5);
                    continue;
                }
                Mods flaskMods = flaskEntity.GetComponent<Mods>();
                if (flaskMods == null)
                {
                    PluginLogger.LogError("flask mods null: " + inventoryItem?.ToString(), 5);
                    continue;
                }
                playerFlask.Mods = flaskMods;

                var useCharge = CalculateUseCharges(flaskChargesStruct.ChargesPerUse, flaskMods.ItemMods);
                if (useCharge > 0)
                    playerFlask.TotalUses = flaskChargesStruct.NumCharges / useCharge;

                var flaskBaseComponent = flaskEntity.GetComponent<Base>();
                if (flaskBaseComponent == null)
                {
                    PluginLogger.LogError("flask base null: " + inventoryItem?.ToString(), 5);
                    continue;
                }
                var flaskBaseName = flaskBaseComponent.Name;
                if (String.IsNullOrEmpty(flaskBaseName))
                {
                    PluginLogger.LogError("flask base name is null: " + inventoryItem?.ToString(), 5);
                    continue;
                }
                playerFlask.Name = flaskBaseName;

                if (!MiscBuffInfo.flaskNameToBuffConversion.TryGetValue(
                    flaskBaseName, out string flaskBuffOut))
                {
                    PluginLogger.LogError("flaskBuffOut is not found: " + inventoryItem?.ToString(), 5);
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

            PluginLogger.LogError($"Flask: {flask.Name} {flask.Mods == null}", 5);
            ItemRarity flaskItemRarity = flask.Mods.ItemRarity;

            var itemMods = flask.Mods.ItemMods;
            if (itemMods == null)
            {
                PluginLogger.LogError($"flask itemMods null: {flask}", 5);
            }

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

        private PlayerFlask FindFlaskMatchingAnyAction(List<PlayerFlask> flasks, Life playerLifeComponent, List<Buff> playerBuffs, List<FlaskActions> flaskActions, Boolean? instant = null, Boolean ignoreBuffs = false, Func<List<FlaskActions>> ignoreFlasksWithAction = null, Boolean isCleansing = false)
        {
            // We have no flasks or settings for flasks?
            if (flasks == null)
            {
                PluginLogger.LogError($"No flask found for action {flaskActions.FirstOrDefault()} because flasks was null", 5);
                return null;
            }

            List<FlaskActions> ignoreFlaskActions = ignoreFlasksWithAction == null ? null : ignoreFlasksWithAction();

            var flaskList = flasks
                    .Where(x =>
                    FlaskHasAvailableAction(flaskActions, ignoreFlaskActions, x)
                    && CanUsePotion(x, playerLifeComponent, isCleansing)
                    && FlaskMatchesInstant(x, instant, playerLifeComponent)
                    && (ignoreBuffs || MissingFlaskBuff(x, playerBuffs))
                    ).OrderByDescending(x => flaskActions.Contains(x.Action1)).ThenByDescending(x => x.TotalUses).ToList();

            if (flaskList == null || !flaskList.Any())
            {
                PluginLogger.LogError($"No flask found for action {flaskActions.FirstOrDefault()}", 5);
                return null;
            }

            var foundFlask = flaskList.FirstOrDefault();

            PluginLogger.LogError($"Flask found for action {flaskActions.FirstOrDefault()} flask: {foundFlask}", 5);

            return flaskList.FirstOrDefault();
        }

        private bool FlaskHasAvailableAction(List<FlaskActions> flaskActions, List<FlaskActions> ignoreFlaskActions, PlayerFlask flask)
        {
            return flaskActions.Any(x => x == flask.Action1 || x == flask.Action2)
                   && (ignoreFlaskActions == null || !ignoreFlaskActions.Any(x => x == flask.Action1 || x == flask.Action2));
        }

        public Boolean CanUsePotion(PlayerFlask flask, Life playerLifeComponent, bool ignoreActionType = false)
        {
            if (flask == null)
            {
                return false;
            }

            PluginLogger.LogError(flask + " ignoreActionType " + ignoreActionType, 5);
            if (ignoreActionType)
                return true;

            PluginLogger.LogError(flask + " life " + playerLifeComponent.HPPercentage,5 );
            if (flask.Action1 == FlaskActions.Life && playerLifeComponent.HPPercentage * 100 < 99)
            {
                return true;
            }

            PluginLogger.LogError(flask + " life " + playerLifeComponent.MPPercentage, 5);
            if (flask.Action1 == FlaskActions.Mana && playerLifeComponent.MPPercentage * 100 < 99)
            {
                return true;
            }

            PluginLogger.LogError(flask + " hybrid " + playerLifeComponent.MPPercentage, 5);
            if (flask.Action1 == FlaskActions.Hybrid && !(playerLifeComponent.HPPercentage * 100 < 99 || playerLifeComponent.MPPercentage * 100 < 99))
            {
                return true;
            }

            return false;
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

        private bool MissingFlaskBuff(PlayerFlask playerFlask, List<Buff> playerBuffs)
        {
            return !playerBuffs.Any(x => x?.Name == playerFlask.BuffString1 || x?.Name == playerFlask.BuffString2);
        }
    }
}
