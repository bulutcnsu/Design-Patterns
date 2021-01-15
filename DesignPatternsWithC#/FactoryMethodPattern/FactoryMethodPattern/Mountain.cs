using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class Mountain : IBicycle
    {
        public void platform()
        {
            Console.WriteLine("Mountain Bicycles are design for riding rough off-road trails");
        }
    }
}
