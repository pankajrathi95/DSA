/*
https://leetcode.com/problems/partition-equal-subset-sum/
*/


public class PartitionEqualSubsetSum
{
    // Bottom-Up Approach
    public bool CanPartition(int[] nums)
    {
        int sum = 0;
        foreach (var num in nums)
        {
            sum += num;
        }

        if (sum % 2 != 0)
        {
            return false;
        }
        else
        {
            sum /= 2;
            return Partition(nums, sum);
        }
    }

    private bool Partition(int[] nums, int sum)
    {
        bool[][] dp = new bool[nums.Length + 1][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new bool[sum + 1];
            dp[i][0] = true;
        }

        for (int i = 1; i < nums.Length + 1; i++)
        {
            for (int j = 1; j < sum + 1; j++)
            {
                if (nums[i - 1] <= j)
                {
                    dp[i][j] = dp[i - 1][j - nums[i - 1]] || dp[i - 1][j];
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