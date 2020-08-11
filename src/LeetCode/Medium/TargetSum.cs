/*
https://leetcode.com/problems/target-sum/
*/

public class TargetSum
{
    public int FindTargetSumWays(int[] nums, int S)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        if (nums.Length == 0 || (S + sum) % 2 != 0)
        {
            return 0;
        }
        int target = ((S + sum) / 2);
        if (target > sum) return 0;
        return CountSubsetSum(nums, target);
    }

    private int CountSubsetSum(int[] nums, int sum)
    {
        int[][] dp = new int[nums.Length + 1][];
        for (int i = 0; i < nums.Length + 1; i++)
        {
            dp[i] = new int[sum + 1];
        }

        for (int j = 0; j <= sum; j++)
        {
            dp[0][j] = 0;
        }

        dp[0][0] = 1;

        for (int i = 1; i < nums.Length + 1; i++)
        {
            for (int j = 0; j < sum + 1; j++)
            {
                if (nums[i - 1] <= j)
                {
                    dp[i][j] = dp[i - 1][j] + dp[i - 1][j - nums[i - 1]];
                }
                else
                {
                    dp[i][j] = dp[i - 1][j];
                }
            }
        }

        return dp[nums.Length][sum];
    }
}