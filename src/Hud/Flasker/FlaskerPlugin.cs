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
            CreatureType[] types = Enum.GetValues(typeof(CreatureType)).Cast<CreatureType>().ToArray();
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
                .AutoRestart(GameController.CoroutineRunner).Run();
        }

        public override void Render()
        {
            try
            {
                if (!Settings.Enable || WinApi.IsKeyDown(Keys.F10) || !GameController.InGame)
                { return; }

                RectangleF windowRectangle = GameController.Window.GetWindowRectangle();
                var windowSize = new Size2F(windowRectangle.Width / 2560, windowRectangle.Height / 1600);

                Camera camera = GameController.Game.IngameState.Camera;
                Func<HealthBar, bool> showHealthBar = x => x.IsShow(Settings.ShowEnemies);
                //Not Parallel better for performance
                //Parallel.ForEach(healthBars, x => x.Value.RemoveAll(hp => !hp.Entity.IsValid));

                foreach (HealthBar healthBar in healthBars.SelectMany(x => x.Value).Where(hp => showHealthBar(hp) && hp.Entity.IsAlive))
                {
                    Vector3 worldCoords = healthBar.Entity.Pos;
                    Vector2 mobScreenCoords = camera.WorldToScreen(worldCoords.Translate(0, 0, -170), healthBar.Entity);
                    if (mobScreenCoords != new Vector2())
                    {
                        float scaledWidth = healthBar.Settings.Width * windowSize.Width;
                        float scaledHeight = healthBar.Settings.Height * windowSize.Height;
                        Color color = healthBar.Settings.Color;
                        float hpPercent = healthBar.Life.HPPercentage;
                        float esPercent = healthBar.Life.ESPercentage;
                        float hpWidth = hpPercent * scaledWidth;
                        float esWidth = esPercent * scaledWidth;
                        var bg = new RectangleF(mobScreenCoords.X - scaledWidth / 2, mobScreenCoords.Y - scaledHeight / 2, scaledWidth, scaledHeight);
                        var windowRect = GameController.Window.GetWindowRectangle();
                        var fixNotFullscreen = new RectangleF(windowRect.X + bg.X, windowRect.Y + bg.Y, bg.Width, bg.Height);
                        if (!windowRect.Intersects(fixNotFullscreen))
                        {
                            Debug.WriteLine($"Not Intersect thing", 5);
                            continue;
                        }
                        if (hpPercent <= 0.1f)
                        {
                            color = healthBar.Settings.Under10Percent;
                        }
                        bg.Y = DrawFlatLifeAmount(healthBar.Life, hpPercent, healthBar.Settings, bg);
                        var yPosition = DrawFlatESAmount(healthBar, bg);
                        yPosition = DrawDebuffPanel(new Vector2(bg.Left, yPosition), healthBar, healthBar.Life);
                        ShowDps(healthBar, new Vector2(bg.Center.X, yPosition));
                        DrawPercents(healthBar.Settings, hpPercent, bg);
                        DrawBackground(color, healthBar.Settings.Outline, bg, hpWidth, esWidth);
                    }
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

        private void GetFlasks()
        {
            var flaskInventoryItems = GameController.Game.IngameState.ServerData.PlayerInventories
                .FirstOrDefault(x => x.Inventory.InventType == InventoryTypeE.Flask)?.Inventory?.InventorySlotItems;

            if (flaskInventoryItems == null)
                return;

            List<PlayerFlask> playerFlasks;
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

                

            }
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

        private void ProcessFlaskBase(string flaskBaseName, PlayerFlask playerFlask)
        {
            MiscBuffInfo.flaskNameToBuffConversion.TryGetValue(
                flaskBaseName, out string flaskBuffOut1));
            MiscBuffInfo.flaskNameToBuffConversion2.TryGetValue(flaskBaseName, out string flaskBuffOut2);

            if (flaskBaseName.Contains("Life"))
            {
                playerFlask.GivesHealth = true;
            }
            else if (flaskBaseName.Contains("Mana"))
            {
                playerFlask.GivesMana = true;
            }
            else if (flaskBaseName.Contains("Hybrid"))
            {
                playerFlask.GivesHealth = true;
                playerFlask.GivesMana = true;
            }
        }
    }
}
