using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibiltDesignPattern
{
   public class IntranetHandler : ServiceHandler
    {
          // Eğer servis yerel makinede değilse zincirin bir sonraki tipi olan IntranetHandler' a gelir. Burada servis lokasyonunun Intranet olup olmadığına bakılır. Eğer öyleyse sorumluluk buradadır ve yerine getirilir.Ama değilse, zincirde bir sonraki tip olan InternetHandler nesne örneğine ait ProcessRequest metodu çağırılır.
            public override void ProcessRequest(ServiceInfo sInfo)
        {
            if (sInfo.Location == ServiceLocation.Intranet)
                Console.WriteLine("Şirket Network' ü üzerinde yer alan bir servis.\n\t{0} için gerekli başlatma işlemleri yapılıyor.", sInfo.Name);
       
            else if (_successor != null)
            {
                _successor.ProcessRequest(sInfo);
            }
        
        }

    }
}
