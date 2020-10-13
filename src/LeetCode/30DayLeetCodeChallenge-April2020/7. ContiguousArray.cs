/*
#525 - https://leetcode.com/problems/contiguous-array/
Given a binary array, find the maximum length of a contiguous subarray with equal number of 0 and 1.

Example 1:
Input: [0,1]
Output: 2
Explanation: [0, 1] is the longest contiguous subarray with equal number of 0 and 1.
Example 2:
Input: [0,1,0]
Output: 2
Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
Note: The length of the given binary array will not exceed 50,000.
*/

using System;
using System.Collections.Generic;

class ContiguousArray
{
    public int FindMaxLength(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return 0;
        }

        Dictionary<int, int> values = new Dictionary<int, int>();
        int count = 0;
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            count += +(nums[i] == 1 ? 1 : -1);

            if (count == 0)
            {
                max = Math.Max(max, i + 1);
            }

            if (values.ContainsKey(count))
            {
                max = Math.Max(max, i - values[count]);
            }
            else
            {
                values.Add(count, i);
            }
        }

        return max;
    }
}