using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    class StockManager
    {
        StockUtility.Stock utility = new StockUtility.Stock();
        public void DisplayStock(List<StockUtility.Stock> stock)
        {

            string stockRecord = string.Empty;
            foreach (StockUtility.Stock value in stock)
            {
                stockRecord = "\n Name = " + value.Name + "\n Total Volume = " + value.Volume + "\n Price = " + value.Price;

            }
            Console.WriteLine(stockRecord);

        }

        public void CalculateEachValue(List<StockUtility.Stock> stock)
        {

            double volume = 0, price = 0;
            int num0fShare = 0;
            foreach (StockUtility.Stock value in stock)
            {
                price = value.Price;
                num0fShare = value.Volume;
                volume = price * num0fShare;

                Console.WriteLine("Value of particular stock " + value.Name + " " + volume + "\n");
            }
            
        }

        public void CalculateTotalValue(List<StockUtility.Stock> stock)
        {

            double volume = 0, price = 0,totalValue=0;
            int num0fShare = 0;
            foreach (StockUtility.Stock value in stock)
            {
                price = value.Price;
                num0fShare = value.Volume;
                volume = price * num0fShare;
                totalValue += volume;

                Console.WriteLine("Value of Total stock " + " " + totalValue + "\n");
            }

        }
    }
}
