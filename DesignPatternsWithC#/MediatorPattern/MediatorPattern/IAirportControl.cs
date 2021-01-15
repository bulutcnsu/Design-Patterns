using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    //MediatorClass

   public interface IAirportControl
    {
     public  void Register(Airline airLine);
     public   void SuggestWay(string fligthNumber, string way);

    }
}
