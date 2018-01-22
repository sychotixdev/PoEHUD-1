using ImGuiNET;
using PoeHUD.Controllers;
using PoeHUD.Framework.InputHooks;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.UI.Vertexes;
using SharpDX;
using SharpDX.Direct3D9;
using SharpDX.Mathematics.Interop;
using SharpDX.Windows;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PoeHUD.Hud.UI.Renderers
{
    class ImGuiRender
    {
        private readonly Device device;
        private readonly Action<MouseInfo> onMouseDown, onMouseUp, onMouseMove;

        public ImGuiRender(Device dev, RenderForm form)
        {
            device = dev;
            IO io = ImGui.GetIO();
            io.FontAtlas.AddDefaultFont();
            UpdateCanvasSize(form.ClientSize.Width, form.ClientSize.Height);
            PrepareTextureImGui();
            SetupKeyMapping(io);
            MenuPlugin.ExternalMouseClick += OnMouseEvent;
            MouseHook.MouseWheel += OnMouseHookOnMouseWheel;
            KeyboardHook.KeyDown += OnKeyboardHookOnKeyDown;
            KeyboardHook.KeyUp += OnKeyboardHookOnKeyUp;
        }
        public void Dispose()
        {
            MenuPlugin.ExternalMouseClick -= OnMouseEvent;
            MouseHook.MouseWheel -= OnMouseHookOnMouseWheel;
            KeyboardHook.KeyDown -= OnKeyboardHookOnKeyDown;
            KeyboardHook.KeyUp -= OnKeyboardHookOnKeyUp;
        }

        private unsafe static void memcpy(void* dst, void* src, int count)
        {
            const int blockSize = 4096;
            byte[] block = new byte[blockSize];
            byte* d = (byte*)dst, s = (byte*)src;
            for (int i = 0, step; i < count; i += step, d += step, s += step)
            {
                step = count - i;
                if (step > blockSize)
                {
                    step = blockSize;
                }
                Marshal.Copy(new IntPtr(s), block, 0, step);
                Marshal.Copy(block, 0, new IntPtr(d), step);
            }
        }
        private unsafe void PrepareTextureImGui()
        {
            var io = ImGui.GetIO();
            var texDataAsRgba32 = io.FontAtlas.GetTexDataAsRGBA32();
            var t = new Texture(device, texDataAsRgba32.Width, texDataAsRgba32.Height, 1, Usage.Dynamic,
                Format.A8R8G8B8, Pool.Default);
            var rect = t.LockRectangle(0, LockFlags.None);
            for (int y = 0; y < texDataAsRgba32.Height; y++)
            {
                memcpy((byte*)(rect.DataPointer + rect.Pitch * y), texDataAsRgba32.Pixels + (texDataAsRgba32.Width * texDataAsRgba32.BytesPerPixel) * y, (texDataAsRgba32.Width * texDataAsRgba32.BytesPerPixel));
            }
            t.UnlockRectangle(0);
            io.FontAtlas.SetTexID(t.NativePointer);
            io.FontAtlas.ClearTexData();
        }
        private void SetupKeyMapping(IO io)
        {
            io.KeyMap[GuiKey.Tab] = (int)Keys.Tab;
            io.KeyMap[GuiKey.LeftArrow] = (int)Keys.Left;
            io.KeyMap[GuiKey.RightArrow] = (int)Keys.Right;
            io.KeyMap[GuiKey.UpArrow] = (int)Keys.Up;
            io.KeyMap[GuiKey.DownArrow] = (int)Keys.Down;
            io.KeyMap[GuiKey.PageUp] = (int)Keys.PageUp;
            io.KeyMap[GuiKey.PageDown] = (int)Keys.PageDown;
            io.KeyMap[GuiKey.Home] = (int)Keys.Home;
            io.KeyMap[GuiKey.End] = (int)Keys.End;
            io.KeyMap[GuiKey.Delete] = (int)Keys.Delete;
            io.KeyMap[GuiKey.Backspace] = (int)Keys.Back;
            io.KeyMap[GuiKey.Enter] = (int)Keys.Enter;
            io.KeyMap[GuiKey.Escape] = (int)Keys.Escape;
            io.KeyMap[GuiKey.A] = (int)Keys.A;
            io.KeyMap[GuiKey.C] = (int)Keys.C;
            io.KeyMap[GuiKey.V] = (int)Keys.V;
            io.KeyMap[GuiKey.X] = (int)Keys.X;
            io.KeyMap[GuiKey.Y] = (int)Keys.Y;
            io.KeyMap[GuiKey.Z] = (int)Keys.Z;
        }

        public void UpdateCanvasSize(float width, float height)
        {
            IO io = ImGui.GetIO();
            io.DisplaySize = new System.Numerics.Vector2(width, height);
            io.DisplayFramebufferScale = new System.Numerics.Vector2(width / height);
        }
        public void GetNewFrame()
        {
            ImGui.NewFrame();
        }
        public unsafe void Draw()
        {
            ImGui.Render();
            DrawData* data = ImGui.GetDrawData();
            ImGuiRenderDraw(data);
        }
        private unsafe void ImGuiRenderDraw(DrawData* drawData)
        {
            if (drawData == null)
                return;
            var io = ImGui.GetIO();
            if (io.DisplaySize.X <= 0.0f || io.DisplaySize.Y <= 0.0f)
                return;
            var st = new StateBlock(device, StateBlockType.All);
            var vp = new Viewport();
            vp.X = vp.Y = 0;
            vp.Width = (int)io.DisplaySize.X;
            vp.Height = (int)io.DisplaySize.Y;
            vp.MinDepth = 0.0f;
            vp.MaxDepth = 1.0f;
            device.Viewport = vp;
            device.PixelShader = null;
            device.VertexShader = null;
            device.SetRenderState(RenderState.CullMode, Cull.None);
            device.SetRenderState(RenderState.Lighting, false);
            device.SetRenderState(RenderState.ZEnable, false);
            device.SetRenderState(RenderState.AlphaBlendEnable, true);
            device.SetRenderState(RenderState.AlphaTestEnable, false);
            device.SetRenderState(RenderState.BlendOperation, BlendOperation.Add);
            device.SetRenderState(RenderState.SourceBlend, Blend.SourceAlpha);
            device.SetRenderState(RenderState.DestinationBlend, Blend.BothInverseSourceAlpha);
            device.SetRenderState(RenderState.ScissorTestEnable, true);
            device.SetTextureStageState(0, TextureStage.ColorOperation, TextureOperation.Modulate);
            device.SetTextureStageState(0, TextureStage.ColorArg1, TextureArgument.Texture);
            device.SetTextureStageState(0, TextureStage.ColorArg2, TextureArgument.Diffuse);
            device.SetTextureStageState(0, TextureStage.AlphaOperation, TextureOperation.Modulate);
            device.SetTextureStageState(0, TextureStage.AlphaArg1, TextureArgument.Texture);
            device.SetTextureStageState(0, TextureStage.AlphaArg2, TextureArgument.Diffuse);
            device.SetSamplerState(0, SamplerState.MinFilter, TextureFilter.Linear);
            device.SetSamplerState(0, SamplerState.MagFilter, TextureFilter.Linear);
            // Setup orthographic projection matrix
            {
                const float L = 0.5f;
                float R = io.DisplaySize.X + 0.5f;
                const float T = 0.5f;
                float B = io.DisplaySize.Y + 0.5f;
                RawMatrix mat_identity = new Matrix(1.0f, 0.0f, 0.0f, 0.0f,
                    0.0f, 1.0f, 0.0f, 0.0f,
                    0.0f, 0.0f, 1.0f, 0.0f,
                    0.0f, 0.0f, 0.0f, 1.0f);
                RawMatrix mat_projection = new Matrix(
                    2.0f / (R - L), 0.0f, 0.0f, 0.0f,
                    0.0f, 2.0f / (T - B), 0.0f, 0.0f,
                    0.0f, 0.0f, 0.5f, 0.0f,
                    (L + R) / (L - R), (T + B) / (B - T), 0.5f, 1.0f);
                device.SetTransform(TransformState.World, ref mat_identity);
                device.SetTransform(TransformState.View, ref mat_identity);
                device.SetTransform(TransformState.Projection, ref mat_projection);
            }
            using (device.VertexDeclaration = new VertexDeclaration(device, GuiVertex.VertexElements))
            {
                for (var n = 0; n < drawData->CmdListsCount; n++)
                {
                    NativeDrawList* cmdList = drawData->CmdLists[n];
                    DrawVert* vtx_buffer = (DrawVert*)cmdList->VtxBuffer.Data;
                    ushort* idx_buffer = (ushort*)cmdList->IdxBuffer.Data;

                    var myCustomVertices = new GuiVertex[cmdList->VtxBuffer.Size];
                    for (var i = 0; i < myCustomVertices.Length; i++)
                    {
                        var cl = (vtx_buffer[i].col & 0xFF00FF00) | ((vtx_buffer[i].col & 0xFF0000) >> 16) | ((vtx_buffer[i].col & 0xFF) << 16);
                        myCustomVertices[i] =
                            new GuiVertex(vtx_buffer[i].pos.X, vtx_buffer[i].pos.Y, vtx_buffer[i].uv.X, vtx_buffer[i].uv.Y, cl);
                    }

                    for (var i = 0; i < cmdList->CmdBuffer.Size; i++)
                    {
                        DrawCmd* pcmd = &((DrawCmd*)cmdList->CmdBuffer.Data)[i];
                        if (pcmd->UserCallback != IntPtr.Zero)
                        {
                            throw new NotImplementedException();
                        }
                        else
                        {
                            device.SetTexture(0, new Texture(pcmd->TextureId));
                            device.ScissorRect = new RectangleF((int)pcmd->ClipRect.X,
                                (int)pcmd->ClipRect.Y,
                                (int)(pcmd->ClipRect.Z - pcmd->ClipRect.X),
                                (int)(pcmd->ClipRect.W - pcmd->ClipRect.Y));
                            ushort[] indices = new ushort[pcmd->ElemCount];
                            for (int j = 0; j < indices.Length; j++)
                            {
                                indices[j] = idx_buffer[j];
                            }

                            device.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, myCustomVertices.Length, (int)(pcmd->ElemCount / 3), indices, Format.Index16, myCustomVertices);
                        }
                        idx_buffer += pcmd->ElemCount;
                    }
                }
            }
            st.Apply();
            st.Dispose();
        }

        void OnMouseHookOnMouseWheel(MouseInfo info)
        {
            var upOrDown = 0f;
            if (info.WheelDelta == 120)
            {
                upOrDown = 1;
            }
            else if (info.WheelDelta == 65416)
            {
                upOrDown = -1;
            }
            var delta = upOrDown;
            ImGui.GetIO().MouseWheel = delta;
        }
        void OnKeyboardHookOnKeyDown(KeyInfo info)
        {
            var io = ImGui.GetIO();
            unsafe
            {
                if (io.GetNativePointer()->WantTextInput == 1) //|| io.GetNativePointer()->WantCaptureKeyboard == 1 )
                {
                    KeyboardHook.Block = true;
                    io.KeysDown[(int)info.Keys] = true;
                }
                else
                    KeyboardHook.Block = false;
            }
        }
        void OnKeyboardHookOnKeyUp(KeyInfo info)
        {
            var io = ImGui.GetIO();
            unsafe
            {
                if (io.GetNativePointer()->WantTextInput == 1) //|| io.GetNativePointer()->WantCaptureKeyboard == 1   )
                {
                    KeyboardHook.Block = true;
                    io.KeysDown[(int)info.Keys] = false;
                    ImGui.AddInputCharacter((char)info.Keys);
                }
                else
                    KeyboardHook.Block = false;
            }
        }
        private void UpdateModifiers()
        {
            var io = ImGui.GetIO();
            io.AltPressed = Control.ModifierKeys == Keys.Alt;
            io.CtrlPressed = Control.ModifierKeys == Keys.Control;
            io.ShiftPressed = Control.ModifierKeys == Keys.Shift;
        }
        private bool OnMouseEvent(MouseEventID id, Vector2 mousePosition)
        {
            var io = ImGui.GetIO();
            io.MousePosition = new System.Numerics.Vector2(mousePosition.X, mousePosition.Y);

            if (ImGui.IsAnyWindowHovered())
            {
                switch (id)
                {
                    case MouseEventID.LeftButtonDown:
                        io.MouseDown[0] = true;
                        return true;
                    case MouseEventID.LeftButtonUp:
                        io.MouseDown[0] = false;
                        return true;
                }
            }
            return false;
        }
        /*
        private void UpdateImGuiInput()
        {
            var io = ImGui.GetIO();

            if (_form.Visible)
            {
                var point = Control.MousePosition;
                var windowPoint = GameController.Instance.Window.ScreenToClient(point.X, point.Y);
                io.MousePosition = new System.Numerics.Vector2(windowPoint.X,
                    windowPoint.Y);
            }
            else
            {
                io.MousePosition = new System.Numerics.Vector2(-1f, -1f);
            }



            UpdateModifiers();
            //Mouse button for work with HUD.
            io.MouseDown[0] = Form.MouseButtons == MouseButtons.Middle;
            io.MouseDown[1] = Form.MouseButtons == MouseButtons.Right;
            // io.MouseDown[2] = Form.MouseButtons == MouseButtons.Middle;


        }*/

        /*private bool OnMouseEvent(MouseEventID id, Vector2 position)
        {

            if (!Settings.Enable) return false;
            Mouse_Pos = position;

            if (id == MouseEventID.LeftButtonDown)
            {
                if (DrawRect.Contains(Mouse_Pos))
                {
                    bMouse_Drag = true;
                    Mouse_StartDragPos = position;
                    StartDragWinPosX = Settings.WindowPosX;
                    StartDragWinPosY = Settings.WindowPosY;
                }
            }
            else if (id == MouseEventID.LeftButtonUp)
            {
                bMouse_Drag = false;
            }
            else if (bMouse_Drag && id == MouseEventID.MouseMove)
            {
                Mouse_DragDelta = position - Mouse_StartDragPos;

                Settings.WindowPosX = StartDragWinPosX + Mouse_DragDelta.X;
                Settings.WindowPosY = StartDragWinPosY + Mouse_DragDelta.Y;

                if (Settings.WindowPosX < 0)
                    Settings.WindowPosX = 0;

                if (Settings.WindowPosY < 0)
                    Settings.WindowPosY = 0;

                var clientRect = GameController.Window.GetWindowRectangle();

                if (Settings.WindowPosX + WindowWidth > clientRect.Width)
                    Settings.WindowPosX = clientRect.Width - WindowWidth;

                if (Settings.WindowPosY + WindowHeight > clientRect.Height)
                    Settings.WindowPosY = clientRect.Height - WindowHeight;
            }


            if (id != MouseEventID.LeftButtonUp && id != MouseEventID.LeftButtonDown) return false;

            var hitWindow = DrawRect.Contains(position);

            bMouse_Click = hitWindow && id == MouseEventID.LeftButtonUp;
            if (bMouse_Click)
                Mouse_ClickPos = position;

            return hitWindow;
        }*/
    }
}
