using PoeHUD.Hud.UI;
using SharpDX;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Controllers;
using Gma.System.MouseKeyHook;

namespace PoeHUD.Hud.Menu
{
    public abstract class MenuItem
    {
        public readonly List<MenuItem> Children;
        public bool IsVisible;
        private MenuItem currentHover;
        public string TooltipText;
        private static Vector2 MousePos;

        protected MenuItem()
        {
            Children = new List<MenuItem>();
        }

        public RectangleF Bounds { get; set; }
        public abstract int DesiredWidth { get; }
        public abstract int DesiredHeight { get; }

        public virtual void AddChild(MenuItem item)
        {
            float x = Bounds.X + Bounds.Width;
            float y = Bounds.Y + Children.Sum(current => current.Bounds.Height);
            item.Bounds = new RectangleF(x + 10, y, item.DesiredWidth, item.DesiredHeight);
            Children.Add(item);
            WrapChilds();
        }

        private void WrapChilds()
        {
            var windowRect = GameController.Instance.Window.GetWindowRectangle();

            var offsetY = (Bounds.Y + (DesiredHeight * Children.Count)) - (windowRect.Height - 20);
            if (offsetY < 0)
                return;

            for (int i = 0; i < Children.Count; i++)
            {
                var child = Children[i];
                var posY = Bounds.Y + (DesiredHeight * i) - offsetY;
                var bounds = child.Bounds;
                bounds.Y = posY;
                child.Bounds = bounds;
            }
        }

        public void OnMouseEvent(MouseEventExtArgs e, Vector2 mousePos)
        {
            MousePos = mousePos;
            if (TestBounds(mousePos))
            {
                HandleEvent(e);
                if (currentHover != null)
                {
                    currentHover.SetHovered(false);
                    currentHover = null;
                }
                return;
            }

            if (currentHover != null)
            {
                if (currentHover.TestHit(mousePos))
                {
                    currentHover.OnMouseEvent(e, mousePos);
                    return;
                }
                currentHover.SetHovered(false);
            }

            MenuItem childAt = Children.FirstOrDefault(current => current.TestHit(mousePos));
            if (childAt != null)
            {
                childAt.SetHovered(true);
                currentHover = childAt;
                return;
            }
            currentHover = null;

        }

        public virtual void Render(Graphics graphics, MenuSettings settings)
        {
            if (Bounds.Contains(MousePos) && !string.IsNullOrEmpty(TooltipText))
            {
                var tooltipRect = Bounds;
                var gameWindow = GameController.Instance.Window.GetWindowRectangle();
                tooltipRect.Y = gameWindow.Top + 10;
                tooltipRect.X = gameWindow.Width/2;

                var textSize = graphics.MeasureText(TooltipText, 20);
                tooltipRect.Width = textSize.Width + 5;
                tooltipRect.Height = textSize.Height;
                tooltipRect.X -= textSize.Width / 2;

                graphics.DrawBox(tooltipRect, new Color(0, 0, 0, 230));
                graphics.DrawFrame(tooltipRect, 2, Color.Goldenrod);
                graphics.DrawText(TooltipText, 20, tooltipRect.TopLeft + new Vector2(5, 0));
            }
        }
        public virtual void SetHovered(bool hover)
        {
            CheckHoverBounds(hover);
            Children.ForEach(x => x.SetVisible(hover));
        }
        protected void CheckHoverBounds(bool hover)
        {  
            var bounds = Bounds;
            bounds.Width = hover ? DesiredWidth + 10 : DesiredWidth;
            Bounds = bounds;
        }
        public void SetVisible(bool visible)
        {
            IsVisible = visible;
            if (!visible)
            {
                Children.ForEach(x => x.SetVisible(false));
            }
        }
        public bool TestHit(Vector2 pos)
        {
            return IsVisible && (TestBounds(pos) || Children.Any(current => current.TestHit(pos)));
        }
        protected abstract void HandleEvent(MouseEventExtArgs e);
        protected virtual bool TestBounds(Vector2 pos)
        {
            return Bounds.Contains(pos);
        }
    }
}