/*
Say you have an array for which the ith element is the price of a given stock on day i.

Design an algorithm to find the maximum profit. You may complete as many transactions as you like (ie, buy one and sell one share of the stock multiple times) with the following restrictions:

You may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
After you sell your stock, you cannot buy stock on next day. (ie, cooldown 1 day)
Example:

Input: [1,2,3,0,2]
Output: 3 
Explanation: transactions = [buy, sell, cooldown, buy, sell]
*/

using System;

public class BestTimeBuySellStockwithCooldown
{
    public int MaxProfit(int[] prices)
    {
        int len = prices.Length;
        if (len <= 1)
        {
            return 0;
        }

        if (len == 2 && prices[1] > prices[0])
        {
            return prices[1] - prices[0];
        }
        else if (len == 2 && prices[1] < prices[0])
        {
            return 0;
        }

        int[][] dp = new int[len][];

        dp[0] = new int[] { 0, -prices[0] };
        dp[1] = new int[2];
        dp[1][0] = Math.Max(dp[0][0], dp[0][1] + prices[1]);
        dp[1][1] = Math.Max(dp[0][1], dp[0][0] - prices[1]);

        for (int i = 2; i < len; i++)
        {
            dp[i] = new int[2];
            dp[i][0] = Math.Max(dp[i - 1][0], dp[i - 1][1] + prices[i]);
            dp[i][1] = Math.Max(dp[i - 1][1], dp[i - 2][0] - prices[i]);
        }

        return dp[len - 1][0];
    }
}