using SharpDX;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Controllers;
using PoeHUD.Poe.Elements;

namespace PoeHUD.Poe
{
    using RemoteMemoryObjects;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit)]
    public struct ElementMemoryStruct
    {
        [FieldOffset(0x38)]
        public long ChildrenStartPtr;
        [FieldOffset(0x40)]
        public long ChildrenEndPtr;
        [FieldOffset(0x88)]
        public long RootElementPtr;
        [FieldOffset(0x90)]
        public long ParentElementPtr;
        [FieldOffset(0x98)]
        public float X;
        [FieldOffset(0x9C)]
        public float Y;
        [FieldOffset(0x108)]
        public float Scale;
        [FieldOffset(0x111)]
        public byte IsVisibleLocal;
        [FieldOffset(0x130)]
        public float Width;
        [FieldOffset(0x134)]
        public float Height;
        [FieldOffset(0x17C)]
        public float IsHighlighted;
        [FieldOffset(0x338)]
        public long ToolTipElementPtr;
        [FieldOffset(0x3B0)]
        public long TextPtr;
    }

    public class Element : StructuredRemoteMemoryObject<ElementMemoryStruct>
    {
        public const int OffsetBuffers = 0;//0x6EC;

        // dd id
        // dd (something zero)
        // 16 dup <128-bytes structure>
        // then the rest is
        
        public long ChildCount => (Structure.ChildrenEndPtr - Structure.ChildrenStartPtr) / 8;
        public bool IsVisibleLocal => (Structure.IsVisibleLocal & 4) == 4;//(M.ReadInt(Address + 0x111 + OffsetBuffers) & 1) == 1;
        public Element Root => GetObject<Element>(Structure.RootElementPtr);
        public Element Parent => GetObject<Element>(Structure.ParentElementPtr);
        public float X => Structure.X;
        public float Y => Structure.Y;
        public Element Tooltip => GetObject<Element>(Structure.ToolTipElementPtr); //0x7F0
        public float Scale => Structure.Scale;
        public float Width => Structure.Width;
        public float Height => Structure.Height;

        // Always fix EntityLabel offset in a new patch. Don't change the line over here
        public string Text => this.AsObject<EntityLabel>().Text;
        public bool isHighlighted => Structure.IsHighlighted > 0;

        public bool IsVisible
        {
            get { return IsVisibleLocal && GetParentChain().All(current => current.IsVisibleLocal); }
        }

        public List<Element> Children => GetChildren<Element>();

        protected List<T> GetChildren<T>() where T : Element, new() {
            var list = new List<T>();
            if (Structure.ChildrenEndPtr == 0 || Structure.ChildrenStartPtr == 0 ||
                ChildCount > 1000)
            {
                return list;
            }
            for (int i = 0; i < ChildCount; i++)
            {
                list.Add(GetObject<T>(M.ReadLong(Address + 0x38, i * 8))); // TODO: Need to fix this
            }
            return list;
        }

        private IEnumerable<Element> GetParentChain()
        {
            var list = new List<Element>();
            var hashSet = new HashSet<Element>();
            Element root = Root;
            Element parent = Parent;
            while (!hashSet.Contains(parent) && root.Address != parent.Address && parent.Address != 0)
            {
                list.Add(parent);
                hashSet.Add(parent);
                parent = parent.Parent;
            }
            return list;
        }

        public Vector2 GetParentPos()
        {
            float num = 0;
            float num2 = 0;
	        var rootScale = Game.IngameState.UIRoot.Scale;
            foreach (var current in GetParentChain())
            {
                num += current.X * current.Scale / rootScale;
                num2 += current.Y * current.Scale / rootScale;
            }
            return new Vector2(num, num2);
        }

        public virtual RectangleF GetClientRect()
        {
            var vPos = GetParentPos();
            float width = Game.IngameState.Camera.Width;
            float height = Game.IngameState.Camera.Height;
            float ratioFixMult = width / height / 1.6f;
            float xScale = width / 2560f / ratioFixMult;
            float yScale = height / 1600f;

	        var rootScale = Game.IngameState.UIRoot.Scale;

            float num = (vPos.X + X * Scale / rootScale) * xScale;
            float num2 = (vPos.Y + Y * Scale / rootScale) * yScale;
            return new RectangleF(num, num2, xScale * Width * Scale / rootScale, yScale * Height * Scale / rootScale);
        }

        public Element GetChildFromIndices(params int[] indices)
        {
            Element poe_UIElement = this;
            foreach (int index in indices)
            {
                poe_UIElement = poe_UIElement.GetChildAtIndex(index);
                if (poe_UIElement == null)
                {
                    return null;
                }
            }
            return poe_UIElement;
        }

        public Element GetChildAtIndex(int index)
        {
            return index >= ChildCount ? null : GetObject<Element>(M.ReadLong(Address + 0x38, index * 8)); // TODO: This needs a new method
        }

	    public Element this[int index] => GetChildAtIndex(index);
    }
}
