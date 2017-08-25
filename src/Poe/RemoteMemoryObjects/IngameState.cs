using PoeHUD.Models.Enums;
using System;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameState : RemoteMemoryObject
    {
        public Camera Camera => GetObject<Camera>(Address + 0x15A4 + Offsets.IgsOffsetDelta);
        
        public IngameData Data => ReadObject<IngameData>(Address + 0x140 + Offsets.IgsOffset);
        public bool InGame => ServerData.IsInGame;
        public ServerData ServerData => ReadObjectAt<ServerData>(0x144 + Offsets.IgsOffset);
        public IngameUIElements IngameUi => ReadObjectAt<IngameUIElements>(0x5F0 + Offsets.IgsOffset);
        public Element UIRoot => ReadObjectAt<Element>(0xC18 + Offsets.IgsOffset);
        public Element UIHover => ReadObjectAt<Element>(0xC1C + Offsets.IgsOffset);
        public int EntityLabelMap => M.ReadInt(Address + 0x54, 0x950);
        public DiagnosticInfoType DiagnosticInfoType => (DiagnosticInfoType)M.ReadInt(Address + 0xC8C + Offsets.IgsOffset);
        public DiagnosticElement LatencyRectangle => GetObjectAt<DiagnosticElement>(0xEA4 + Offsets.IgsOffset);
        public DiagnosticElement FrameTimeRectangle => GetObjectAt<DiagnosticElement>(0x12F4 + Offsets.IgsOffset);
        public DiagnosticElement FPSRectangle => GetObjectAt<DiagnosticElement>(0x151C + Offsets.IgsOffset);
        public float CurLatency => LatencyRectangle.CurrValue;
        public float CurFrameTime => M.ReadFloat(Address + 0x10E0 + 0x13C + Offsets.IgsOffset);
        public float CurFps => M.ReadFloat(Address + 0x1308 + 0x13C + Offsets.IgsOffset);
        public TimeSpan TimeInGame => TimeSpan.FromMilliseconds(M.ReadInt(Address + 0xC74 + Offsets.IgsOffset));
    }
}