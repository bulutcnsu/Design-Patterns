using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
   public class BuyStock:Stock
    {
        private Stock abcStock;

        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }
        public void execute()
        {
            abcStock.buy();
        }
    }
}
