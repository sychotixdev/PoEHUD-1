using PoeHUD.Models;
using PoeHUD.Poe.Components;
using System;
using System.Diagnostics;
using System.Numerics;
using PoeHUD.Controllers;
using PoeHUD.Hud;
using PoeHUD.Models.Attributes;
using Vector2 = SharpDX.Vector2;
using Vector3 = SharpDX.Vector3;
using Vector4 = System.Numerics.Vector4;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class Camera
    {
        protected EnumOffsets.Camera Structure { get; set; }
        protected TheGame Game { get; set; }
        public Camera(TheGame game, EnumOffsets.Camera structure)
        {
            this.Structure = structure;
            this.Game = game;
        }

        public int Width => Structure.width;
        public int Height => Structure.height;
        public float ZFar => Structure.zFar;
        public Vector3 Position => new Vector3(Structure.positionX, Structure.positionY, Structure.positionZ);
        //cameraarray 0x17c

        private static Vector2 oldplayerCord;


        public unsafe Vector2 WorldToScreen(Vector3 vec3, EntityWrapper entityWrapper)
        {
            Entity localPlayer = Game.IngameState.Data.LocalPlayer;
            var isplayer = localPlayer.Address == entityWrapper.Address && localPlayer.IsValid;
            bool isMoving = false;
            isMoving = localPlayer.GetComponent<Actor>().isMoving;
            var playerMoving = isplayer && isMoving;
            var resultCord = WorldToScreen(vec3);
            if (playerMoving)
            {
                if (Math.Abs(oldplayerCord.X - resultCord.X) < 40 || (Math.Abs(oldplayerCord.X - resultCord.Y) < 40))
                    resultCord = oldplayerCord;
                else
                    oldplayerCord = resultCord;
            }
            else if (isplayer)
            {
                oldplayerCord = resultCord;
            }
            return resultCord;
        }

        public Vector2 WorldToScreen(Vector3 vec3)
        {
            float x, y;
            Matrix4x4 matrix = Structure.worldToScreenMatrix;
            Vector4 cord = new Vector4(vec3.X, vec3.Y, vec3.Z, 0);
            cord.W = 1;
            cord = Vector4.Transform(cord, matrix);
            cord = Vector4.Divide(cord, cord.W);
            Debug.WriteLine($"Width {Width} Height {Height}");
            x = (cord.X + 1.0f) * 0.5f * Width;
            y = (1.0f - cord.Y) * 0.5f * Height;
            return new Vector2(x, y);
        }
    }
}