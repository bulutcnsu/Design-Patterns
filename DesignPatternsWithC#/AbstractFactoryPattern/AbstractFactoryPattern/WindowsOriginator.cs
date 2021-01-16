using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class WindowsOriginator : IOriginSetting
    {
        public string originPlace { get ; set ; }

        public void create(IContent content)
        {
            Console.WriteLine(string.Format("it is created on Windows via  {0} address ", originPlace));
        }
    }
}
