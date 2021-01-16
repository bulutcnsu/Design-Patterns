using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
  public  interface IContent
    {
        void CreateContent();
        string ContentName { get; set; }
    }
}
