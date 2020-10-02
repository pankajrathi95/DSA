/*
#39 - https://leetcode.com/problems/combination-sum/
Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.

The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the frequency of at least one of the chosen numbers is different.

 

Example 1:

Input: candidates = [2,3,6,7], target = 7
Output: [[2,2,3],[7]]
Explanation:
2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
7 is a candidate, and 7 = 7.
These are the only two combinations.
Example 2:

Input: candidates = [2,3,5], target = 8
Output: [[2,2,2,2],[2,3,3],[3,5]]
Example 3:

Input: candidates = [2], target = 1
Output: []
Example 4:

Input: candidates = [1], target = 1
Output: [[1]]
Example 5:

Input: candidates = [1], target = 2
Output: [[1,1]]
 

Constraints:

1 <= candidates.length <= 30
1 <= candidates[i] <= 200
All elements of candidates are distinct.
1 <= target <= 500
*/

using System.Collections.Generic;

public class CombinationSum
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        if (candidates == null)
        {
            return null;
        }

        IList<IList<int>> result = new List<IList<int>>();
        FindCombination(candidates, 0, target, new List<int>(), result);
        return result;
    }

    private void FindCombination(int[] candidates, int index, int target, IList<int> current, IList<IList<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = index; i < candidates.Length; i++)
        {
            if (candidates[i] <= target)
            {
                current.Add(candidates[i]);
                FindCombination(candidates, i, target - candidates[i], current, result);
                current.Remove(candidates[i]);
            }
        }
    }
}