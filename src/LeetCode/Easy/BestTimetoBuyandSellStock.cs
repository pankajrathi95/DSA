/*
https://leetcode.com/problems/best-time-to-buy-and-sell-stock/solution/
*/

public class BestTimetoBuyandSellStock
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                int profit = prices[j] - prices[i];
                if (maxProfit < profit)
                {
                    maxProfit = profit;
                }
            }
        }

        return maxProfit;
    }
}