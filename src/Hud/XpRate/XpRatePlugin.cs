using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.Preload;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using PoeHUD.Poe.Components;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PoeHUD.Hud.XpRate
{
    public class XpRatePlugin : SizedPlugin<XpRateSettings>
    {
        private string xpRate, timeLeft;
        private DateTime startTime, lastTime;
        private long startXp;
        private double levelXpPenalty, partyXpPenalty;

        public XpRatePlugin(GameController gameController, Graphics graphics, XpRateSettings settings)
            : base(gameController, graphics, settings)
        {
            GameController.Area.OnAreaChange += area => AreaChange();
        }

        public override void Render()
        {
            try
            {
                base.Render();
                if (!Settings.Enable || WinApi.IsKeyDown(Keys.F10))
                { return; }

                DateTime nowTime = DateTime.Now;
                TimeSpan elapsedTime = nowTime - lastTime;
                if (elapsedTime.TotalSeconds > 1)
                {
                    CalculateXp(nowTime);
                    partyXpPenalty = PartyXpPenalty();
                    lastTime = nowTime;
                }

                bool showInTown =
                    !Settings.ShowInTown && GameController.Area.CurrentArea.IsTown ||
                        !Settings.ShowInTown && GameController.Area.CurrentArea.IsHideout;
                Vector2 position = StartDrawPointFunc();
                string fps = $"fps:({GameController.Game.IngameState.CurFps})";
                string areaName = $"{GameController.Area.CurrentArea.DisplayName}";
                Color AreaNameColor = PreloadAlertPlugin.AreaNameColor;

                if (Settings.OnlyAreaName)
                {
                    if (!showInTown)
                    {
                        var areaNameSize = Graphics.MeasureText(areaName, Settings.TextSize);
                        float boxHeight = areaNameSize.Height;
                        float boxWidth = MathHepler.Max(areaNameSize.Width);
                        var bounds = new RectangleF(position.X - 84 - boxWidth, position.Y - 5, boxWidth + 90, boxHeight + 12);
                        string latency = $"({GameController.Game.IngameState.CurLatency})";
                        Graphics.DrawText(areaName, Settings.TextSize, new Vector2(bounds.X + 84, position.Y), AreaNameColor);
                        Graphics.DrawImage("preload-start.png", bounds, Settings.BackgroundColor);
                        Graphics.DrawImage("preload-end.png", bounds, Settings.BackgroundColor);
                        if (Settings.ShowLatency)
                        {
                            Graphics.DrawText(latency, Settings.TextSize, new Vector2(bounds.X + 35, position.Y), Settings.LatencyTextColor);
                        }
                        Size = bounds.Size;
                        Margin = new Vector2(0, 5);
                    }
                }

                if (!Settings.OnlyAreaName)
                {
                    if (!showInTown)
                    {
                        var xpReceiving = levelXpPenalty * partyXpPenalty;
                        var xpReceivingText = $"{xpRate}  *{xpReceiving:p0}";
                        string ping = $"ping:({GameController.Game.IngameState.CurLatency})";
                        Size2 areaNameSize = Graphics.DrawText(areaName, Settings.TextSize, position - 1, AreaNameColor, FontDrawFlags.Right);
                        Vector2 secondLine = position.Translate(-1, areaNameSize.Height + 2);
                        Size2 xpRateSize = Graphics.DrawText(timeLeft, Settings.TextSize, secondLine, Settings.TimeLeftColor, FontDrawFlags.Right);
                        Vector2 thirdLine = secondLine.Translate(-1, xpRateSize.Height + 2);
                        Size2 xpLeftSize = Graphics.DrawText(xpReceivingText, Settings.TextSize, thirdLine, Settings.TimeLeftColor, FontDrawFlags.Right);
                        string timer = AreaInstance.GetTimeString(nowTime - GameController.Area.CurrentArea.TimeEntered);
                        Size2 timerSize = Graphics.MeasureText(timer, Settings.TextSize);

                        float boxWidth = MathHepler.Max(xpRateSize.Width + 40, xpLeftSize.Width + 40, areaNameSize.Width + 20, timerSize.Width);
                        float boxHeight = xpRateSize.Height + xpLeftSize.Height + areaNameSize.Height;
                        var bounds = new RectangleF(position.X - boxWidth - 104, position.Y - 7, boxWidth + 110, boxHeight + 18);

                        Size2 timeFpsSize = Graphics.MeasureText(fps, Settings.TextSize);
                        var dif = bounds.Width - (12 + timeFpsSize.Width + xpRateSize.Width);
                        if (dif < 0) { bounds.X += dif; bounds.Width -= dif; }

                        Graphics.DrawText(timer, Settings.TextSize, new Vector2(bounds.X + 70, position.Y), Settings.TimerTextColor);
                        Graphics.DrawText(fps, Settings.TextSize, new Vector2(bounds.X + 70, secondLine.Y), Settings.FpsTextColor);
                        Graphics.DrawText(ping, Settings.TextSize, new Vector2(bounds.X + 70, thirdLine.Y), Settings.LatencyTextColor);
                        Graphics.DrawImage("preload-start.png", bounds, Settings.BackgroundColor);
                        Graphics.DrawImage("preload-end.png", bounds, Settings.BackgroundColor);
                        Size = bounds.Size;
                        Margin = new Vector2(0, 5);
                    }
                }
            }
            catch
            {
                // do nothing
            }
        }

        private void CalculateXp(DateTime nowTime)
        {
            int level = GameController.Player.GetComponent<Player>().Level;
            if (level >= 100)
            {
                // player can't level up, just show fillers
                xpRate = "0.00 xp/h";
                timeLeft = "--h--m--s";
                return;
            }
            long currentXp = GameController.Player.GetComponent<Player>().XP;
            double rate = (currentXp - startXp) / (nowTime - startTime).TotalHours;
            xpRate = $"{ConvertHelper.ToShorten(rate, "0.00")} xp/h";
            if (level >= 0 && level + 1 < Constants.PlayerXpLevels.Length && rate > 1)
            {
                long xpLeft = Constants.PlayerXpLevels[level + 1] - currentXp;
                TimeSpan time = TimeSpan.FromHours(xpLeft / rate);
                timeLeft = $"{time.Hours:0}h {time.Minutes:00}m {time.Seconds:00}s to level up";
            }
        }

        private double LevelXpPenalty()
        {
            int arenaLevel = GameController.Area.CurrentArea.RealLevel;
            int characterLevel = GameController.Player.GetComponent<Player>().Level;
            double safeZone = Math.Floor(Convert.ToDouble(characterLevel) / 16) + 3;
            double effectiveDifference = Math.Max(Math.Abs(characterLevel - arenaLevel) - safeZone, 0);
            double xpMultiplier = Math.Max(Math.Pow((characterLevel + 5) / (characterLevel + 5 + Math.Pow(effectiveDifference, 2.5)), 1.5), 0.01);
            return xpMultiplier;
        }

        private double PartyXpPenalty()
        {
            var levels = GameController.Entities.Where(y => y.HasComponent<Player>()).Select(y => y.GetComponent<Player>().Level).ToList();
            int characterLevel = GameController.Player.GetComponent<Player>().Level;
            double partyXpPenalty = Math.Pow(characterLevel + 10, 2.71) / levels.Sum(level => Math.Pow(level + 10, 2.71));
            return partyXpPenalty * levels.Count;
        }

        private void AreaChange()
        {
            if (GameController.InGame)
            {
                startXp = GameController.Player.GetComponent<Player>().XP;
                levelXpPenalty = LevelXpPenalty();
            }
            startTime = lastTime = DateTime.Now;
            xpRate = "0.00 xp/h";
            timeLeft = "-h -m -s  to level up";
        }
    }
}