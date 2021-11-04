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

        public void Schedule(TimeSpan ts, string pluginId, string data)
        {
            /// TODO:
            /// 1. Start a timer
            /// 1. When timer fires, Create a plugin instance (with plugin manager)
            /// 2. Add some function to the interface (IPluginWithScheduler)
            /// 3. Call the function :)

            throw new NotImplementedException("You guys should implement this");
        }
    }
}
