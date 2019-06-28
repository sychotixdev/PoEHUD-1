using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Controllers;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using SharpDX;
using SharpDX.Direct3D9;

namespace PoeHUD.Hud.DebugPlugin
{
    public class DebugPlugin : SizedPlugin<DebugPluginSettings>
    {
        private static readonly List<string> _debugDrawInfo = new List<string>();
        private static readonly List<DisplayMessage> _debugLog = new List<DisplayMessage>();
        private static readonly ConcurrentDictionary<string, DisplayMessage> _messagesCache = new ConcurrentDictionary<string, DisplayMessage>();
        private readonly SettingsHub _settingsHub;

        public DebugPlugin(GameController gameController, Graphics graphics, DebugPluginSettings settings, SettingsHub settingsHub)
            : base(gameController, graphics, settings)
        {
            _settingsHub = settingsHub;
        }

        public override void Render()
        {
            if (_debugDrawInfo.Count == 0 && _debugLog.Count == 0) return;

            var startPosition = StartDrawPointFunc();
            var position = startPosition;
            var maxWidth = 0;

            position.Y += 10;
            position.X -= 100;

            foreach (var msg in _debugDrawInfo)
            {
                var size = Graphics.DrawText(msg, 15, position, Color.Green, FontDrawFlags.Right);
                position.Y += size.Height;
                maxWidth = Math.Max(size.Width, maxWidth);
            }

            _debugDrawInfo.Clear();

            foreach (var msg in _debugLog.ToList())
            {
                var displayText = msg.Message;

                if (msg.MessagesCount > 0)
                    displayText = $"({msg.MessagesCount}) {displayText}";

                var size = Graphics.DrawText(displayText, 15, position, msg.Color, FontDrawFlags.Right);

                position.Y += size.Height;
                maxWidth = Math.Max(size.Width, maxWidth);

                if (msg.Exhausted)
                {
                    _debugLog.Remove(msg);
                    _messagesCache.TryRemove(msg.Message, out _);
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

        //If delay is -1 message will newer be destroyed
        public static void LogMsg(object o, float delay)
        {
            AddNewMessage(o?.ToString() ?? "Null", delay, Color.White);
        }

        public static void LogMsg(object o, float delay, Color color)
        {
            AddNewMessage(o?.ToString() ?? "Null", delay, color);
        }

        private static void AddNewMessage(string message, float delay, Color color)
        {
            if (_messagesCache.TryGetValue(message, out var rezult))
            {
                rezult.MessagesCount++;
                rezult.UpdateTime();
                return;
            }

            rezult = new DisplayMessage(message, delay, color);
            _messagesCache.TryAdd(message, rezult);
            _debugLog?.Add(rezult);
        }

        public class DisplayMessage
        {
            public Color Color;
            private readonly float Delay;
            public string Message;
            public int MessagesCount;
            private DateTime OffTime;

            public DisplayMessage(string message, float delay, Color color)
            {
                Delay = delay;
                Message = message;
                Color = color;

                UpdateTime();
            }

            public bool Exhausted => OffTime < DateTime.Now;

            public void UpdateTime()
            {
                if (Delay != -1)
                    OffTime = DateTime.Now.AddSeconds(Delay);
                else
                    OffTime = DateTime.Now.AddDays(2);
            }
        }
    }
}
