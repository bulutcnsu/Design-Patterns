using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Originator<T> where T : IOriginFactory, new()
    {
        private IContent content;
        private IOriginSetting originSetting;
        private T factory;

        public Originator(string contentName)
        {
            factory = new T();
            content = factory.crateContentObject(contentName);
            originSetting = factory.createOriginSettingObject();

        }

        public void create()
        {
            originSetting.create(content);
        }
    }
}
