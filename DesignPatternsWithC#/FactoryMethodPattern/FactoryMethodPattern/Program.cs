using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new Creater();
           
            IBicycle triathlon = creater.FactoryMethod(Bicycles.Triathlon);
            IBicycle mountain = creater.FactoryMethod(Bicycles.Mountain);
            IBicycle cruiser = creater.FactoryMethod(Bicycles.Cruiser);
            IBicycle cycle = creater.FactoryMethod(Bicycles.CycloCross);


            triathlon.platform();
            mountain.platform();
            cruiser.platform();
            cycle.platform();

            Console.ReadLine();
        }
    }
}
