using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using CountDown;
using DiceRoller;
using Infrastructure;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var plugin = new PluginsManager().CreatePlugin(CountDownPlugin._Id);
            plugin.Execute("", null, null);

        }
    }
}
