/*
#78 - https://leetcode.com/problems/subsets/
Given an integer array nums, return all possible subsets (the power set).

The solution set must not contain duplicate subsets.

 

Example 1:

Input: nums = [1,2,3]
Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
Example 2:

Input: nums = [0]
Output: [[],[0]]
 

Constraints:

1 <= nums.length <= 10
-10 <= nums[i] <= 10
*/

using System.Collections.Generic;

public class Subsets
{
    public IList<IList<int>> FindSubsets(int[] nums)
    {
        IList<IList<int>> subsets = new List<IList<int>>();
        BackTrack(subsets, new List<int>(), 0, nums);
        return subsets;
    }

    private void BackTrack(IList<IList<int>> subsets, IList<int> current, int index, int[] nums)
    {
        subsets.Add(new List<int>(current));
        for (int i = index; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            BackTrack(subsets, current, i + 1, nums);
            current.RemoveAt(current.Count - 1);
        }
    }
}