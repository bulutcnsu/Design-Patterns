using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MediatorPattern
{
    //Concreate Mediator
    public class AtaturkAirport : IAirportControl
    {
        private Dictionary<string, Airline> _planes;

        public AtaturkAirport()
        {
            _planes = new Dictionary<string, Airline>();

        }


        public  void Register(Airline airLine) //register  plane's flightCode that will use airport 
        {
            if (!_planes.ContainsValue(airLine))
                _planes[airLine.FlightNumber] = airLine; //key valuepairs

                airLine.Airport = this;
        }

       public void SuggestWay(string fligthNumber, string way)
        {
            //get new flightNumber randomly for each plane
            Thread.Sleep(250);
            Random rnd = new Random();

            //attach a flightNumber randomly
            _planes[fligthNumber].GetWay(String.Format("{0}:{1}E;{2}", rnd.Next(1, 100).ToString(),
                rnd.Next(1, 100).ToString(), rnd.Next(1, 100).ToString()));
       
        }
    }
}
