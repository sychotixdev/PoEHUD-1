using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Linq;
using System.Windows.Forms;
using PoeHUD.Framework;
using System.Collections.Generic;

namespace PoeHUD.Hud.Menu
{
    public class HotkeyButton : MenuItem
    {
        public readonly string Name;
        private readonly HotkeyNode node;
        private bool bKeysScan;
        private IEnumerable<Keys> KeyCodes;

        public HotkeyButton(string name, HotkeyNode node)
        {
            Name = name;
            this.node = node;

            KeyCodes = Enum.GetValues(typeof(Keys)).Cast<Keys>();
        }

        public override int DesiredWidth => 180;
        public override int DesiredHeight => 25;

        public override void Render(Graphics graphics, MenuSettings settings)
        {
            if (!IsVisible) { return; }

            var textPosition = new Vector2(Bounds.X - 50 + Bounds.Width / 3, Bounds.Y + Bounds.Height / 2);

            var buttonDisplayName = Name + ": " + (bKeysScan ? "Press any key..." : "[" + node.Value.ToString() + "]");
            graphics.DrawText(buttonDisplayName, settings.MenuFontSize, textPosition, settings.MenuFontColor, FontDrawFlags.VerticalCenter | FontDrawFlags.Left);
            graphics.DrawImage("menu-background.png", new RectangleF(Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height), settings.BackgroundColor);


            if (Children.Count > 0)
            {
                float width = (Bounds.Width - 2) * 0.08f;
                float height = (Bounds.Height - 2) / 2;
                var imgRect = new RectangleF(Bounds.X + Bounds.Width - 1 - width, Bounds.Y + 1 + height - height / 2, width, height);
                graphics.DrawImage("menu-arrow.png", imgRect);
            }
            Children.ForEach(x => x.Render(graphics, settings));

            if(bKeysScan)
            {
                foreach (var key in KeyCodes)
                {
                    if(WinApi.IsKeyDown(key))
                    {
                        if(key != Keys.Escape)
                        {
                            node.Value = key;
                        }

                        bKeysScan = false;
                        break;
                    }
                }
            }
        }

         
        protected override void HandleEvent(MouseEventID id, Vector2 pos)
        {
            if (id == MouseEventID.LeftButtonDown)
            {
                bKeysScan = true;
            }
        }

        public override void SetHovered(bool hover)
        {
            if (!hover)
                bKeysScan = false;

            Children.ForEach(x =>
            {
                x.SetVisible(hover);
            });
        }
    }
}