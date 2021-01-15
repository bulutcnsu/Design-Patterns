using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibiltDesignPattern
{

   public enum ServiceLocation
    {
        LocalMachine,
        Intranet,
        Internet,
        SecureZone,
    }

   public class ServiceInfo
    {
        public string Name { get; set; }
        public ServiceLocation Location { get; set; }

    }
}
