using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using PoeHUD.Poe.Components;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PoeHUD.Hud.Dps
{
    public class DpsMeterPlugin : SizedPlugin<DpsMeterSettings>
    {
        private const double DPS_PERIOD = 0.2;
        private DateTime lastTime;
        private readonly Dictionary<long, int> lastMonsters = new Dictionary<long, int>();
        private double MaxDps;
        private double CurrentDps;
        private double CurrentDmg;
        private double[] damageMemory = new double[5];
        private int damageMemoryIndex;

        public DpsMeterPlugin(GameController gameController, Graphics graphics, DpsMeterSettings settings)
            : base(gameController, graphics, settings)
        {
            Settings.ClearNode.OnPressed += Clear;

            lastTime = DateTime.Now;
            GameController.Area.OnAreaChange += area =>
            {
                Clear();
            };
        }

        private void Clear()
        {
            MaxDps = 0;
            CurrentDps = 0;
            CurrentDmg = 0;
            lastMonsters.Clear();
            lastTime = DateTime.Now;
            damageMemory = new double[5];
            lastMonsters.Clear();
        }


        public override void Render()
        {
            if (!Settings.Enable ||
                !Settings.ShowInTown && GameController.Area.CurrentArea.IsTown ||
                !Settings.ShowInTown && GameController.Area.CurrentArea.IsHideout)
            { return; }

            DateTime nowTime = DateTime.Now;
            TimeSpan elapsedTime = nowTime - lastTime;
            if (elapsedTime.TotalSeconds > DPS_PERIOD)
            {
                damageMemoryIndex++;
                if (damageMemoryIndex >= damageMemory.Length)
                {
                    damageMemoryIndex = 0;
                }
                var curDmg = CalculateDps(Settings.CalcAOE);
                damageMemory[damageMemoryIndex] = curDmg;

                if (curDmg > 0)
                {
                    CurrentDmg = curDmg;
                    CurrentDps = damageMemory.Sum();
                    MaxDps = Math.Max(CurrentDps, MaxDps);
                }

                lastTime = nowTime;
            }

            Vector2 position = StartDrawPointFunc();

            Size2 dpsSize = Graphics.DrawText(CurrentDps + " dps", Settings.DpsTextSize, position, Settings.DpsFontColor, FontDrawFlags.Right);
            Size2 peakSize = Graphics.DrawText(MaxDps + " top dps", Settings.PeakDpsTextSize, position.Translate(0, dpsSize.Height), Settings.PeakFontColor, FontDrawFlags.Right);

            int width = Math.Max(peakSize.Width, dpsSize.Width);
            int height = dpsSize.Height + peakSize.Height;
            var bounds = new RectangleF(position.X - 5 - width - 41, position.Y - 5, width + 50, height + 10);

            Graphics.DrawImage("preload-start.png", bounds, Settings.BackgroundColor);
            Graphics.DrawImage("preload-end.png", bounds, Settings.BackgroundColor);

            Size = bounds.Size;
            Margin = new Vector2(0, 5);
        }

        private double CalculateDps(bool aoe)
        {
            int totalDamage = 0;
            foreach (EntityWrapper monster in GameController.Entities.Where(x => x.HasComponent<Monster>() && x.IsHostile))
            {
                var life = monster.GetComponent<Life>();
                int hp = monster.IsAlive ? life.CurHP + life.CurES : 0;
                if (hp > -1000000 && hp < 10000000)
                {
                    int lastHP;
                    if (lastMonsters.TryGetValue(monster.Id, out lastHP))
                    {
                        if (lastHP != hp)
                        {
                            if (aoe)
                                totalDamage += lastHP - hp;
                            else
                                totalDamage = Math.Max(totalDamage, lastHP - hp);
                        }
                    }
                    lastMonsters[monster.Id] = hp;
                }
            }
            return totalDamage < 0 ? 0 : totalDamage;
        }
    }
}