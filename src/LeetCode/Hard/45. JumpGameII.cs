/*
https://leetcode.com/problems/jump-game-ii/
Given an array of non-negative integers nums, you are initially positioned at the first index of the array.

Each element in the array represents your maximum jump length at that position.

Your goal is to reach the last index in the minimum number of jumps.

You can assume that you can always reach the last index.

 

Example 1:

Input: nums = [2,3,1,1,4]
Output: 2
Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.
Example 2:

Input: nums = [2,3,0,1,4]
Output: 2
 

Constraints:

1 <= nums.length <= 3 * 104
0 <= nums[i] <= 105
*/

using System;

public class JumpGameII
{
    public int Jump(int[] nums)
    {
        int jumps = 1;
        if (nums.Length == 1)
        {
            return 0;
        }

        int curr_end = nums[0];
        int farthest = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (i == nums.Length - 1)
            {
                return jumps;
            }

            farthest = Math.Max(farthest, i + nums[i]);
            if (i == curr_end)
            {
                jumps++;
                curr_end = farthest;
            }
        }

        return jumps;
    }
}