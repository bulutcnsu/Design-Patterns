﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
   public class EmirateAirways:Airline
    {

        public override void GetWay(string messageFromAirport)
        {
            Console.WriteLine("EmirateAirways, Uçuş {0} : ", FlightNumber);
            base.GetWay(messageFromAirport);
        }

    }
}