using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
   public  interface IOriginSetting
    {
        string originPlace { get; set; }
        void   create(IContent content);
    }
}
