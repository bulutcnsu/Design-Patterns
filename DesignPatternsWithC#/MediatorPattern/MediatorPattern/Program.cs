using System;

namespace MediatorPattern
{
     public class Program
    {
  public  static void Main(string[] args)
        {

            AtaturkAirport istanbulKule = new AtaturkAirport();

            TurkishAirlines oh101 = new TurkishAirlines { Airport = istanbulKule, FlightNumber = "oh101", From = "Bodrum" };
            istanbulKule.Register(oh101);

            EmirateAirways oh132 = new EmirateAirways { Airport = istanbulKule, FlightNumber = "oh132", From = "Abu Dabi" };
            istanbulKule.Register(oh132);
            HongKongAirlines zy99 = new HongKongAirlines { Airport = istanbulKule, FlightNumber = "zy99", From = "Sai Wan" };
            istanbulKule.Register(zy99);

            // Uçaklar yeni rotalarını talep ederler.
            zy99.RequestNewWay("34:43E;41:41W");

            oh101.RequestNewWay("34:43E;41:41W");

            Console.ReadKey();
        }
    }
}
