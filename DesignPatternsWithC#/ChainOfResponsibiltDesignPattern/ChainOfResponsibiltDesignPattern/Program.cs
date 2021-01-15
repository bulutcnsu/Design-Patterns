using System;

namespace ChainOfResponsibiltDesignPattern { 

 

    class Program
    {
        static void Main(string[] args)
        {

           
            ServiceHandler handlerLocal = new LocalMachineHandler();
            ServiceHandler handlerIntranet = new IntranetHandler();
            ServiceHandler handlerInternet = new InternetHandler();

            handlerLocal.Successor = handlerIntranet;
            handlerIntranet.Successor = handlerInternet;

        
            ServiceInfo info = new ServiceInfo { Name = "Order Process Service", Location = ServiceLocation.Intranet };

          
            handlerLocal.ProcessRequest(info);

          

            Console.ReadLine();
        }
    }
}
