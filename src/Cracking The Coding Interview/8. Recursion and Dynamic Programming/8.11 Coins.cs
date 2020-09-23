public class Coins
{
    public int Change(int amount, int[] coins)
    {
        int[][] dp = new int[coins.Length + 1][];
        for (int i = 0; i < coins.Length + 1; i++)
        {
            dp[i] = new int[amount + 1];
            dp[i][0] = 1;
        }

        for (int i = 0; i < amount + 1; i++)
        {
            dp[0][i] = 0;
        }

        dp[0][0] = 1;
        for (int i = 1; i < coins.Length + 1; i++)
        {
            for (int j = 1; j < amount + 1; j++)
            {
                if (coins[i - 1] <= j)
                {
                    dp[i][j] = dp[i][j - coins[i - 1]] + dp[i - 1][j];
                }
                else
                {
                    dp[i][j] = dp[i - 1][j];
                }
            }
        }

        return dp[coins.Length][amount];
    }
}