using System;
using PoeHUD.Controllers;
using System.Collections.Generic;
using PoeHUD.Models.Enums;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameData : RemoteMemoryObject
    {
        public AreaTemplate CurrentArea => ReadObject<AreaTemplate>(Address + 0x50);
        public WorldArea CurrentWorldArea => GameController.Instance.Files.WorldAreas.GetByAddress(M.ReadLong(Address + 0x50));
        public int CurrentAreaLevel => (int)M.ReadByte(Address + 0x68);
        public uint CurrentAreaHash => M.ReadUInt(Address + 0xCC);

        public Entity LocalPlayer => GameController.Instance.Cache.Enable && GameController.Instance.Cache.LocalPlayer != null
            ? GameController.Instance.Cache.LocalPlayer
            : GameController.Instance.Cache.Enable ? GameController.Instance.Cache.LocalPlayer = LocalPlayerReal : LocalPlayerReal;
        private Entity LocalPlayerReal => ReadObject<Entity>(Address + 0x488);
        public EntityList EntityList => GetObject<EntityList>(Address + 0x510);

        private long LabDataPtr => M.ReadLong(Address + 0x11C);
        public LabyrinthData LabyrinthData => LabDataPtr == 0 ? null : GetObject<LabyrinthData>(LabDataPtr);


        public Dictionary<GameStat, int> MapStats
        {
            get
            {
                var statPtrStart = M.ReadLong(Address + 0xE0);
                var statPtrEnd = M.ReadLong(Address + 0xE8);

                int key = 0;
                int value = 0;
                int total_stats = (int)(statPtrEnd - statPtrStart);
                var bytes = M.ReadBytes(statPtrStart, total_stats);
                var result = new Dictionary<GameStat, int>(total_stats / 8);
                for (int i = 0; i < bytes.Length; i += 8)
                {
                    key = BitConverter.ToInt32(bytes, i);
                    value = BitConverter.ToInt32(bytes, i + 0x04);
                    result[(GameStat)key] = value;
                }
                return result;
            }
        }

        public List<PortalObject> TownPortals
        {
            get
            {
                var statPtrStart = M.ReadLong(Address + 0x534);
                var statPtrEnd = M.ReadLong(Address + 0x53C);

                return M.ReadStructsArray<PortalObject>(statPtrStart, statPtrEnd, PortalObject.StructSize, 20);
            }
        }
        public class PortalObject : RemoteMemoryObject
        {
            public const int StructSize = 0x38;

            public string PlayerOwner => GetObject<NativeStringReader>(Address + 0x08).Value;
            public WorldArea Area => GameController.Instance.Files.WorldAreas.GetAreaByAreaId(M.ReadInt(Address + 0x50));

            public override string ToString()
            {
                return $"{PlayerOwner} => {Area.Name}";
            }
        }
    }
}