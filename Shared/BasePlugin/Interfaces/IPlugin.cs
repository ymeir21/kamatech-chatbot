using BasePlugin.Records;
using System.Collections.Generic;

namespace BasePlugin.Interfaces
{

    public interface IPlugin
    {
        public string Id { get; }
        public PluginOutput Execute(string str, IList<PluginOutput> pluginHistory, ICallbacks callbacks);
    }
}
