using PoeHUD.Models.Enums;

namespace PoeHUD.Poe.Components
{
    public class Stats : Component
    {
        public long statPtrStart => M.ReadLong(Address + 0x50);
        public long statPtrEnd => M.ReadLong(Address + 0x58);
    }
}
