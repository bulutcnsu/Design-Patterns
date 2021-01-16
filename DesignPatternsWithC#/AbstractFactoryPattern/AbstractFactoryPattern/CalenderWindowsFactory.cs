using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class CalenderWindowsFactory : IOriginFactory
    {
        public IContent crateContentObject(string contentName)
        {
            CalenderContent content = new CalenderContent();
            content.ContentName= contentName;
            content.CreateContent();
            return content;

        }

        public IOriginSetting createOriginSettingObject()
        {
            WindowsOriginator originator = new WindowsOriginator();
            originator.originPlace = "http://www.windows.com";
            return originator;
        }
    }
}
