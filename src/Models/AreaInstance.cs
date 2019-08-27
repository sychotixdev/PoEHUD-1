using PoeHUD.Poe.RemoteMemoryObjects;
using System;

namespace PoeHUD.Models
{
    public sealed class AreaInstance
    {

        public long CurrentWorldAreaPtr { get; }

        public DateTime TimeEntered = DateTime.Now;


        public AreaInstance(long currentWorldAreaPtr)
        {
            CurrentWorldAreaPtr = currentWorldAreaPtr;
        }

        public override string ToString()
        {
            return $"#{CurrentWorldAreaPtr}";
        }

        public static string GetTimeString(TimeSpan timeSpent)
        {
            int allsec = (int)timeSpent.TotalSeconds;
            int secs = allsec % 60;
            int mins = allsec / 60;
            int hours = mins / 60;
            mins = mins % 60;
            return String.Format(hours > 0 ? "{0}:{1:00}:{2:00}" : "{1}:{2:00}", hours, mins, secs);
        }
    }
}