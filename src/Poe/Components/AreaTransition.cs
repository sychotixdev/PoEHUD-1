using PoeHUD.Controllers;
using PoeHUD.Poe.RemoteMemoryObjects;
using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct AreaTransitionStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x22)]
        public int WorldAreaId;
        [FieldOffset(0x28)]
        public byte TransitionType;
    }

    public class AreaTransition : StructuredRemoteMemoryObject<AreaTransitionStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);
        public int WorldAreaId => Structure.WorldAreaId;
        public WorldArea WorldArea => GameController.Instance.Files.WorldAreas.GetAreaByAreaId(WorldAreaId);
        public AreaTransitionType TransitionType => (AreaTransitionType)Structure.TransitionType;

        public enum AreaTransitionType
        {
            Normal = 0,
            Local = 1,
            NormalToCorrupted = 2,
            CorruptedToNormal = 3,
            Labyrinth = 5
        }
    }
}