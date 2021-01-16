using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class AndroidOriginator : IOriginSetting
    {
        public string originPlace { get; set ; }

        public void create(IContent content)
        {
            Console.WriteLine(string.Format("it is created on Android via {0} address ", originPlace));
        }
    }
}
