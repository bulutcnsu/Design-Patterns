using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class Triathlon : IBicycle
    {
        public void platform()
        {
            Console.WriteLine("This biscycle is designed for racings on asphalted roads");

        }
    }
}
