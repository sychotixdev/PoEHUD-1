using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PoeHUD.Controllers;
using PoeHUD.EntitiesCache.CacheControllers;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using PoeHUD.Models.Enums;
using PoeHUD.Plugins;
using SharpDX;
using SharpDX.Direct3D9;

namespace PoeHUD.Hud.KillCounter
{
    public class KillCounterPlugin : SizedPlugin<KillCounterSettings>
    {
        private AreaMonstersKillStatistics _statistics;
        public int SummaryCounter;

        public KillCounterPlugin(GameController gameController, Graphics graphics, KillCounterSettings settings)
            : base(gameController, graphics, settings)
        {
            GameController.Area.AreaChange += OnAreaChange;
            MonstersController.OnMonsterDeath += OnMonsterDeath;
        }

        private void OnAreaChange(AreaController areaController)
        {
            if (!Settings.Enable)
                return;

            GetStatisticsFromCache();
        }

        private void OnMonsterDeath(MonsterDeathArgs deathInfo)
        {
            if (!Settings.Enable.Value)
                return;

            if (deathInfo.KilledByOtherPlayer) //if we want to include info that s1 killed an enemy
                return;

            GetStatisticsFromCache();

            if (deathInfo.Entity.IsAlly)
                return;
          
            var rarity = deathInfo.Entity.Rarity;
            _statistics.Counters[rarity]++;
            _statistics.AreaCounter++;
            SummaryCounter++;
        }

        public override void Render()
        {
            try
            {
                base.Render();

                if (!Settings.Enable || WinApi.IsKeyDown(Keys.F10) ||
                    !Settings.ShowInTown && GameController.Area.CurrentArea.IsTown ||
                    !Settings.ShowInTown && GameController.Area.CurrentArea.IsHideout)
                    return;

                if (_statistics == null)
                    GetStatisticsFromCache();

                var position = StartDrawPointFunc();
                var size = new Size2();

                if (Settings.ShowDetail)
                    size = DrawCounters(position);

                var session = $"({SummaryCounter - _statistics.AreaCounter})";

                var size2 = Graphics.DrawText($"kills: {_statistics.AreaCounter} {session}",
                    Settings.KillsTextSize, position.Translate(0, size.Height), Settings.TextColor, FontDrawFlags.Right);

                var width = Math.Max(size.Width, size2.Width);
                var bounds = new RectangleF(position.X - width - 46, position.Y - 5, width + 50, size.Height + size2.Height + 10);
                Graphics.DrawImage("preload-start.png", bounds, Settings.BackgroundColor);
                Graphics.DrawImage("preload-end.png", bounds, Settings.BackgroundColor);
                Size = bounds.Size;
                Margin = new Vector2(0, 5);
            }
            catch
            {
                // do nothing
            }
        }
        
        private void GetStatisticsFromCache()
        {
            if (_statistics == null)
            {
                _statistics = AreaInstance.Current.GetOrCreateDataContainer<AreaMonstersKillStatistics>();
            }
        }


        private Size2 DrawCounter(Vector2 position, string label, string counterValue, Color color)
        {
            var measuredSize1 = Graphics.MeasureText(counterValue, 16, FontDrawFlags.Right);
            var measuredSize2 = Graphics.MeasureText(label, 11, FontDrawFlags.Right);

            if (measuredSize1.Width > measuredSize2.Width)
            {
                var size = Graphics.DrawText(counterValue, 16, position, color, FontDrawFlags.Right);

                var size2 = Graphics.DrawText(label, 11, position.Translate(-size.Width / 2f, size.Height), Color.White,
                    FontDrawFlags.Center);

                return new Size2(size.Width, size.Height + size2.Height);
            }
            else
            {
                var size2 = Graphics.DrawText(label, 11, position.Translate(0, measuredSize1.Height), Color.White,
                    FontDrawFlags.Right);

                var size = Graphics.DrawText(counterValue, 16, position.Translate(-size2.Width / 2f, 0), color,
                    FontDrawFlags.Center);

                return new Size2(size2.Width, size.Height + size2.Height);
            }
        }

        private Size2 DrawCounters(Vector2 position)
        {
            const int INNER_MARGIN = 15;
            var size = DrawCounter(position, "", _statistics.Counters[MonsterRarity.White].ToString(), Color.White);

            size = new Size2(DrawCounter(position.Translate(-size.Width - INNER_MARGIN, 0), "",
                                 _statistics.Counters[MonsterRarity.Magic].ToString(), HudSkin.MagicColor).Width + size.Width + INNER_MARGIN, size.Height);

            size = new Size2(DrawCounter(position.Translate(-size.Width - INNER_MARGIN, 0), "",
                                 _statistics.Counters[MonsterRarity.Rare].ToString(), HudSkin.RareColor).Width + size.Width + INNER_MARGIN, size.Height);

            size = new Size2(DrawCounter(position.Translate(-size.Width - INNER_MARGIN, 0), "",
                                 _statistics.Counters[MonsterRarity.Unique].ToString(), HudSkin.UniqueColor).Width + size.Width + INNER_MARGIN, size.Height);

            return size;
        }

        private class AreaMonstersKillStatistics
        {
            public readonly Dictionary<MonsterRarity, int> Counters = new Dictionary<MonsterRarity, int>();
            public int AreaCounter;

            public AreaMonstersKillStatistics()
            {
                foreach (MonsterRarity rarity in Enum.GetValues(typeof(MonsterRarity)))
                {
                    Counters[rarity] = 0;
                }
            }
        }
    }
}
