using Gma.System.MouseKeyHook;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Windows.Forms;

namespace PoeHUD.Hud.Menu
{
    public class Picker<T> : MenuItem where T : struct
    {
        private readonly string name;
        private readonly RangeNode<T> node;

        public Picker(string name, RangeNode<T> node)
        {
            this.name = name;
            this.node = node;
        }

        public override int DesiredWidth => 180;
        public override int DesiredHeight => 25;

        public override void Render(Graphics graphics, MenuSettings settings)
        {
            if (!IsVisible) { return; }
            base.Render(graphics, settings);
            var textValue = $"{name} : {node.Value}";
            var textPosition = new Vector2(Bounds.X - 50 + Bounds.Width / 3, Bounds.Y + Bounds.Height / 2);
            graphics.DrawText(textValue, settings.PickerFontSize, textPosition, settings.MenuFontColor, FontDrawFlags.VerticalCenter | FontDrawFlags.Left);
            graphics.DrawImage("menu-background.png", new RectangleF(Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height), settings.BackgroundColor);
            graphics.DrawImage("menu-slider.png", new RectangleF(Bounds.X + 5, Bounds.Y + 3 * Bounds.Height / 4 + 2, Bounds.Width - 10, 3), settings.SliderColor);
            float sliderPosition = (Bounds.Width - 10) * MinusFloat(node.Value, node.Min) / MinusFloat(node.Max, node.Min);
            graphics.DrawImage("menu-picker.png", new RectangleF(Bounds.X + 5 + sliderPosition - 2, Bounds.Y + 3 * Bounds.Height / 4 + 2, 4, 4));
        }

        protected override void HandleEvent(MouseEventExtArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            CalcValue(e.X);
        }

        protected override bool TestBounds(Vector2 pos)
        {
            return base.TestBounds(pos);
        }

        private void CalcValue(float x)
        {
            float num = Bounds.X + 5;
            float num3 = 0;
            if (x > num)
            {
                float num2 = num + Bounds.Width - 10;
                num3 = x >= num2 ? 1 : (x - num) / (num2 - num);
            }

            node.Value = (T)(dynamic)Math.Round((float)(dynamic)node.Min + num3 * MinusFloat(node.Max, node.Min));
        }

        private float MinusFloat(T one, T two)
        {
            return (float)((dynamic)one - two);
        }
    }
}