using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
   public class SellStock:Stock
    {
        private Stock abcStock;

        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void execute()
        {
            abcStock.sell();
        }
    }
}
