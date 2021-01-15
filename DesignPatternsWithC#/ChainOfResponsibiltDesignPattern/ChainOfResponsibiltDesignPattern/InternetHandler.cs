using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibiltDesignPattern
{
    public class InternetHandler:ServiceHandler
    {

        public override void ProcessRequest(ServiceInfo sInfo)
        {
            // Eğer lokasyon Internet ise bu tipe ait nesnenin sorumluluğundadır Eğer Internet' de değilse artık sernin son halkası olduğundan gidecek başka bir yer kalmamıştır. Buna uygun şekilde bir hareket yapılmalıdır.
            if (sInfo.Location == ServiceLocation.Internet)
                Console.WriteLine("Web ortamı üzerinde yer alan bir servis.\n\t{0} için gerekli başlatma işlemleri yapılıyor.", sInfo.Name);
            else
                Console.WriteLine("Uzaydan gelen bir servis mi bu yauv?");
        }
    }
}
