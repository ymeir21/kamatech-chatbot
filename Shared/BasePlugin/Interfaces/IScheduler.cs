using System;

namespace BasePlugin.Interfaces
{
    public interface IScheduler
    {
        void Schedule(TimeSpan ts, string data);
    }
}
