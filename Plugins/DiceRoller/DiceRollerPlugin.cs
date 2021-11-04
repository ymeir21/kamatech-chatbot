using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;

namespace DiceRoller
{
    public class DiceRollerPlugin : IPlugin
    {
        Random rand = new Random();

        public PluginOutput Execute(string str, IList<PluginOutput> pluginHistory, ICallbacks callbacks)
        {
            var last1 = 0;
            var last2 = 0;

            if (pluginHistory.Count > 0)
            {
                var res = pluginHistory[pluginHistory.Count - 1].Extra.Split(' ');
                last1 = int.Parse(res[0]);
                last2 = int.Parse(res[1]);
            }

            var dice1 = 0;
            var dice2 = 0;

            do
            {
                dice1 = rand.Next(1, 7);
                dice2 = rand.Next(1, 7);
            } while ((dice1 == last1 && dice2 == last2) || (dice1 == last2 && dice2 == last1));

            var result = new PluginOutput($"You: {dice1} {dice2}", $"{dice1} {dice2}");
            return result;
        }
    }
}
