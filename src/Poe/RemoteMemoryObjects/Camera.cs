using PoeHUD.Models;
using PoeHUD.Poe.Components;
using System;
using System.Numerics;
using Vector2 = SharpDX.Vector2;
using Vector3 = SharpDX.Vector3;
using Vector4 = System.Numerics.Vector4;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class Camera : RemoteMemoryObject
    {
        public int Width => M.ReadInt(Address + 0x4);
        public int Height => M.ReadInt(Address + 0x8);
        public float ZFar => M.ReadFloat(Address + 0x204);
        public Vector3 Position => new Vector3(M.ReadFloat(Address + 0x15C), M.ReadFloat(Address + 0x160), M.ReadFloat(Address + 0x164));

        //cameraarray 0x17c

        private static Vector2 oldplayerCord;

        public Vector2 WorldToScreen(Vector3 vec3, EntityWrapper entityWrapper)
        {
            Entity localPlayer = Game.IngameState.Data.LocalPlayer;
            var isplayer = localPlayer.Address == entityWrapper.Address && localPlayer.IsValid;
            var playerMoving = isplayer && localPlayer.GetComponent<Actor>().isMoving;
            float x, y;
            long addr = Address + 0xE4;
            var numRef = M.ReadBytes(addr, 0x40);
            Matrix4x4 matrix = new Matrix4x4(
                numRef[0], numRef[1], numRef[2], numRef[3],
                numRef[4], numRef[5], numRef[6], numRef[7],
                numRef[8], numRef[9], numRef[10], numRef[11],
                numRef[12], numRef[13], numRef[14], numRef[15]);
            Vector4 cord = new Vector4(vec3.X, vec3.Y, vec3.Z, 1);
            cord = Vector4.Transform(cord, matrix);
            cord = Vector4.Divide(cord, cord.W);
            x = (cord.X + 1.0f) * 0.5f * Width;
            y = (1.0f - cord.Y) * 0.5f * Height;

            var resultCord = new Vector2(x, y);
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
    }
}