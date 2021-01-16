using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class UserInterfaceContent : IContent
    {
        public string ContentName { get ; set ; }

        public void CreateContent()
        {
            Console.WriteLine("User interface is created");
        }
    }
}
