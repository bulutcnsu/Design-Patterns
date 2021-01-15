using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class Cruiser : IBicycle
    {
        public void platform()
        {
            Console.WriteLine("This biscycle is designed for casual riding and short-distances");
        }
    }
}
