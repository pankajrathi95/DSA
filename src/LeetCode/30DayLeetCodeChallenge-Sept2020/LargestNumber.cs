/*
Given a list of non negative integers, arrange them such that they form the largest number.

Example 1:

Input: [10,2]
Output: "210"
Example 2:

Input: [3,30,34,5,9]
Output: "9534330"
Note: The result may be very large, so you need to return a string instead of an integer.
*/


using System;
using System.Text;

public class LargestNumber
{
    public string FindLargestNumber(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return "0";
        }
        StringBuilder sb = new StringBuilder();
        string[] arr = new string[nums.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = nums[i].ToString();
        }

        Array.Sort(arr, (a, b) =>
        {
            return (b + a).CompareTo(a + b);
        });

        if (arr[0] == "0")
        {
            return "0";
        }

        foreach (var item in arr)
        {
            sb.Append(item);
        }

        return sb.ToString();
    }
}