using System;

public class TripleStep
{
    public int CountWays(int n)
    {
        // int[] dp = new int[n + 1];
        // dp[0] = 0;
        // dp[1] = 1;
        // dp[2] = 2;

        // for (int i = 3; i < dp.Length; i++)
        // {
        //     dp[3] = Math.Max()
        // }
        int[] dp = new int[n + 1];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = -1;
        }

        return CountWays_Rec(n, dp);
    }

    private int CountWays_Rec(int n, int[] dp)
    {
        if (n == 0)
        {
            return 1;
        }

        if (n < 0)
        {
            return 0;
        }

        if (dp[n] != -1)
        {
            return dp[n];
        }

        return dp[n] = CountWays_Rec(n - 1, dp) + CountWays_Rec(n - 2, dp) + CountWays_Rec(n - 3, dp);
    }
}