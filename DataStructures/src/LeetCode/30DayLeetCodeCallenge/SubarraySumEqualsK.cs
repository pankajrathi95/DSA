/*

Given an array of integers and an integer k, you need to find the total number of continuous subarrays whose sum equals to k.

Example 1:
Input:nums = [1,1,1], k = 2
Output: 2
Note:
The length of the array is in range [1, 20,000].
The range of numbers in the array is [-1000, 1000] and the range of the integer k is [-1e7, 1e7].
*/

using System.Collections.Generic;

public class SubarraySumEqualsK
{
    public int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> sums = new Dictionary<int, int>();
        sums.Add(0, 1);
        int sum = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            int n = sums.ContainsKey(sum - k) ? sums[sum - k] : 0;
            count += n;
            if (sums.ContainsKey(sum))
            {
                sums[sum]++;
            }
            else
            {
                sums.Add(sum, 1);
            }
        }

        return count;
    }
}