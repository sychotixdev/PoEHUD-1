using SharpDX;
using System.Collections.Generic;
using System.Linq;

namespace PoeHUD.Poe
{
    public class Element : RemoteMemoryObject
    {
        public const int OffsetBuffers = 0x76C;
        // dd id
        // dd (something zero)
        // 16 dup <128-bytes structure>
        // then the rest is

        public int vTable => M.ReadInt(Address + 0);
        public Element Root => ReadObject<Element>(Address + 0x6c + OffsetBuffers);
        public Element Parent => ReadObject<Element>(Address + 0x70 + OffsetBuffers);
        public float X => M.ReadFloat(Address + 0x74 + OffsetBuffers);
        public float Y => M.ReadFloat(Address + 0x78 + OffsetBuffers);
        public float Width => M.ReadFloat(Address + 0x110 + OffsetBuffers);
        public float Height => M.ReadFloat(Address + 0x114 + OffsetBuffers);
        public int ChildCount => (M.ReadInt(Address + 0x20 + OffsetBuffers) - M.ReadInt(Address + 0x1C + OffsetBuffers)) / 4;
        public bool IsVisibleLocal => (M.ReadInt(Address + 0x68 + OffsetBuffers) & 1) == 1;

        public bool IsVisible
        {
            get { return IsVisibleLocal && GetParentChain().All(current => current.IsVisibleLocal); }
        }

        public List<Element> Children => GetChildren<Element>();

        protected List<T> GetChildren<T>() where T : Element, new()
        {
            const int listOffset = 0x1C + OffsetBuffers;
            var list = new List<T>();
            if (M.ReadInt(Address + listOffset + 4) == 0 || M.ReadInt(Address + listOffset) == 0 ||
                ChildCount > 1000)
            {
                return list;
            }
            for (int i = 0; i < ChildCount; i++)
            {
                list.Add(GetObject<T>(M.ReadInt(Address + listOffset, i * 4)));
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
            foreach (Element current in GetParentChain())
            {
                num += current.X;
                num2 += current.Y;
            }
            return new Vector2(num, num2);
        }

        public RectangleF GetClientRect()
        {
            var vPos = GetParentPos();
            float width = Game.IngameState.Camera.Width;
            float height = Game.IngameState.Camera.Height;
            float ratioFixMult = width / height / 1.6f;
            float xScale = width / 2560f / ratioFixMult;
            float yScale = height / 1600f;

            float num = (vPos.X + X) * xScale;
            float num2 = (vPos.Y + Y) * yScale;
            return new RectangleF(num, num2, xScale * Width, yScale * Height);
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
            return index >= ChildCount ? null : GetObject<Element>(M.ReadInt(Address + 0x1C + OffsetBuffers, index * 4));
        }
    }
}