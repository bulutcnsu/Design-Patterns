using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class CalenderContent : IContent
    {
        public string ContentName { get ; set ; }

        public void CreateContent()
        {
            Console.WriteLine("Calender is made");
        }
    }
}
