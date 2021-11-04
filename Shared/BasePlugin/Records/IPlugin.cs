using System;
using System.Collections.Generic;

namespace BasePlugin
{
    public interface IPlugin
    {
        public PluginOutput Execute(string str, IList<PluginOutput> pluginHistory);
    }
}
