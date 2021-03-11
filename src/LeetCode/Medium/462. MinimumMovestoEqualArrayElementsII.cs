/*
https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii/
Given a non-empty integer array, find the minimum number of moves required to make all array elements equal, where a move is incrementing a selected element by 1 or decrementing a selected element by 1.

You may assume the array's length is at most 10,000.

Example:

Input:
[1,2,3]

Output:
2

Explanation:
Only two moves are needed (remember each move increments or decrements one element):

[1,2,3]  =>  [2,2,3]  =>  [2,2,2]
*/

using System;

public class MinimumMovestoEqualArrayElementsII
{
    //This question is to find the deviation from the median. We can sort the array and find the median and then 
    //just compare each value and calculate the difference and keep adding. It would give us the minimum number of moves required.
    public int MinMoves2(int[] nums)
    {
        int n = nums.Length;
        Array.Sort(nums);
        int median = n % 2 == 0 ? (nums[n / 2] + nums[n / 2 - 1]) / 2 : nums[n / 2];
        int result = 0;
        foreach (var num in nums)
        {
            result += Math.Abs(median - num);
        }

        return result;
    }
}