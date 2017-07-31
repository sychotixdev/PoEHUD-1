using PoeHUD.Models.Enums;
using System;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameState : RemoteMemoryObject
    {
        public Camera Camera => GetObject<Camera>(Address + 0x15A0 + Offsets.IgsOffsetDelta);
        
        public IngameData Data => ReadObject<IngameData>(Address + 0x138 + Offsets.IgsOffset);
        public bool InGame => ServerData.IsInGame;
        public ServerData ServerData => ReadObjectAt<ServerData>(0x13C + Offsets.IgsOffset);
        public IngameUIElements IngameUi => ReadObjectAt<IngameUIElements>(0x5E8 + Offsets.IgsOffset);
        public Element UIRoot => ReadObjectAt<Element>(0xC10 + Offsets.IgsOffset);
        public Element UIHover => ReadObjectAt<Element>(0xC14 + Offsets.IgsOffset);
        public int EntityLabelMap => M.ReadInt(Address + 0x50, 0x968);
        public DiagnosticInfoType DiagnosticInfoType => (DiagnosticInfoType)M.ReadInt(Address + 0xC84 + Offsets.IgsOffset);
        public DiagnosticElement LatencyRectangle => GetObjectAt<DiagnosticElement>(0xE9C + Offsets.IgsOffset);
        public DiagnosticElement FrameTimeRectangle => GetObjectAt<DiagnosticElement>(0x12EC + Offsets.IgsOffset);
        public DiagnosticElement FPSRectangle => GetObjectAt<DiagnosticElement>(0x1514 + Offsets.IgsOffset);
        public float CurLatency => M.ReadFloat(Address + 0xC90 + 0x13C + Offsets.IgsOffset);
        public float CurFrameTime => M.ReadFloat(Address + 0x10E0 + 0x13C + Offsets.IgsOffset);
        public float CurFps => M.ReadFloat(Address + 0x1308 + 0x13C + Offsets.IgsOffset);
        public TimeSpan TimeInGame => TimeSpan.FromMilliseconds(M.ReadInt(Address + 0xC74 + Offsets.IgsOffset));
    }
}