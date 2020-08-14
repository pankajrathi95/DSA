/*
https://leetcode.com/problems/coin-change

We can do this problem by also filling the second row Or just do it without filling the second row 
*/

using System;

public class CoinChange
{
    //initializing the second row
    public int CoinChangeProblem(int[] coins, int amount)
    {
        int n = coins.Length;
        if (n == 0)
        {
            return -1;
        }


        int[][] dp = new int[n + 1][];
        for (int i = 0; i < n + 1; i++)
        {
            dp[i] = new int[amount + 1];
            dp[i][0] = 0;
        }

        for (int i = 0; i < amount + 1; i++)
        {
            dp[0][i] = int.MaxValue - 1;
        }


        for (int i = 1; i < amount + 1; i++)
        {
            if (i % coins[0] == 0)
            {
                dp[1][i] = i / coins[0];
            }
            else
            {
                dp[1][i] = int.MaxValue - 1;
            }
        }

        for (int i = 2; i < n + 1; i++)
        {
            for (int j = 1; j < amount + 1; j++)
            {
                if (coins[i - 1] <= j)
                {
                    dp[i][j] = Math.Min(1 + dp[i][j - coins[i - 1]], dp[i - 1][j]);
                }
                else
                {
                    dp[i][j] = dp[i - 1][j];
                }
            }
        }

        if (dp[n][amount] == int.MaxValue - 1)
        {
            return -1;
        }

        return dp[n][amount];
    }

    //Not initializing the second row
    public int CoinChangeProblemWithoutSecondRow(int[] coins, int amount)
    {
        int n = coins.Length;
        if (n == 0)
        {
            return -1;
        }


        int[][] dp = new int[n + 1][];
        for (int i = 0; i < n + 1; i++)
        {
            dp[i] = new int[amount + 1];
            dp[i][0] = 0;
        }

        for (int i = 0; i < amount + 1; i++)
        {
            dp[0][i] = int.MaxValue - 1;
        }

        for (int i = 1; i < n + 1; i++)
        {
            for (int j = 1; j < amount + 1; j++)
            {
                if (coins[i - 1] <= j)
                {
                    dp[i][j] = Math.Min(1 + dp[i][j - coins[i - 1]], dp[i - 1][j]);
                }
                else
                {
                    dp[i][j] = dp[i - 1][j];
                }
            }
        }

        if (dp[n][amount] == int.MaxValue - 1)
        {
            return -1;
        }

        return dp[n][amount];
    }
}