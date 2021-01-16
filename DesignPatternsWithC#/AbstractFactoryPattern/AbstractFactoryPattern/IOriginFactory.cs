using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
  public  interface IOriginFactory
    {
        IContent  crateContentObject(string contentName);
        IOriginSetting  createOriginSettingObject();
    }
}
