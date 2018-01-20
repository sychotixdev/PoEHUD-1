using System.Runtime.InteropServices;
using SharpDX;
using SharpDX.Direct3D9;

namespace PoeHUD.Hud.UI.Vertexes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GuiVertex
    {
        public static readonly VertexElement[] VertexElements =
        {
            new VertexElement(0, 0, DeclarationType.Float2, DeclarationMethod.Default, DeclarationUsage.Position, 0),
            new VertexElement(0, 8, DeclarationType.Float2, DeclarationMethod.Default, DeclarationUsage.TextureCoordinate, 0),
            new VertexElement(0, 16, DeclarationType.Color, DeclarationMethod.Default, DeclarationUsage.Color, 0),

            VertexElement.VertexDeclarationEnd
        };

        public Vector2 pos;
        public Vector2 uv;
        public uint col;


        public GuiVertex(float x, float y, float u, float v, uint diffuse)
        {
            pos = new Vector2(x, y);
            uv = new Vector2(u, v);
            this.col = diffuse;
        }
    }
}