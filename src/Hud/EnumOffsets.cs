using System;
using System.Runtime.InteropServices;

namespace PoeHUD.Hud
{

    public class EnumOffsets
    {
        public long AreaChangeCountOffset = 0x1C0B558;
        public long FileRootBaseOffset = 0x39D88050;
        public long GameStateBaseOffset = 0x1E441B0;
        [StructLayout(LayoutKind.Explicit)]
        public struct FileRoot
        {
            [FieldOffset(0x8)] public readonly IntPtr start;
            [FieldOffset(0x10)] public readonly long count;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct GameStateController
        {
            [FieldOffset(0x8)] public readonly IntPtr currentGameStates;
            [FieldOffset(0x20)] public readonly IntPtr activeGameStatesStart;
            [FieldOffset(0x30)] public readonly IntPtr activeGameStatesEnd;
            [FieldOffset(0x48)] public readonly IntPtr allGameStates;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct GameStateHashNode
        {
            [FieldOffset(0x0)] public readonly IntPtr previous;
            [FieldOffset(0x8)] public readonly IntPtr root;
            [FieldOffset(0x10)] public readonly IntPtr next;
            [FieldOffset(0x19)] public readonly byte IsNull;
            [FieldOffset(0x20)] public readonly IntPtr key;
            [FieldOffset(0x40)] public readonly IntPtr value1;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct GameState
        {
            [FieldOffset(0x10)] public readonly IntPtr stateName;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct AreaLoadingState
        {
            [FieldOffset(0x10)] public readonly IntPtr stateName;
            [FieldOffset(0xD8)] public readonly IntPtr isLoading;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct IngameState
        {
            [FieldOffset(0x78)] public readonly IntPtr ingameUi;
            [FieldOffset(0x370)] public readonly IntPtr ingameData;
            [FieldOffset(0x378)] public readonly IntPtr serverData;
            [FieldOffset(0x4A0)] public readonly IntPtr uiRoot;
            [FieldOffset(0xF4C)] public readonly IntPtr camera;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Camera
        {
            [FieldOffset(0x4)] public readonly int width;
            [FieldOffset(0x8)] public readonly int height;
            [FieldOffset(0xD4)] public readonly float positionX;
            [FieldOffset(0xD8)] public readonly float positionY;
            [FieldOffset(0xDC)] public readonly float positionZ;
            [FieldOffset(0x1C8)] public readonly float zFar;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct IngameData
        {
            [FieldOffset(0xCC)] public readonly uint currentAreaHash;
            [FieldOffset(0x408)] public readonly IntPtr localPlayer;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Entity
        {
            [FieldOffset(0x0)] public readonly IntPtr entityInternal;
            [FieldOffset(0x8)] public readonly IntPtr componentList;
            [FieldOffset(0x50)] public readonly IntPtr positionedComp;
            [FieldOffset(0x58)] public readonly int inventoryId;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct EntityInternal
        {
            [FieldOffset(0x18)] public readonly IntPtr path;
            [FieldOffset(0x40)] public readonly IntPtr componentLookupPart1;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct EntityComponentLookupPart2
        {
            [FieldOffset(0x30)] public readonly IntPtr componentLookupPart2;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct EntityList
        {
            [FieldOffset(0x0)] public readonly IntPtr entities;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct EntityListEntry
        {
            [FieldOffset(0x0)] public readonly IntPtr previous;
            [FieldOffset(0x10)] public readonly IntPtr next;
            [FieldOffset(0x28)] public readonly IntPtr entity;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Element
        {
            [FieldOffset(0x38)] public readonly IntPtr childStart;
            [FieldOffset(0x40)] public readonly IntPtr childEnd;
            [FieldOffset(0x88)] public readonly IntPtr rootPart1;
            [FieldOffset(0x90)] public readonly IntPtr parent;
            [FieldOffset(0x98)] public readonly float x;
            [FieldOffset(0x9C)] public readonly float y;
            [FieldOffset(0x108)] public readonly float scale;
            [FieldOffset(0x111)] public readonly byte isVisibleLocal;
            [FieldOffset(0x130)] public readonly float width;
            [FieldOffset(0x134)] public readonly float height;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct ElementRootPart2
        {
            [FieldOffset(0xE8)] public readonly IntPtr rootPart2;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct IngameUIElements
        {
            [FieldOffset(0x260)] public readonly IntPtr flaskBarPart1;
            [FieldOffset(0x5A0)] public readonly IntPtr map;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct IngameUIElementsFlaskBarPart2
        {
            [FieldOffset(0x1B0)] public readonly IntPtr flaskBarPart2;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Map
        {
            [FieldOffset(0x230)] public readonly IntPtr largeMap;
            [FieldOffset(0x238)] public readonly IntPtr smallMinimap;
            [FieldOffset(0x250)] public readonly IntPtr orangeWords;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct MapInfo
        {
            [FieldOffset(0x1C0)] public readonly float mapShiftX;
            [FieldOffset(0x1C4)] public readonly float mapShiftY;
            [FieldOffset(0x204)] public readonly float mapZoom;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct ServerData
        {
            [FieldOffset(0x6670)] public readonly IntPtr playerInventoriesFirstAddress;
            [FieldOffset(0x6678)] public readonly IntPtr playerInventoriesLastAddress;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct InventoryHolder
        {
            [FieldOffset(0x0)] public readonly int id;
            [FieldOffset(0x8)] public readonly IntPtr inventory;
            [FieldOffset(0x19)] public readonly byte fakeToSetSize;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct HashNode
        {
            [FieldOffset(0x0)] public readonly IntPtr previous;
            [FieldOffset(0x8)] public readonly IntPtr root;
            [FieldOffset(0xC)] public readonly IntPtr next;
            [FieldOffset(0x19)] public readonly byte isNull;
            [FieldOffset(0x20)] public readonly int key;
            [FieldOffset(0x28)] public readonly int value1;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct InventorySlotItem
        {
            [FieldOffset(0x0)] public readonly IntPtr item;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct ServerInventory
        {
            [FieldOffset(0x0)] public readonly int inventoryType;
            [FieldOffset(0x4)] public readonly int inventorySlot;
            [FieldOffset(0xC)] public readonly int columns;
            [FieldOffset(0x10)] public readonly int rows;
            [FieldOffset(0x30)] public readonly IntPtr inventoryAddress;
            [FieldOffset(0x48)] public readonly IntPtr inventorySlotItems;
            [FieldOffset(0x50)] public readonly int totalItemsCount;
        }


    }
}
