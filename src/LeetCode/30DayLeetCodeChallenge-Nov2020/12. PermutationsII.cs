/*
#47 - https://leetcode.com/problems/permutations-ii

Given a collection of numbers, nums, that might contain duplicates, return all possible unique permutations in any order.

 

Example 1:

Input: nums = [1,1,2]
Output:
[[1,1,2],
 [1,2,1],
 [2,1,1]]
Example 2:

Input: nums = [1,2,3]
Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
 

Constraints:

1 <= nums.length <= 8
-10 <= nums[i] <= 10
*/

using System;
using System.Collections.Generic;

public class PermutationsII
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (nums == null || nums.Length == 0)
        {
            return result;
        }

        Array.Sort(nums);
        bool[] used = new bool[nums.Length];
        IList<int> permutation = new List<int>();
        Helper(nums, permutation, used, result);
        return result;
    }

    private void Helper(int[] nums, IList<int> permutation, bool[] used, IList<IList<int>> result)
    {
        if (permutation.Count == nums.Length)
        {
            result.Add(new List<int>(permutation));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i])
            {
                continue;
            }

            used[i] = true;
            permutation.Add(nums[i]);
            Helper(nums, permutation, used, result);
            used[i] = false;
            permutation.RemoveAt(permutation.Count - 1);
            while (i + 1 < nums.Length && nums[i] == nums[i + 1])
            {
                i++;
            }
        }
    }
}