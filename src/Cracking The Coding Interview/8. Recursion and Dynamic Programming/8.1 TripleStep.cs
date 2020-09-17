public class TripleStep
{
    public int CountWays(int n)
    {
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