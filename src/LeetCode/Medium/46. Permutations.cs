/*
https://leetcode.com/problems/permutations/
Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.

 

Example 1:

Input: nums = [1,2,3]
Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
Example 2:

Input: nums = [0,1]
Output: [[0,1],[1,0]]
Example 3:

Input: nums = [1]
Output: [[1]]
 

Constraints:

1 <= nums.length <= 6
-10 <= nums[i] <= 10
All the integers of nums are unique.
*/

using System.Collections.Generic;

public class Permutations
{
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        BackTrack(result, new List<int>(), nums);
        return result;
    }

    private void BackTrack(IList<IList<int>> result, IList<int> current, int[] nums)
    {
        if (current.Count == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (current.Contains(nums[i]))
            {
                continue;
            }

            current.Add(nums[i]);
            BackTrack(result, current, nums);
            current.RemoveAt(current.Count - 1);
        }
    }
}