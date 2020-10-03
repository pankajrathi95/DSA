/*
#532 - https://leetcode.com/problems/k-diff-pairs-in-an-array/
Given an array of integers nums and an integer k, return the number of unique k-diff pairs in the array.

A k-diff pair is an integer pair (nums[i], nums[j]), where the following are true:

0 <= i, j < nums.length
i != j
a <= b
b - a == k
 

Example 1:

Input: nums = [3,1,4,1,5], k = 2
Output: 2
Explanation: There are two 2-diff pairs in the array, (1, 3) and (3, 5).
Although we have two 1s in the input, we should only return the number of unique pairs.
Example 2:

Input: nums = [1,2,3,4,5], k = 1
Output: 4
Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and (4, 5).
Example 3:

Input: nums = [1,3,1,5,4], k = 0
Output: 1
Explanation: There is one 0-diff pair in the array, (1, 1).
Example 4:

Input: nums = [1,2,4,4,3,3,0,9,2,3], k = 3
Output: 2
Example 5:

Input: nums = [-1,-2,-3], k = 1
Output: 2
 

Constraints:

1 <= nums.length <= 104
-107 <= nums[i] <= 107
0 <= k <= 107
*/

using System;
using System.Collections.Generic;

public class KDIffPairsInAnArray
{
    //non-optimal solution
    public int FindPairs(int[] nums, int k)
    {
        Array.Sort(nums);
        if (nums.Length == 1)
        {
            return 0;
        }

        if (nums.Length == 2)
        {
            return nums[1] - nums[0] == k ? 1 : 0;
        }

        HashSet<int> visited = new HashSet<int>();
        int start = 0;
        int last = nums.Length - 1;
        int count = 0;
        while (start < nums.Length)
        {
            if (start == last)
            {
                start++;
                last = nums.Length - 1;
            }
            else if (nums[start] + k == nums[last])
            {
                if (!visited.Contains(nums[start] + k))
                {
                    visited.Add(nums[start] + k);
                    count++;
                }

                start++;
                last = nums.Length - 1;


                continue;
            }
            else if (nums[start] + k < nums[last])
            {
                last--;
            }
            else
            {
                start++;
                last = nums.Length - 1;
            }
        }

        return count;
    }

    //optimal solution
    public int FindThePairs(int[] nums, int k)
    {
        if (k < 0)
        {
            return 0;
        }

        int count = 0;
        Dictionary<int, int> values = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (values.ContainsKey(num))
            {
                values[num]++;
            }
            else
            {
                values.Add(num, 1);
            }
        }

        foreach (var kvp in values)
        {
            if (k == 0)
            {
                if (kvp.Value >= 2)
                {
                    count++;
                }
            }
            else
            {
                if (values.ContainsKey(kvp.Key + k))
                {
                    count++;
                }
            }
        }

        return count;
    }

}