/*
Given a non-negative integer num represented as a string, remove k digits from the number so that the new number is the smallest possible.

Note:
The length of num is less than 10002 and will be ≥ k.
The given num does not contain any leading zero.
Example 1:

Input: num = "1432219", k = 3
Output: "1219"
Explanation: Remove the three digits 4, 3, and 2 to form the new number 1219 which is the smallest.
Example 2:

Input: num = "10200", k = 1
Output: "200"
Explanation: Remove the leading 1 and the number is 200. Note that the output must not contain leading zeroes.
Example 3:

Input: num = "10", k = 2
Output: "0"
Explanation: Remove all the digits from the number and it is left with nothing which is 0.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RemoveKDigits
{
    public string RemoveKdigits(string num, int k)
    {
        if (k == 0)
        {
            return num;
        }

        if (k == num.Length)
        {
            return "0";
        }

        Stack<char> stack = new Stack<char>();

        foreach (char ch in num)
        {
            while (stack.Count != 0 && k > 0 && ch < stack.Peek())
            {
                k--;
                stack.Pop();
            }

            stack.Push(ch);
        }

        for (int i = 0; i < k; i++)
        {
            stack.Pop();
        }

        StringBuilder str = new StringBuilder();

        while (stack.Count != 0)
        {
            str.Append(stack.Pop());
        }

        string val = new String(str.ToString().ToCharArray().Reverse().ToArray());

        return val.TrimStart('0').Length == 0 ? "0" : val.TrimStart('0');
    }
}