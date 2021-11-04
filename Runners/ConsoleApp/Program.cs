using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using CountDown;
using DiceRoller;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Scheduler : IScheduler
    {
        public void Schedule(TimeSpan ts, string data)
        {
            throw new NotImplementedException("You guys should implement this");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var game1 = new CountDownPlugin(new Scheduler()) as IPlugin;
            game1.Execute("", null, null);
        }

        static void RunDiceRoller()
        {
            var game1 = new DiceRollerPlugin() as IPlugin;
            var history = new List<PluginOutput>();

            for (int i = 0; i < 11120; i++)
            {
                var result = game1.Execute("", history, null);
                history.Add(result);
            }
        }
    }
}
