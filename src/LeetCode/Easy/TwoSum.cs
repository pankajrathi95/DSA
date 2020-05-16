/*

Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*/

using System.Collections.Generic;

public class TwoSum
{
    public int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> values = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!values.ContainsKey(nums[i]))
            {
                values.Add(nums[i], i);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int val = target - nums[i];

            if (values.ContainsKey(val) && values[val] != i)
            {
                return new int[] { i, values[val], };
            }
        }

        return new int[] { };
    }
}