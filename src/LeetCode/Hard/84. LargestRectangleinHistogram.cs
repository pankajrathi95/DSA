/*
#84 - https://leetcode.com/problems/largest-rectangle-in-histogram/
Given n non-negative integers representing the histogram's bar height where the width of each bar is 1, find the area of largest rectangle in the histogram.

Above is a histogram where width of each bar is 1, given height = [2,1,5,6,2,3].
The largest rectangle is shown in the shaded area, which has area = 10 unit. 

Example:

Input: [2,1,5,6,2,3]
Output: 10
*/

using System;
using System.Collections.Generic;

public class LargestRectangleinHistogram
{
    public int LargestRectangleArea(int[] heights)
    {
        if (heights.Length == 0)
        {
            return 0;
        }

        int n = heights.Length;
        int[] right = new int[n];
        int[] left = new int[n];
        Stack<int> stack = new Stack<int>();
        for (int i = n - 1; i >= 0; i--)
        {
            while (stack.Count != 0 && heights[stack.Peek()] >= heights[i])
            {
                stack.Pop();
            }

            right[i] = stack.Count == 0 ? n : stack.Peek();
            stack.Push(i);
        }

        stack.Clear();
        for (int i = 0; i < n; i++)
        {
            while (stack.Count != 0 && heights[stack.Peek()] >= heights[i])
            {
                stack.Pop();
            }

            left[i] = stack.Count == 0 ? -1 : stack.Peek();
            stack.Push(i);
        }

        int area = 0;
        for (int i = 0; i < n; i++)
        {
            area = Math.Max(area, (right[i] - left[i] - 1) * heights[i]);
        }

        return area;
    }
}