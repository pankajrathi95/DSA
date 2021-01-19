/*
#1679 - https://leetcode.com/problems/max-number-of-k-sum-pairs/

You are given an integer array nums and an integer k.

In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.

Return the maximum number of operations you can perform on the array.

 

Example 1:

Input: nums = [1,2,3,4], k = 5
Output: 2
Explanation: Starting with nums = [1,2,3,4]:
- Remove numbers 1 and 4, then nums = [2,3]
- Remove numbers 2 and 3, then nums = []
There are no more pairs that sum up to 5, hence a total of 2 operations.
Example 2:

Input: nums = [3,1,3,4,3], k = 6
Output: 1
Explanation: Starting with nums = [3,1,3,4,3]:
- Remove the first two 3's, then nums = [1,4,3]
There are no more pairs that sum up to 6, hence a total of 1 operation.
 

Constraints:

1 <= nums.length <= 105
1 <= nums[i] <= 109
1 <= k <= 109
   Hide Hint #1  
The abstract problem asks to count the number of disjoint pairs with a given sum k.
   Hide Hint #2  
For each possible value x, it can be paired up with k - x.
   Hide Hint #3  
The number of such pairs equals to min(count(x), count(k-x)), unless that x = k / 2, where the number of such pairs will be floor(count(x) / 2).
*/

using System;

public class MaxNumberofKSumPairs
{
    public int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        int start = 0, end = nums.Length - 1;
        int count = 0;
        while (start < end)
        {
            if (nums[start] + nums[end] == k)
            {
                count++;
                end--;
                start++;
            }
            else if (nums[start] + nums[end] > k)
            {
                end--;
            }
            else
            {
                start++;
            }
        }

        return count;
    }
}