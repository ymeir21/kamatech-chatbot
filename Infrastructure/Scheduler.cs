using BasePlugin.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Scheduler : IScheduler
    {
        PluginsManager _pluginsManager;

        public Scheduler(PluginsManager pluginsManager) => _pluginsManager = pluginsManager;

        public void Schedule(TimeSpan ts, string data)
        {
            throw new NotImplementedException("You guys should implement this");
        }
    }
}
