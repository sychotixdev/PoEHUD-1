using System;
using SharpDX;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Hud;
using PoeHUD.Poe.Elements;

namespace PoeHUD.Poe
{
    using RemoteMemoryObjects;

    public class Element : StructuredRemoteMemoryObject<EnumOffsets.Element>
    {
        public const int OffsetBuffers = 0;//0x6EC;
        const int ChildOffset = 0x38;

        // dd id
        // dd (something zero)
        // 16 dup <128-bytes structure>
        // then the rest is
        
        public long ChildCount => ((long)Structure.childEnd -  (long)Structure.childStart) / 8;
        public bool IsVisibleLocal => (BitConverter.GetBytes(Structure.isVisibleLocal)[1] & 4) == 4;//(M.ReadInt(Address + 0x111 + OffsetBuffers) & 1) == 1;
        public Element Root => GetObject<Element>((long)GetObjectAt<ElementRootPart2>((long)Structure.rootPart1).RootPart2);
        public Element Parent => GetObject<Element>((long)Structure.parent);
        public float X => Structure.x;
        public float Y => Structure.y;
        public float Scale => Structure.scale;
        public float Width => Structure.width;
        public float Height => Structure.height;

        public bool IsVisible
        {
            get { return IsVisibleLocal && GetParentChain().All(current => current.IsVisibleLocal); }
        }

        public List<Element> Children => GetChildren<Element>();

        protected List<T> GetChildren<T>() where T : Element, new() {
           
            var list = new List<T>();
            if ((long)Structure.childEnd == 0 || (long)Structure.childStart == 0 ||
                ChildCount > 1000)
            {
                return list;
            }
            for (int i = 0; i < ChildCount; i++)
            {
                list.Add(GetObject<T>(M.ReadLong(Address + ChildOffset, i * 8)));
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
            return index >= ChildCount ? null : GetObject<Element>(M.ReadLong(Address + 0x38 + OffsetBuffers, index * 8));
        }

	    public Element this[int index] => GetChildAtIndex(index);
    }

    public class ElementRootPart2 : StructuredRemoteMemoryObject<EnumOffsets.ElementRootPart2>
    {
        public IntPtr RootPart2 => Structure.rootPart2;
    }
}
