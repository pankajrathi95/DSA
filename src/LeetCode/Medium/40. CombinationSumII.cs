/*
https://leetcode.com/problems/combination-sum-ii/

Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sum to target.

Each number in candidates may only be used once in the combination.

Note: The solution set must not contain duplicate combinations.

 

Example 1:

Input: candidates = [10,1,2,7,6,1,5], target = 8
Output: 
[
[1,1,6],
[1,2,5],
[1,7],
[2,6]
]
Example 2:

Input: candidates = [2,5,2,1,2], target = 5
Output: 
[
[1,2,2],
[5]
]
 

Constraints:

1 <= candidates.length <= 100
1 <= candidates[i] <= 50
1 <= target <= 30s
*/

using System;
using System.Collections.Generic;

public class CombinationSumIIs
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(candidates);
        BackTrack(result, new List<int>(), target, 0, candidates);
        return result;
    }

    private void BackTrack(IList<IList<int>> result, IList<int> current, int target, int index, int[] candidates)
    {
        if (target < 0)
        {
            return;
        }
        else if (target == 0)
        {
            result.Add(new List<int>(current));
        }
        else
        {
            for (int i = index; i < candidates.Length; i++)
            {
                if (i > index && candidates[i] == candidates[i - 1])
                {
                    continue;
                }

                current.Add(candidates[i]);
                BackTrack(result, current, target - candidates[i], i + 1, candidates);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}