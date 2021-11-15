﻿using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace DiceRoller
{
    record Session(int Dice1, int Dice2);

    public class DiceRollerPlugin : IPlugin
    {
        Random rand = new Random();

        public static string _Id => "dice-roller";
        public string Id => _Id;

        public bool CanExecute(string input, string session) => true;

        public PluginOutput Execute(string input, string session, ICallbacks callbacks)
        {
            var last1 = 0;
            var last2 = 0;

            if (string.IsNullOrEmpty(session) == false)
            {
                var res = JsonSerializer.Deserialize<Session>(session);
                last1 = res.Dice1;
                last2 = res.Dice2;
            }

            var dice1 = 0;
            var dice2 = 0;

            do
            {
                dice1 = rand.Next(1, 7);
                dice2 = rand.Next(1, 7);
            } while ((dice1 == last1 && dice2 == last2) || (dice1 == last2 && dice2 == last1));

            var ses = new Session(dice1, dice2);
            var result = new PluginOutput($"You: {dice1} {dice2}", JsonSerializer.Serialize(ses));
            return result;
        }
    }
}
