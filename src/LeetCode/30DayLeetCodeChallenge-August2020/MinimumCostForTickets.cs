using System;

public class MinimumCostForTickets
{
    public int MincostTickets(int[] days, int[] costs)
    {
        int n = days.Length;
        int[] dp = new int[n + 1];

        for (int i = n - 1; i >= 0; i--)
        {
            int d7 = i, d30 = i;
            while (d7 < n && days[d7] < days[i] + 7)
            {
                d7++;
            }

            while (d30 < n && days[d30] < days[i] + 30)
            {
                d30++;
            }

            dp[i] = Math.Min(costs[0] + dp[i + 1], Math.Min(costs[1] + dp[d7], costs[2] + dp[d30]));
        }

        return dp[0];
    }
}