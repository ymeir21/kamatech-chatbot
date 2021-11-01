using System;
using System.Collections.Generic;

namespace BasePlugin
{
    public struct Output
    {
        public string Message { get; set; }
        public string Extra { get; set; }
    }

    public interface IPlugin
    {
        public Output Execute(string str, IList<Output> history);
    }
}
