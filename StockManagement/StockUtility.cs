using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    class StockUtility
    {
        public LinkedList<Stock> StockList { get; set; }


        public class Stock
        {
            public string Name { get; set; }
            public int Volume { get; set; }
            public int Price { get; set; }
            

        }
    }
}
