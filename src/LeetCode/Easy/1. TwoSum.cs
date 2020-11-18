/*
https://leetcode.com/problems/two-sum/

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 105
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
*/

using System.Collections.Generic;

public class TwoSum
{
    public int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> values = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            //check if the diff of target of current number is found in dictionary if yes then we found the pair and return 
            //the indices else just add the current number and i to dictionary
            int diff = target - nums[i];
            if (values.ContainsKey(diff))
            {
                return new int[] { values[diff], i };
            }

            if (values.ContainsKey(nums[i])) values[nums[i]] = i;
            else values.Add(nums[i], i);
        }

        return new int[] { };
    }
}