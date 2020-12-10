/*
#503 - https://leetcode.com/problems/next-greater-element-ii/
Given a circular array (the next element of the last element is the first element of the array), print the Next Greater Number for every element. The Next Greater Number of a number x is the first greater number to its traversing-order next in the array, which means you could search circularly to find its next greater number. If it doesn't exist, output -1 for this number.

Example 1:
Input: [1,2,1]
Output: [2,-1,2]
Explanation: The first 1's next greater number is 2; 
The number 2 can't find next greater number; 
The second 1's next greater number needs to search circularly, which is also 2.
Note: The length of given array won't exceed 10000.
*/

using System.Collections.Generic;

public class NextGreaterElementII
{
    public int[] NextGreaterElements(int[] nums)
    {
        int[] result = new int[nums.Length];
        Stack<int> stack = new Stack<int>();
        for (int i = 2 * nums.Length - 1; i >= 0; i--)
        {
            while (stack.Count != 0 && nums[stack.Peek()] <= nums[i % nums.Length])
            {
                stack.Pop();
            }

            result[i % nums.Length] = stack.Count == 0 ? -1 : nums[stack.Peek()];
            stack.Push(i % nums.Length);
        }

        return result;
    }
}