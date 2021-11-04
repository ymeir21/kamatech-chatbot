using BasePlugin;
using DiceRoller;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var game1 = new DiceRollerPlugin();
            var history = new List<PluginOutput>();

            for (int i = 0; i < 11120; i++)
            {
                var result = game1.Execute("", history);
                history.Add(result);
            }
        }
    }
}
