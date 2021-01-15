using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
   public class Stock
    {
        private String name = "ABC";
        private int quantity = 10;

        public void buy()
        {

            Console.WriteLine(" Stock Name is " + name +" Quantity : " +quantity);
        }
        public void sell()
        {
            Console.WriteLine(" Stock Name is " + name + " Quantity : " + quantity);
        }

    }
}
