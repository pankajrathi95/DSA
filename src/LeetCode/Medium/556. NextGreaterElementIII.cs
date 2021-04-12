/*
https://leetcode.com/problems/next-greater-element-iii/

Given a positive integer n, find the smallest integer which has exactly the same digits existing in the integer n and is greater in value than n. If no such positive integer exists, return -1.

Note that the returned integer should fit in 32-bit integer, if there is a valid answer but it does not fit in 32-bit integer, return -1.

 

Example 1:

Input: n = 12
Output: 21
Example 2:

Input: n = 21
Output: -1
 

Constraints:

1 <= n <= 231 - 1
*/

using System;

public class NextGreaterElementIII
{
    public int NextGreaterElement(int n)
    {
        char[] arr = n.ToString().ToCharArray();
        int i = arr.Length - 2;
        while (i >= 0 && arr[i] >= arr[i + 1])
            i--;

        if (i < 0)
            return -1;

        int j = arr.Length - 1;
        while (arr[j] <= arr[i])
            j--;

        Swap(arr, i, j);
        Reverse(arr, i + 1, arr.Length - 1);
        long result = Convert.ToInt64(new String(arr));
        return result <= Int32.MaxValue ? (int)result : -1;
    }

    private void Reverse(char[] arr, int start, int end)
    {
        while (start < end)
        {
            char temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
    }

    private void Swap(char[] arr, int i, int j)
    {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}