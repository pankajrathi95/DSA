/*
Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.

Find all the elements that appear twice in this array.

Could you do it without extra space and in O(n) runtime?

Example:
Input:
[4,3,2,7,8,2,3,1]

Output:
[2,3]
*/

using System;
using System.Collections.Generic;

public class FindAllDuplicatesInAnArray
{
    public IList<int> FindDuplicates(int[] nums)
    {
        HashSet<int> values = new HashSet<int>();
        IList<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] < 0)
            {
                result.Add(index + 1);
            }

            nums[index] = -nums[index];
        }

        return result;
    }
}