/*
https://leetcode.com/problems/subsets-ii/
Given a collection of integers that might contain duplicates, nums, return all possible subsets (the power set).

Note: The solution set must not contain duplicate subsets.

Example:

Input: [1,2,2]
Output:
[
  [2],
  [1],
  [1,2,2],
  [2,2],
  [1,2],
  []
]
*/

using System;
using System.Collections.Generic;

public class SubsetsII
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        IList<IList<int>> subsets = new List<IList<int>>();
        Array.Sort(nums);
        BackTrack(subsets, new List<int>(), 0, nums);
        return subsets;
    }

    private void BackTrack(IList<IList<int>> subsets, IList<int> current, int index, int[] nums)
    {
        subsets.Add(new List<int>(current));
        for (int i = index; i < nums.Length; i++)
        {
            if (i > index && nums[i] == nums[i - 1])
            {
                continue;
            }

            current.Add(nums[i]);
            BackTrack(subsets, current, i + 1, nums);
            current.RemoveAt(current.Count - 1);
        }
    }
}