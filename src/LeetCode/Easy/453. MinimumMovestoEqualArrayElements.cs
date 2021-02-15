/*
https://leetcode.com/problems/minimum-moves-to-equal-array-elements/
Given a non-empty integer array of size n, find the minimum number of moves required to make all array elements equal, where a move is incrementing n - 1 elements by 1.

Example:

Input:
[1,2,3]

Output:
3

Explanation:
Only three moves are needed (remember each move increments two elements):

[1,2,3]  =>  [2,3,3]  =>  [3,4,3]  =>  [4,4,4]
*/

using System;

public class MinimumMovestoEqualArrayElements
{
    public int MinMoves(int[] nums)
    {
        Array.Sort(nums);
        int result = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result += nums[i] - nums[0];
        }

        return result;
    }
}