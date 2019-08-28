using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace PoeHUD.Hud
{

    public class EnumOffsets
    {
        public long AreaChangeCountOffset = 0x1D629E4;
        public long FileRootBaseOffset = 0x1FA7AC0;
        public long GameStateBaseOffset = 0x1FA1F68;
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
            [FieldOffset(0x370)] public readonly IntPtr ingameData;
            [FieldOffset(0x378)] public readonly IntPtr serverData;
            [FieldOffset(0x4A0)] public readonly IntPtr uiRoot;
            [FieldOffset(0xF4C)] public readonly Camera camera;
            [FieldOffset(0x1388)] public readonly IntPtr ingameUi;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Camera
        {
            [FieldOffset(0x4)] public readonly int width;
            [FieldOffset(0x8)] public readonly int height;
            [FieldOffset(0x5C)] public readonly Matrix4x4 worldToScreenMatrix;
            [FieldOffset(0xD4)] public readonly float positionX;
            [FieldOffset(0xD8)] public readonly float positionY;
            [FieldOffset(0xDC)] public readonly float positionZ;
            [FieldOffset(0x1C8)] public readonly float zFar;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct IngameData
        {
            [FieldOffset(0x60)] public readonly IntPtr currentWorldArea;
            [FieldOffset(0x408)] public readonly IntPtr localPlayer;
            [FieldOffset(0x490)] public readonly EntityList entityList;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Entity
        {
            [FieldOffset(0x8)] public readonly IntPtr entityInternal;
            [FieldOffset(0x10)] public readonly IntPtr componentList;
            [FieldOffset(0x50)] public readonly uint id;
            [FieldOffset(0x60)] public readonly IntPtr positionedComp;
            [FieldOffset(0x68)] public readonly int inventoryId;
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
            [FieldOffset(0xD8)] public readonly ElementScale scaleStruct;
            [FieldOffset(0x110)] public readonly int isVisibleLocal;
            [FieldOffset(0x130)] public readonly float width;
            [FieldOffset(0x134)] public readonly float height;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct ElementScale
        {
            [FieldOffset(0x30)] public readonly float scale;
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
            [FieldOffset(0x6DB0)] public readonly IntPtr playerInventoriesFirstAddress;
            [FieldOffset(0x6DB8)] public readonly IntPtr playerInventoriesLastAddress;
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

        [StructLayout(LayoutKind.Explicit)]
        public struct ItemMods
        {
            [FieldOffset(0x0)] public readonly IntPtr modsInternal;
            [FieldOffset(0x20)] public readonly IntPtr pathPart1;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct ItemModsInternal
        {
            [FieldOffset(0x0)] public readonly int value1;
            [FieldOffset(0x4)] public readonly int value2;
            [FieldOffset(0x8)] public readonly int value3;
            [FieldOffset(0xC)] public readonly int value4;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Component
        {
            [FieldOffset(0x8)] public readonly int owner;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Base
        {
            [FieldOffset(0x10)] public readonly int namePointer;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Actor
        {
            [FieldOffset(0xF8)] public readonly int action;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Charges
        {
            [FieldOffset(0x10)] public readonly IntPtr chargesInternal;
            [FieldOffset(0x18)] public readonly int numCharges;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct ChargesInternal
        {
            [FieldOffset(0x10)] public readonly int chargesMax;
            [FieldOffset(0x14)] public readonly int chargesPerUse;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Chest
        {
            [FieldOffset(0x58)] public readonly byte isOpened;
            [FieldOffset(0x98)] public readonly int isStrongbox;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Life
        {
            [FieldOffset(0x80)] public readonly IntPtr buffsStart;
            [FieldOffset(0x88)] public readonly IntPtr buffsEnd;
            [FieldOffset(0xBC)] public readonly int maxMana;
            [FieldOffset(0xC0)] public readonly int reservedFlatMana;
            [FieldOffset(0xC4)] public readonly int curMana;
            [FieldOffset(0xC8)] public readonly int reservedPercentMana;
            [FieldOffset(0xF4)] public readonly int maxES;
            [FieldOffset(0xFC)] public readonly int curES;
            [FieldOffset(0x154)] public readonly int maxHP;
            [FieldOffset(0x158)] public readonly int reservedFlatHp;
            [FieldOffset(0x15C)] public readonly int curHp;
            [FieldOffset(0x160)] public readonly int reservedPercentHP;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Mods
        {
            [FieldOffset(0x8C)] public readonly int itemRarity;
            [FieldOffset(0x90)] public readonly IntPtr implicitModsStart;
            [FieldOffset(0x98)] public readonly IntPtr implicitModsEnd;
            [FieldOffset(0xA8)] public readonly IntPtr explicitModsStart;
            [FieldOffset(0xB0)] public readonly IntPtr explicitModsEnd;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct ObjectMagicProperties
        {
            [FieldOffset(0x7C)] public readonly int monsterRarity;
            [FieldOffset(0x98)] public readonly IntPtr modsStart;
            [FieldOffset(0xA0)] public readonly IntPtr modsEnd;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Positioned
        {
            [FieldOffset(0x58)] public readonly byte reach;
            [FieldOffset(0xEC)] public readonly int gridX;
            [FieldOffset(0xF0)] public readonly int gridY;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Render
        {
            [FieldOffset(0x78)] public readonly float x;
            [FieldOffset(0x7C)] public readonly float y;
            [FieldOffset(0x80)] public readonly float z;
            [FieldOffset(0x84)] public readonly float boundX;
            [FieldOffset(0x88)] public readonly float boundY;
            [FieldOffset(0x8C)] public readonly float boundZ;
            [FieldOffset(0x98)] public readonly IntPtr name;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Stats
        {
            [FieldOffset(0x98)] public readonly IntPtr statStart;
            [FieldOffset(0xA0)] public readonly IntPtr statEnd;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Target
        {
            [FieldOffset(0x30)] public readonly byte isTargetable;
        }


    }
}
