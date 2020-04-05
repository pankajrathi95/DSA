using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BuyAndSellStock buyAndSellStock = new BuyAndSellStock();
            buyAndSellStock.MaxProfit(new int[] { 2, 4, 1 });
        }
    }
}
