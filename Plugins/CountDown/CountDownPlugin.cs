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

        public static string _Id = "count-down";
        public string Id => _Id;

        public PluginOutput Execute(string str, IList<PluginOutput> pluginHistory, ICallbacks callbacks)
        {
            if (str == "") // i.e start 1 second default CountDown  
            { 
                _scheduler.Schedule(TimeSpan.FromSeconds(1), "");
                return new PluginOutput("Countdown started.", null);
             }
            else { 
                 try
                {
                  var interval = Int32.Parse(str);
                  _scheduler.Schedule(TimeSpan.FromSeconds(interval), "");
                  return new PluginOutput("Countdown started.", null);
                }
                catch (FormatException)
                {
                  return new PluginOutput("Countdown failed, string input nust represent vaild seconds.", null);
                }
            }
        }
    }
}
