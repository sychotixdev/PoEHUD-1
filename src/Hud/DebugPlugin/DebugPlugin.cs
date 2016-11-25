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

namespace PoeHUD.Hud.DebugPlug
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

        public override void Render()
        {
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
        private void ClearLog()
        {
            DebugLog.Clear();
            DebugDrawInfo.Clear();
        }
        
        //If delay is -1 message will newer be destroyed
        public static void LogMsg(object o, float delay, Color color)
        {
            DebugLog.Add(new DisplayMessage(o.ToString(), delay, color));
        }

        //Show the message without destroying
        public static void LogInfoMsg(object o)
        {
            DebugDrawInfo.Add(o.ToString());
        }

        public static List<DisplayMessage> DebugLog = new List<DisplayMessage>();
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
