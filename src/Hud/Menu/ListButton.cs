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
using PoeHUD.Controllers;
using Gma.System.MouseKeyHook;

namespace PoeHUD.Hud.Menu
{
    public class ListButton : MenuItem
    {
        public readonly string Name;
        private readonly ListNode node;
        private List<string> ListValues;
        private readonly List<MenuItem> SubMenuValues;
        private ToggleNode HighlightedNode;

        public ListButton(string name, ListNode node)
        {
            Name = name;
            this.node = node;
            SubMenuValues = new List<MenuItem>();
        }

        public void SetValues(List<string> values)
        {
            ListValues = values;
            if (ListValues == null) return;

            if(SubMenuValues.Count > 0)
            {
                foreach(var child in SubMenuValues)
                {
                    Children.Remove(child);
                }
                SubMenuValues.Clear();
            }
      
            foreach (var listValue in ListValues)
            {
                var buttonNode = new ToggleNode();
                buttonNode.Value = node.Value == listValue;
                if (buttonNode.Value)
                    HighlightedNode = buttonNode;

                buttonNode.OnValueChanged += delegate { ChangedValue(listValue, buttonNode); };
                var valueToggleButton = new ToggleButton(this, listValue, buttonNode, null, null);

                AddChild(valueToggleButton);
                SubMenuValues.Add(valueToggleButton);
            }
        }

        private void ChangedValue(string value, ToggleNode pressedNode)
        {
            if (HighlightedNode != null) HighlightedNode.SetValueNoEvent(false);
            pressedNode.SetValueNoEvent(true);
            HighlightedNode = pressedNode;

            node.Value = value;
            HideChildren();
        }

        public override int DesiredWidth => 180;
        public override int DesiredHeight => 25;

        public override void Render(Graphics graphics, MenuSettings settings)
        {
            if (!IsVisible) { return; }
            base.Render(graphics, settings);

            var textPosition = new Vector2(Bounds.X - 50 + Bounds.Width / 3, Bounds.Y + Bounds.Height / 2);

            var buttonDisplayName = Name + ": [" + node.Value + "]";
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
        }


        protected override void HandleEvent(MouseEventExtArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                bool visible = Children.Any(x => x.IsVisible);
                Children.ForEach(x =>
                {
                    x.SetVisible(!visible);
                });
            }
        }

        public override void SetHovered(bool hover)
        {
            CheckHoverBounds(hover);
            if (hover) return;
            HideChildren();
        }

        private void HideChildren()
        {
            Children.ForEach(x =>
            {
                x.SetVisible(false);
            });
        }
    }
}