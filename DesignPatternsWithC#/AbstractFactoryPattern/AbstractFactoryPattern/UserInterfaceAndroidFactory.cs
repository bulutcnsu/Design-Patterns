using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class UserInterfaceAndroidFactory : IOriginFactory
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
            AndroidOriginator originator = new AndroidOriginator();
            originator.originPlace = "http://wwww.android.com";
            return originator;


        }
    }
}
