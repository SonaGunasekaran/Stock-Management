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

            Console.WriteLine("1.Display Stocks \n2. Create Stock \n3.Buy Stock \n4.Sell Stock\n5.calculate Each Value \n6.Calculate Total value");

            Console.WriteLine("Enter an Option : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            
                switch (choice)
                {
                    case 1:
                        manager.DisplayStock(utility.StockList);
                        break;
                    case 2:
                        Console.WriteLine("Create New Stock");
                        manager.CreateStock(utility.StockList);
                        File.WriteAllText(filePath, JsonConvert.SerializeObject(utility.StockList));
                        break;
                    case 3:
                        Console.WriteLine("Buy New Stock");
                        manager.BuyStock(utility.StockList);
                        File.WriteAllText(filePath, JsonConvert.SerializeObject(utility.StockList));
                        break;
                    case 4:
                        Console.WriteLine("Sell New Stock");
                        manager.BuyStock(utility.StockList);
                        File.WriteAllText(filePath, JsonConvert.SerializeObject(utility.StockList));
                        break;
                    case 5:
                        Console.WriteLine("Calculate the each value of stock");
                        manager.CalculateEachValue(utility.StockList);
                        break;
                   case 6:
                        Console.WriteLine("Calculate the each value of stock");
                        manager.CalculateTotalValue(utility.StockList);
                        break;
                    default:
                        break;
                }
            
        }
    }
}
