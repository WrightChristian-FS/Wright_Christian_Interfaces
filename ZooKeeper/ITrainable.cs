using System;
using System.Collections.Generic;

namespace ZooKeeper
{
    public interface ITrainable
    {

        public Dictionary<string,string> Behavior { get; set;  }
        public string Perform(string signal);
        public string Train(string signal, string behavoir);

    }
        
}
