using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibiltDesignPattern
{
  public abstract class ServiceHandler
    {

        protected ServiceHandler _successor;

        public ServiceHandler Successor //prototype
        {
            set
            {
                _successor = value;
            }
        }
        public abstract void ProcessRequest(ServiceInfo sInfo);
    }
}
