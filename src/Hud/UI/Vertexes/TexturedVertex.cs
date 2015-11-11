using SharpDX;
using SharpDX.Direct3D9;

namespace PoeHUD.Hud.UI.Vertexes
{
    public struct TexturedVertex
    {
        public static readonly VertexElement[] VertexElements =
        {
            new VertexElement(0, 0, DeclarationType.Float2, DeclarationMethod.Default, DeclarationUsage.Position, 0),
            new VertexElement(0, 8, DeclarationType.Float2, DeclarationMethod.Default, DeclarationUsage.TextureCoordinate, 0),
            new VertexElement(0, 16, DeclarationType.Color, DeclarationMethod.Default, DeclarationUsage.Color, 0),
            VertexElement.VertexDeclarationEnd
        };

        private Vector2 position, textureUV;

        private ColorBGRA diffuse;

        public TexturedVertex(float x, float y, float u, float v, ColorBGRA diffuse)
        {
            position = new Vector2(x, y);
            textureUV = new Vector2(u, v);
            this.diffuse = diffuse;
        }
    }
}