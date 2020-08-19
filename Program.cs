using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            // int[] prices = new int[] { 1, 2, 4, 2, 5, 7, 2, 4, 9, 0 };
            // BestTimetoBuyandSellStockIII bestTimetoBuyandSell = new BestTimetoBuyandSellStockIII();
            // bestTimetoBuyandSell.MaxProfit(prices);

            NumbersWithSameConsecutiveDifferences consecutiveDifferences = new NumbersWithSameConsecutiveDifferences();
            consecutiveDifferences.NumsSameConsecDiff(3, 7);
        }
    }
}
