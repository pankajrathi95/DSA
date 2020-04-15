/*
You are given a string s containing lowercase English letters, and a matrix shift, where shift[i] = [direction, amount]:

direction can be 0 (for left shift) or 1 (for right shift). 
amount is the amount by which string s is to be shifted.
A left shift by 1 means remove the first character of s and append it to the end.
Similarly, a right shift by 1 means remove the last character of s and add it to the beginning.
Return the final string after all operations.

 

Example 1:

Input: s = "abc", shift = [[0,1],[1,2]]
Output: "cab"
Explanation: 
[0,1] means shift to left by 1. "abc" -> "bca"
[1,2] means shift to right by 2. "bca" -> "cab"
Example 2:

Input: s = "abcdefg", shift = [[1,1],[1,1],[0,2],[1,3]]
Output: "efgabcd"
Explanation:  
[1,1] means shift to right by 1. "abcdefg" -> "gabcdef"
[1,1] means shift to right by 1. "gabcdef" -> "fgabcde"
[0,2] means shift to left by 2. "fgabcde" -> "abcdefg"
[1,3] means shift to right by 3. "abcdefg" -> "efgabcd"
 
 */

using System;
using System.Collections.Generic;

public class PerformStringShift
{
    public string StringShift(string s, int[][] shift)
    {
        Dictionary<int, int> operations = new Dictionary<int, int>();

        foreach (int[] num in shift)
        {
            if (num[0] == 0)
            {
                if (operations.ContainsKey(0))
                {
                    operations[0] += num[1];
                }
                else
                {
                    operations.Add(0, num[1]);
                }
            }
            else
            {
                if (operations.ContainsKey(1))
                {
                    operations[1] += num[1];
                }
                else
                {
                    operations.Add(1, num[1]);
                }
            }
        }

        if (operations[0] == operations[1])
        {
            return s;
        }

        int values = (operations[0] - operations[1]) % s.Length;
        if (values > 0)
        {
            //left shift
            return string.Concat(s.Substring(values, s.Length - values), s.Substring(0, values));
        }
        else
        {
            //right shift
            return string.Concat(s.Substring(s.Length - Math.Abs(values), Math.Abs(values)), s.Substring(0, s.Length - Math.Abs(values)));
        }
    }
}