using PoeHUD.Models.Enums;
using System;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameState : RemoteMemoryObject
    {
        public Camera Camera => GetObject<Camera>(Address + 0x16e4 + Offsets.IgsOffsetDelta);
        
        public IngameData Data => ReadObject<IngameData>(Address + 0x160 + Offsets.IgsOffset);
        public bool InGame => true;// ServerData.IsInGame;
        public ServerData ServerData => ReadObjectAt<ServerData>(0x168 + Offsets.IgsOffset);
        public IngameUIElements IngameUi => ReadObjectAt<IngameUIElements>(0x5C0 + Offsets.IgsOffset);
        public Element UIRoot => ReadObjectAt<Element>(0xC98 + Offsets.IgsOffset);
        public Element UIHover => ReadObjectAt<Element>(0xCA8 + Offsets.IgsOffset);

        public float CurentUIElementPosX => M.ReadFloat(Address + 0xCA0 + Offsets.IgsOffset);
        public float CurentUIElementPosY => M.ReadFloat(Address + 0xCA4 + Offsets.IgsOffset);

        public int EntityLabelMap => M.ReadInt(Address + 0x90, 0xA48);
        public DiagnosticInfoType DiagnosticInfoType => (DiagnosticInfoType)M.ReadInt(Address + 0xD18 + Offsets.IgsOffset);
        public DiagnosticElement LatencyRectangle => GetObjectAt<DiagnosticElement>(0xF48 + Offsets.IgsOffset);
        public DiagnosticElement FrameTimeRectangle => GetObjectAt<DiagnosticElement>(0x13D8 + Offsets.IgsOffset);
        public DiagnosticElement FPSRectangle => GetObjectAt<DiagnosticElement>(0x1620 + Offsets.IgsOffset);
        public float CurLatency => LatencyRectangle.CurrValue;
        public float CurFrameTime => FrameTimeRectangle.CurrValue;
        public float CurFps => FPSRectangle.CurrValue;
        public TimeSpan TimeInGame => TimeSpan.FromSeconds(M.ReadFloat(Address + 0xD00 + Offsets.IgsOffset));
        public float TimeInGameF => M.ReadFloat(Address + 0xD04 + Offsets.IgsOffset);
    }
}