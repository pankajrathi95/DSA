/*
#41 - https://leetcode.com/problems/first-missing-positive/

Given an unsorted integer array, find the smallest missing positive integer.

Example 1:

Input: [1,2,0]
Output: 3
Example 2:

Input: [3,4,-1,1]
Output: 2
Example 3:

Input: [7,8,9,11,12]
Output: 1
Follow up:

Your algorithm should run in O(n) time and uses constant extra space.
*/

using System.Collections.Generic;

public class FirstMissingPositive
{
    public int FirstMissingPositiveNum(int[] nums)
    {
        HashSet<int> values = new HashSet<int>();
        foreach (var num in nums)
        {
            if (num > 0 && !values.Contains(num))
            {
                values.Add(num);
            }
        }

        int result = 1;
        while (true)
        {
            if (!values.Contains(result))
            {
                return result;
            }

            result++;
        }
    }
}