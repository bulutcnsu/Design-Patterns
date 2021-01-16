using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class UserInterfaceIOSFactory : IOriginFactory
    {
        public IContent crateContentObject(string contentName)
        {
            UserInterfaceContent content = new UserInterfaceContent();
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
