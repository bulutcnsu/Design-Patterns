using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
  public enum Bicycles
    {
        Cruiser,
        CycloCross,
        Mountain,
        Triathlon

    }

   public class Creater
    {
        public IBicycle FactoryMethod( Bicycles types)
        {
            IBicycle bicycle = null;

            switch (types)
            {
                case Bicycles.Cruiser:
                    bicycle = new Cruiser();
                    break;
               
                case Bicycles.CycloCross:
                    bicycle = new CycloCross();
                    break;
               
                case Bicycles.Mountain:
                    bicycle = new Mountain();
                    break;

                case Bicycles.Triathlon:
                    bicycle = new Triathlon();
                    break;
            }
            return bicycle;

        }
    }
}
