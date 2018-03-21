using PoeHUD.Models.Enums;
using System;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameState : RemoteMemoryObject
    {
        public int EntityLabelMap => M.ReadInt(Address + 0x54, 0x958);

        public IngameData Data => ReadObject<IngameData>(Address + 0x1C0 + Offsets.IgsOffset);
        public bool InGame => ServerData.IsInGame;
        public ServerData ServerData => ReadObjectAt<ServerData>(0x1C4 + Offsets.IgsOffset);
        public IngameUIElements IngameUi => ReadObjectAt<IngameUIElements>(0x670 + Offsets.IgsOffset);
        public Element UIRoot => ReadObjectAt<Element>(0xCA8 + Offsets.IgsOffset);
        public Element UIHover => ReadObjectAt<Element>(0xCAC + Offsets.IgsOffset);

        public TimeSpan TimeInGame => TimeSpan.FromMilliseconds(M.ReadInt(Address + 0xD18 + Offsets.IgsOffset));

        public DiagnosticInfoType DiagnosticInfoType => (DiagnosticInfoType)M.ReadInt(Address + 0xD28 + Offsets.IgsOffset);
        public DiagnosticElement LatencyRectangle => GetObjectAt<DiagnosticElement>(0xF40 + Offsets.IgsOffset);
        public DiagnosticElement FrameTimeRectangle => GetObjectAt<DiagnosticElement>(0x1390 + Offsets.IgsOffset);
        public DiagnosticElement FPSRectangle => GetObjectAt<DiagnosticElement>(0x15B8 + Offsets.IgsOffset);
        public float CurLatency => LatencyRectangle.CurrValue;
        public float CurFrameTime => FrameTimeRectangle.CurrValue;
        public float CurFps => FPSRectangle.CurrValue;

        public Camera Camera => GetObject<Camera>(Address + 0x1644 + Offsets.IgsOffsetDelta);
    }
}