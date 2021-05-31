/*
https://leetcode.com/problems/maximum-gap/

Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.

You must write an algorithm that runs in linear time and uses linear extra space.

 

Example 1:

Input: nums = [3,6,9,1]
Output: 3
Explanation: The sorted form of the array is [1,3,6,9], either (3,6) or (6,9) has the maximum difference 3.
Example 2:

Input: nums = [10]
Output: 0
Explanation: The array contains less than 2 elements, therefore return 0.
 

Constraints:

1 <= nums.length <= 104
0 <= nums[i] <= 109
*/

using System;
using System.Collections.Generic;

public class MaximumGap {
    public int FindMaximumGap(int[] nums) {
        if (nums.Length < 2)
            return 0;
        
        SortedSet<int> set = new SortedSet<int>();
        foreach (var num in nums)
            set.Add(num);
        
        int max = 0;
        int first = set.Min;
        foreach (var s in set)
        {
            max = Math.Max(max, s - first);
            first = s;
        }
        
        return max;
    }
}