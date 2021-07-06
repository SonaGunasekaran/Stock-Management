using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace StockManagement
{
    class Stock
    {
        public static void ReadInput()
        {
            StockManager manager = new StockManager();
            string filePath = @"C:\Users\Sona G\source\repos\StockManagement\StockManagement\Json.json";
            StockUtility utility = JsonConvert.DeserializeObject<StockUtility>(File.ReadAllText(filePath));

            Console.WriteLine("1.Display Stocks \n2.Calculate value of each stock \n3.Calculate stock Total");

            Console.WriteLine("Enter an Option : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.DisplayStock(utility.StockList);
                    break;
                case 2:
                    manager.CalculateEachValue(utility.StockList);
                    break;
                case 3:
                    manager.CalculateTotalValue(utility.StockList);
                    break;
                default:
                    break;
            }
        }
    }
}
