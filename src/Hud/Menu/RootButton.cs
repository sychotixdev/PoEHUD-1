using Gma.System.MouseKeyHook;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.UI;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PoeHUD.Hud.Menu
{
    public sealed class RootButton : MenuItem
    {
        private MenuItem currentHover;
        private bool visible;
        public event Action eOnClose = delegate { };
        public static RootButton Instance;

        public RootButton(Vector2 position)
        {
            Bounds = new RectangleF(position.X - 5, position.Y - 3, DesiredWidth, DesiredHeight);
            Instance = this;
        }

        public override int DesiredWidth => 80;
        public override int DesiredHeight => 25;

        public override void AddChild(MenuItem item)
        {
            base.AddChild(item);
            float x = item.Bounds.X - DesiredWidth;
            float y = item.Bounds.Y + DesiredHeight;
            item.Bounds = new RectangleF(x, y, item.Bounds.Width, item.Bounds.Height);
        }

        public bool OnMouseEvent(MouseEventExtArgs e, Vector2 mousePos)
        {
            if(currentHover != null && currentHover.TestHit(mousePos))
            {
                currentHover.OnMouseEvent(e, mousePos);
                return e.Button != MouseButtons.None;
            }

            if(Bounds.Contains(mousePos) && e.Button == MouseButtons.Left)
            {
                ToggleRootMenu();
                return true;
            }

            MenuItem button = Children.FirstOrDefault(b => b.TestHit(mousePos));
            if(button != null)
            {
                currentHover?.SetHovered(false);
                currentHover = button;
                button.SetHovered(true);
            }
            return false;
        }

        public void ToggleRootMenu()
        {
            visible = !visible;
            if (!visible) eOnClose();

            currentHover = null;
            Children.ForEach(button => button.SetVisible(visible));
        }

        public override void Render(Graphics graphics, MenuSettings settings)
        {
            graphics.DrawText(settings.TitleName, settings.TitleFontSize, Bounds.TopLeft.Translate(25, 12), settings.TitleFontColor, FontDrawFlags.VerticalCenter | FontDrawFlags.Center);
            graphics.DrawImage("menu-background.png", Bounds, settings.BackgroundColor);
            Children.ForEach(x => x.Render(graphics, settings));
        }

        protected override void HandleEvent(MouseEventExtArgs e)
        {
        }
    }
}