using PoeHUD.Controllers;
using PoeHUD.Hud;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoeHUD.DebugPlug
{
    public class DebugPlugin : SizedPlugin<DebugPluginSettings>
    {
        private readonly SettingsHub settingsHub;
        //private readonly GameController GameController;
        public DebugPlugin(GameController gameController, Graphics graphics, DebugPluginSettings settings, SettingsHub settingsHub)
            : base(gameController, graphics, settings)
        {
            this.settingsHub = settingsHub;
            //GameController = gameController;
        }

        private EntityWrapper LastEntity;
        protected override void OnEntityAdded(EntityWrapper entityWrapper)
        {
            LastEntity = entityWrapper;
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
        private static List<DisplayMessage> DebugLog = new List<DisplayMessage>();

        private void ClearLog()
        {
            DebugLog.Clear();
            DebugDrawInfo.Clear();
        }

        //If delay is -1 message will newer be destroyed
        public static void LogMsg(object o, float delay)
        {
            if (o == null)
                DebugLog.Add(new DisplayMessage("Null", delay, Color.White));
            else
                DebugLog.Add(new DisplayMessage(o.ToString(), delay, Color.White));
        }
        public static void LogMsg(object o, float delay, Color color)
        {
            if (o == null)
                DebugLog.Add(new DisplayMessage("Null", delay, color));
            else
                DebugLog.Add(new DisplayMessage(o.ToString(), delay, color));
        }

        //Show the message without destroying
        public static void LogInfoMsg(object o)
        {
            if (o == null)
                DebugDrawInfo.Add("Null");
            else
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
