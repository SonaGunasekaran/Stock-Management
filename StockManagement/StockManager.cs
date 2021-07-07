﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace StockManagement
{
    class StockManager
    {
        //Create the New Stock
        public void CreateStock(LinkedList<StockUtility.Stock> stock)
        {
            StockManager manager = new StockManager();
            //create the new share
            StockUtility.Stock newstock = new StockUtility.Stock();
            Console.WriteLine("Enter the name:");
            newstock.Name = Console.ReadLine();
            Console.WriteLine("Enter the Volume of Share:");
            newstock.Volume= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price:");
            newstock.Price = Convert.ToInt32(Console.ReadLine());
            stock.AddLast(newstock);
            manager.SaveStock(stock);
        }
        //Buy the stock
        public void BuyStock(LinkedList<StockUtility.Stock> stock)
        {
            int price = 0;
            string transactions = string.Empty;
            Console.WriteLine("Enter the number of stock you want to buy:");
            int num = Convert.ToInt32(Console.ReadLine());
            //StockManager manager = new StockManager();
            StockUtility.Stock newStock = new StockUtility.Stock();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the volume:");
                int amount = Convert.ToInt32(Console.ReadLine());

                foreach (StockUtility.Stock value in stock)
                {
                    if (value.Name.Equals(name))
                    {
                        amount += value.Volume;
                        price = value.Price;
                        name = value.Name;

                        stock.Remove(stock.Find(value));
                        break;
                        
                    }
                    else
                    {
                        Console.WriteLine("Stock is not available");
                        
                    }

                    newStock.Name = name;
                    newStock.Volume = amount;
                    newStock.Price = price;

                    
                }

                transactions = "Transaction on Name : " + " " + newStock.Name + "of volume= " + " " + newStock.Volume + " " + "ValueOf =" + newStock.Volume * newStock.Price;
                Console.WriteLine(transactions);


            }


        }
        //Selling the Stock
        public void SellStock(int amount, string name, LinkedList<StockUtility.Stock> stock)
        {
            int price = 0;
            string transactions = string.Empty;
            Console.WriteLine("Enter the number of stock you want to sell:");
            StockUtility.Stock newStock = new StockUtility.Stock();
            
            Console.WriteLine("Enter the name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter the volume:");
            amount = Convert.ToInt32(Console.ReadLine());

            foreach (StockUtility.Stock value in stock)
            {
                if (value.Name.Equals(name)&& amount<=value.Volume)
                {
                    amount = value.Volume-amount;
                    price = value.Price;
                    name = value.Name;

                    stock.Remove(stock.Find(value));
                    break;
                }
                else
                {
                    Console.WriteLine("Stock is not available");
                }

                newStock.Name = name;
                newStock.Volume = amount;
                newStock.Price = price;
                transactions = "Transaction on Name : " + " " + newStock.Name + "of volume= " + " " + newStock.Volume + " " + "ValueOf =" + newStock.Volume * newStock.Price;
               Console.WriteLine(transactions);
            }


        }
        // To Save the Stock
        public void SaveStock(LinkedList<StockUtility.Stock> stockList)
        {
            
            StockUtility StockUtility = new StockUtility();
            StockUtility.StockList = stockList;
        }

        public void DisplayStock(LinkedList<StockUtility.Stock> stock)
        {

            string stockRecord = string.Empty;
            foreach (StockUtility.Stock value in stock)
            {
                stockRecord = "\n Name = " + value.Name + "\n Total Volume = " + value.Volume + "\n Price = " + value.Price;
                Console.WriteLine(stockRecord);
            }


        }
        //Calculate Each Value of Stock
        public void CalculateEachValue(LinkedList<StockUtility.Stock> stockRecord)
        {

            double volume = 0, price = 0;
            int num0fShare = 0;
            foreach (StockUtility.Stock value in stockRecord)
            {
                Console.WriteLine("Name =" + value.Name + "\n Total Volume=" + value.Volume + "\nPrice= " + value.Price + "\n");
                price = value.Price;
                num0fShare = value.Volume;
                volume = price * num0fShare;

                Console.WriteLine("Value of particular stock " + value.Name + " " + volume + "\n");
            }

        }
        //Calculate Total Value
        public void CalculateTotalValue(LinkedList<StockUtility.Stock> stock)
        {

            double volume = 0, price = 0, totalValue = 0;
            int num0fShare = 0;
            foreach (StockUtility.Stock value in stock)
            {
                Console.WriteLine("Name =" + value.Name + "\nVolume=" + value.Volume + "\nPrice= " + value.Price + "\n");
                price = value.Price;
                num0fShare = value.Volume;
                volume = price * num0fShare;
                Console.WriteLine("Total value of " + value.Name + " " + "share is" + " " + num0fShare + "\n");
                totalValue += volume;

            }
            Console.WriteLine("Value of Total stock " + " " + totalValue + "\n");
        }

        
    }
}
    

