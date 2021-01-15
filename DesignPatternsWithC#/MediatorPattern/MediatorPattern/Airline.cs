using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{//colleague Class
   public class Airline
    {
        public IAirportControl Airport { get; set; } //association
        public string FlightNumber { get; set; }
        public string From { get; set; }


        public void RequestNewWay(string myWay) //requesting a new road from aircontrol
        {
           
            Airport.SuggestWay(FlightNumber, myWay);
        }

        public virtual void GetWay(string messageFromAirport)
        {
            Console.WriteLine("{0} rotasına yönelmemiz gerekmektedir.", messageFromAirport);
        }

    }
}
