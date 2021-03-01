/*
https://leetcode.com/problems/3sum/
Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

Notice that the solution set must not contain duplicate triplets.

 

Example 1:

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Example 2:

Input: nums = []
Output: []
Example 3:

Input: nums = [0]
Output: []
 

Constraints:

0 <= nums.length <= 3000
-105 <= nums[i] <= 105
*/

using System;
using System.Collections.Generic;

public class ThreeSum
{
    public IList<IList<int>> FindThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        HashSet<string> visited = new HashSet<string>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0 || nums[i - 1] != nums[i])
            {
                FindTwoSum(nums, i, result, visited);
            }
        }

        return result;
    }

    public void FindTwoSum(int[] nums, int i, IList<IList<int>> result, HashSet<string> visited)
    {
        Dictionary<int, int> values = new Dictionary<int, int>();
        for (int j = i + 1; j < nums.Length; j++)
        {
            //check if the diff of target of current number is found in dictionary if yes then we found the pair and return 
            //the indices else just add the current number and i to dictionary
            int diff = -nums[i] - nums[j];
            List<int> temp = new List<int>() { nums[i], nums[j], diff };
            temp.Sort();
            if (values.ContainsKey(diff) && !visited.Contains(temp[0] + "" + temp[1] + "" + temp[2]))
            {
                result.Add(temp);
                visited.Add(temp[0] + "" + temp[1] + "" + temp[2]);
            }

            if (values.ContainsKey(nums[j]))
            {
                values[nums[j]] = j;
            }
            else
            {
                values.Add(nums[j], j);
            }
        }
    }
}