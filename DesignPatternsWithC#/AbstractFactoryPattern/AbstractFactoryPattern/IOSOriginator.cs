using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class IOSOriginator : IOriginSetting
    {
        public string originPlace { get ; set; }

        public void create(IContent content)
        {
            Console.WriteLine(string.Format("it is created on IOS via {0} address ", originPlace));
        }
    }
}
