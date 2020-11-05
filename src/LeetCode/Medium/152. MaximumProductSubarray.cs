/*
https://leetcode.com/problems/maximum-product-subarray/

Given an integer array nums, find the contiguous subarray within an array (containing at least one number) which has the largest product.

Example 1:

Input: [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6.
Example 2:

Input: [-2,0,-1]
Output: 0
Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
*/

using System;

public class MaximumProductSubarray
{
    public int MaxProduct(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int max = nums[0];
        int max_till_here = nums[0], min_till_here = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            int temp = max_till_here;
            max_till_here = Math.Max(nums[i], Math.Max(nums[i] * max_till_here, nums[i] * min_till_here));
            min_till_here = Math.Min(nums[i], Math.Min(nums[i] * temp, nums[i] * min_till_here));
            max = Math.Max(max, max_till_here);
        }

        return max;
    }
}