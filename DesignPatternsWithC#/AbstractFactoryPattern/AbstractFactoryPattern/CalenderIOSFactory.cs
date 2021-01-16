using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class CalenderIOSFactory : IOriginFactory
    {
        public IContent crateContentObject(string contentName)
        {
            CalenderContent content = new CalenderContent();
            content.ContentName = contentName;
            content.CreateContent();
            return content;

        }

        public IOriginSetting createOriginSettingObject()
        {
            IOSOriginator originator = new IOSOriginator();
            originator.originPlace = "http://www.apple.com";
            return originator;
        }
    }
}
