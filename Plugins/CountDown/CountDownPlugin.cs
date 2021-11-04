using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;

namespace CountDown
{
    public class CountDownPlugin : IPluginWithScheduler
    {
        IScheduler _scheduler;

        public CountDownPlugin(IScheduler scheduler) => _scheduler = scheduler;

        public PluginOutput Execute(string str, IList<PluginOutput> pluginHistory, ICallbacks callbacks)
        {
            _scheduler.Schedule(TimeSpan.FromSeconds(1), "");
            return new PluginOutput("Countdown started.", null);
        }
    }
}
