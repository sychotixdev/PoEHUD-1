using System;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Controllers;
using PoeHUD.EntitiesCache.CacheControllers;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.UI;
using PoeHUD.Poe.Components;
using SharpDX;
using SharpDX.Direct3D9;

namespace PoeHUD.Hud.Dps
{
    public class DpsMeterPlugin : SizedPlugin<DpsMeterSettings>
    {
        private const double DPS_PERIOD = 0.2;
        private readonly Dictionary<long, int> lastMonsters = new Dictionary<long, int>();
        private double[] AOEDamageMemory = new double[5];
        private double CurrentDmgAoe;
        private double CurrentDmgSingle;
        private double CurrentDpsAoe;
        private double CurrentDpsSingle;
        private DateTime lastTime;
        private double MaxDpsAoe;
        private double MaxDpsSingle;
        private double[] SingleDamageMemory = new double[5];

        public DpsMeterPlugin(GameController gameController, Graphics graphics, DpsMeterSettings settings)
            : base(gameController, graphics, settings)
        {
            Settings.ClearNode.OnPressed += Clear;

            lastTime = DateTime.Now;
            GameController.Area.AreaChange += area => { Clear(); };
        }

        private void Clear()
        {
            MaxDpsAoe = 0;
            MaxDpsSingle = 0;
            CurrentDpsAoe = 0;
            CurrentDpsSingle = 0;
            CurrentDmgAoe = 0;
            CurrentDmgSingle = 0;
            lastMonsters.Clear();
            lastTime = DateTime.Now;
            SingleDamageMemory = new double[5];
            AOEDamageMemory = new double[5];
            lastMonsters.Clear();
        }

        public override void Render()
        {
            if (!Settings.Enable ||
                !Settings.ShowInTown && GameController.Area.CurrentArea.IsTown ||
                !Settings.ShowInTown && GameController.Area.CurrentArea.IsHideout)
                return;

            var nowTime = DateTime.Now;
            var elapsedTime = nowTime - lastTime;

            if (elapsedTime.TotalSeconds > DPS_PERIOD)
            {
                CalculateDps(out var aoe, out var single);

                //Shift array
                //{ 1, 2, 3, 4, 5 }
                //{ 0, 1, 2, 3, 4 }
                Array.Copy(AOEDamageMemory, 0, AOEDamageMemory, 1, AOEDamageMemory.Length - 1);
                Array.Copy(SingleDamageMemory, 0, SingleDamageMemory, 1, SingleDamageMemory.Length - 1);

                AOEDamageMemory[0] = aoe;
                SingleDamageMemory[0] = single;

                if (single > 0)
                {
                    CurrentDmgAoe = aoe;
                    CurrentDmgSingle = single;
                    CurrentDpsAoe = AOEDamageMemory.Sum();
                    CurrentDpsSingle = SingleDamageMemory.Sum();

                    MaxDpsAoe = Math.Max(CurrentDpsAoe, MaxDpsAoe);
                    MaxDpsSingle = Math.Max(CurrentDpsSingle, MaxDpsSingle);
                }

                lastTime = nowTime;
            }

            var position = StartDrawPointFunc();

            var layoutFix = Settings.ShowAOE.Value ? "      " : "";
            var offsetY = 0;

            if (Settings.ShowCurrentHitDamage.Value)
            {
                if (Settings.ShowAOE.Value)
                    offsetY += Graphics.DrawText($"{CurrentDmgAoe}{layoutFix}  aoe hit", Settings.TextSize, position, Settings.DpsFontColor,
                        FontDrawFlags.Right).Height;

                offsetY += Graphics.DrawText($"{CurrentDmgSingle}{layoutFix}        hit", Settings.TextSize, position.Translate(0, offsetY),
                    Settings.PeakFontColor, FontDrawFlags.Right).Height;
            }

            if (Settings.ShowAOE.Value)
                offsetY += Graphics.DrawText($"{CurrentDpsAoe}{layoutFix} aoe dps", Settings.TextSize, position.Translate(0, offsetY),
                    Settings.PeakFontColor, FontDrawFlags.Right).Height;

            offsetY += Graphics.DrawText($"{CurrentDpsSingle}{layoutFix}       dps", Settings.TextSize, position.Translate(0, offsetY),
                Settings.PeakFontColor, FontDrawFlags.Right).Height;

            if (Settings.ShowAOE.Value)
                offsetY += Graphics.DrawText($"{MaxDpsAoe} max aoe dps", Settings.TextSize, position.Translate(0, offsetY), Settings.PeakFontColor,
                    FontDrawFlags.Right).Height;

            offsetY += Graphics.DrawText($"{MaxDpsSingle}{layoutFix} max dps", Settings.TextSize, position.Translate(0, offsetY),
                Settings.PeakFontColor, FontDrawFlags.Right).Height;

            var width = 150;
            var bounds = new RectangleF(position.X - 5 - width - 41, position.Y - 5, width + 50, offsetY + 10);

            Graphics.DrawImage("preload-start.png", bounds, Settings.BackgroundColor);
            Graphics.DrawImage("preload-end.png", bounds, Settings.BackgroundColor);

            Size = bounds.Size;
            Margin = new Vector2(0, 5);
        }

        private void CalculateDps(out int aoeDamage, out int singleDamage)
        {
            aoeDamage = 0;
            singleDamage = 0;

            foreach (var monster in MonstersController.Current.VisibleEnemyMonsters)
            {
                if (!monster.IsAlive && Settings.HasCullingStrike.Value)
                    continue;

                var life = monster.GetComponent<Life>();
                var hp = monster.IsAlive ? life.CurHP + life.CurES : 0;

                if (hp > -1000000 && hp < 10000000)
                {
                    if (lastMonsters.TryGetValue(monster.Id, out var lastHp))
                    {
                        if (lastHp != hp)
                        {
                            var dmg = lastHp - hp;

                            if (dmg > life.MaxHP + life.MaxES)
                                dmg = life.MaxHP + life.MaxES;

                            aoeDamage += dmg;
                            singleDamage = Math.Max(singleDamage, dmg);
                        }
                    }

                    lastMonsters[monster.Id] = hp;
                }
            }
        }
    }
}
