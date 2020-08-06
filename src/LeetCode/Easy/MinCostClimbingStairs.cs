/*
https://leetcode.com/problems/min-cost-climbing-stairs/
*/

using System;

public class MinCostClimbingStairs
{
    //Dynamic Programming - Bottom up approach
    public int MinCostForClimbingStairs(int[] cost)
    {
        if (cost.Length == 0)
        {
            return 0;
        }

        if (cost.Length == 1)
        {
            return cost[0];
        }

        if (cost.Length == 2)
        {
            return Math.Min(cost[0], cost[1]);
        }

        int[] dp = new int[cost.Length];
        dp[0] = cost[0];
        dp[1] = cost[1];
        for (int i = 2; i < cost.Length; i++)
        {
            dp[i] = cost[i] + Math.Min(dp[i - 2], dp[i - 1]);
        }

        return Math.Min(dp[dp.Length - 1], dp[dp.Length - 2]);
    }

    //Dynamic Programming - Top Down approach (Recursion + memoization)
    public int MinCostClimbingStairs_Top(int[] cost)
    {
        int[] dp = new int[cost.Length];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = -1;
        }
        return Math.Min(Rec(cost, cost.Length - 1, dp), Rec(cost, cost.Length - 2, dp));
    }

    private int Rec(int[] cost, int index, int[] dp)
    {
        if (index < 0)
        {
            return 0;
        }

        if (dp[index] != -1)
        {
            return dp[index];
        }

        return dp[index] = Math.Min(cost[index] + Rec(cost, index - 1, dp), cost[index] + Rec(cost, index - 2, dp));
    }

    //Recursive approach (TLE)
    public int MinCostClimbingStairs_Rec(int[] cost)
    {
        return Math.Min(Rec(cost, cost.Length - 1), Rec(cost, cost.Length - 2));
    }

    private int Rec(int[] cost, int index)
    {
        if (index < 0)
        {
            return 0;
        }

        return Math.Min(cost[index] + Rec(cost, index - 1), cost[index] + Rec(cost, index - 2));
    }
}