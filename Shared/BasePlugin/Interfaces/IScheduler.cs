using System;

namespace BasePlugin.Interfaces
{
    public interface IScheduler
    {
        void Schedule(TimeSpan ts, string data);
        void Schedule(DateTime date, string data);
    }
}
