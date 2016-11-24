using PoeHUD.Models.Enums;
using System;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameState : RemoteMemoryObject
    {
        public Camera Camera => GetObject<Camera>(Address + 0x15A0 + Offsets.IgsOffsetDelta);
        
        public IngameData Data => ReadObject<IngameData>(Address + 0x160 + Offsets.IgsOffset);
        public bool InGame => true;// ServerData.IsInGame;
        public ServerData ServerData => ReadObjectAt<ServerData>(0x13C + Offsets.IgsOffset);
        public IngameUIElements IngameUi => ReadObjectAt<IngameUIElements>(0x5E8 + Offsets.IgsOffset);
        public Element UIRoot => ReadObjectAt<Element>(0xC98 + Offsets.IgsOffset);
        public Element UIHover => ReadObjectAt<Element>(0xCA8 + Offsets.IgsOffset);

        public float CurUIElementPosX => M.ReadFloat(Address + 0xCA0 + Offsets.IgsOffset);//New
        public float CurUIElementPosY => M.ReadFloat(Address + 0xCA4 + Offsets.IgsOffset);//New

        public int EntityLabelMap => M.ReadInt(Address + 0x50, 0x968);
        public DiagnosticInfoType DiagnosticInfoType => (DiagnosticInfoType)M.ReadInt(Address + 0xD18 + Offsets.IgsOffset);
        public DiagnosticElement LatencyRectangle => GetObjectAt<DiagnosticElement>(0xE98 + Offsets.IgsOffset);
        public DiagnosticElement FrameTimeRectangle => GetObjectAt<DiagnosticElement>(0x12E8 + Offsets.IgsOffset);
        public DiagnosticElement FPSRectangle => GetObjectAt<DiagnosticElement>(0x1510 + Offsets.IgsOffset);
        public float CurLatency => M.ReadFloat(Address + 0xE60 + Offsets.IgsOffset);
        public float CurFrameTime => M.ReadFloat(Address + 0x12F0 + Offsets.IgsOffset);
        public float CurFps => M.ReadFloat(Address + 0x1538 + Offsets.IgsOffset);
        public TimeSpan TimeInGame => TimeSpan.FromMilliseconds(M.ReadInt(Address + 0xD04 + Offsets.IgsOffset));
        public float TimeInGameF => M.ReadFloat(Address + 0xD04 + Offsets.IgsOffset);
    }
}