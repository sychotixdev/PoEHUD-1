using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PoeHUD.Hud.Settings;
using PoeHUD.Poe;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.Elements;
using PoeHUD.Hud;

namespace PoeHUD.DebugPlug
{
    public class DebugPlugin : SizedPlugin<DebugPluginSettings>
    {
        private readonly SettingsHub settingsHub;
        private readonly GameController GameController;
        public DebugPlugin(GameController gameController, Graphics graphics, DebugPluginSettings settings, SettingsHub settingsHub)
            : base(gameController, graphics, settings)
        {
            this.settingsHub = settingsHub;
            GameController = gameController;
        }

        private EntityWrapper LastEntity;
        protected override void OnEntityAdded(EntityWrapper entityWrapper)
        {
            LastEntity = entityWrapper;
        }


        public override void Render()
        {

        /*

            bool found = false;
            Element uiHover = GameController.Game.IngameState.UIHover;
            var inventoryItemIcon = uiHover.AsObject<InventoryItemIcon>();

            Entity item = uiHover.ReadObject<Entity>(uiHover.Address + 0xB18);


            var mods = item.GetComponent<Mods>();

            LogMsg("ItemMods: ", -2, Color.GreenYellow);
            LogMsg("ItemLevel: " + mods.ItemLevel, -2, Color.GreenYellow);
            LogMsg("RequiredLevel: " + mods.RequiredLevel, -2, Color.GreenYellow);


            foreach (var mod in mods.ItemMods)
            {
                LogMsg("mod: '" + mod.Name + "' level: " + mod.Level + " : " + mod.Address.ToString("x"), -2, Color.GreenYellow);
            }

            LogMsg(" ", -2, Color.GreenYellow);

            if (WinApi.IsKeyDown(Keys.D0))
            {
                string saveDbg = "";
                saveDbg += "uiHoverAddr: " + uiHover.Address.ToString("x") + Environment.NewLine + Environment.NewLine;
                saveDbg += "ItemAddr: " + item.Address.ToString("x") + Environment.NewLine;

                saveDbg += "ModsAddr: " + mods.Address.ToString("x") + Environment.NewLine;

                if (LastEntity != null)
                    saveDbg += "LEnt: " + LastEntity.Address.ToString("x") + Environment.NewLine;


                System.IO.File.WriteAllText("_DBG.txt", saveDbg);
            }

            LogMsg("ItemAddr: " + item.Address.ToString("x"), -2, Color.GreenYellow);

            //LogMsg("ModsAddr: " + mods.Address.ToString("x"), -2, Color.GreenYellow);
            //LogMsg("ItemRarity: " + mods.ItemRarity, -2, Color.GreenYellow);
            */

            /*
            if (LastEntity != null)
            {
                var dat = LastEntity.GetComponent<WorldItem>();

                LogMsg($"WorldItemAddr: {dat.Address.ToString("x")}", -2, Color.GreenYellow);
                LogMsg($"WorldItemAddr.EntityAddr: {dat.ItemEntity.Address.ToString("x")}", -2, Color.GreenYellow);


            }
            */
            if (DebugDrawInfo.Count == 0 && DebugLog.Count == 0) return;

            Vector2 startPosition = StartDrawPointFunc();
            Vector2 position = startPosition;
            int maxWidth = 0;

            position.Y += 10;
            position.X -= 100;

            foreach (var msg in DebugDrawInfo)
            {
                var size = Graphics.DrawText(msg, 15, position, Color.Green, FontDrawFlags.Right);
                position.Y += size.Height;
                maxWidth = Math.Max(size.Width, maxWidth);
            }
            DebugDrawInfo.Clear();
            foreach (var msg in DebugLog.ToList())
            {
                var size = Graphics.DrawText(msg.Message, 15, position, msg.Color, FontDrawFlags.Right);

                position.Y += size.Height;
                maxWidth = Math.Max(size.Width, maxWidth);
                if (msg.Exhaust)
                {
                    DebugLog.Remove(msg);
                }
            }

            if (maxWidth <= 0) return;
            var bounds = new RectangleF(startPosition.X - maxWidth - 45, startPosition.Y - 5,
                maxWidth + 50, position.Y - startPosition.Y + 10);


            Graphics.DrawImage("preload-start.png", bounds, Color.White);
            Graphics.DrawImage("preload-end.png", bounds, Color.White);
            Size = bounds.Size;
            Margin = new Vector2(0, 5);
        }


        private static List<string> DebugDrawInfo = new List<string>();
        private static List<DisplayMessage> DebugLog = new List<DisplayMessage>();

        private void ClearLog()
        {
            DebugLog.Clear();
            DebugDrawInfo.Clear();
        }

        //If delay is -1 message will newer be destroyed
        public static void LogMsg(object o, float delay)
        {
            DebugLog.Add(new DisplayMessage(o.ToString(), delay, Color.White));
        }
        public static void LogMsg(object o, float delay, Color color)
        {
            DebugLog.Add(new DisplayMessage(o.ToString(), delay, color));
        }

        //Show the message without destroying
        public static void LogInfoMsg(object o)
        {
            DebugDrawInfo.Add(o.ToString());
        }

       
        public class DisplayMessage
        {
            public DisplayMessage(string Message, float Delay, Color Color)
            {
                this.Message = Message;
                this.Color = Color;

                if (Delay != -1)
                    OffTime = DateTime.Now.AddSeconds(Delay);
                else
                    OffTime = DateTime.Now.AddDays(2);
            }
            public string Message;
            public Color Color;

            private DateTime OffTime;
            public bool Exhaust
            {
                get
                {
                    return OffTime < DateTime.Now;
                }
            }
        }
    }
}
