/*
https://leetcode.com/problems/basic-calculator-ii/
Given a string s which represents an expression, evaluate this expression and return its value. 

The integer division should truncate toward zero.

 

Example 1:

Input: s = "3+2*2"
Output: 7
Example 2:

Input: s = " 3/2 "
Output: 1
Example 3:

Input: s = " 3+5 / 2 "
Output: 5
 

Constraints:

1 <= s.length <= 3 * 105
s consists of integers and operators ('+', '-', '*', '/') separated by some number of spaces.
s represents a valid expression.
All the integers in the expression are non-negative integers in the range [0, 231 - 1].
The answer is guaranteed to fit in a 32-bit integer.
*/

using System;
using System.Collections.Generic;

public class BasicCalculatorII
{
    public int Calculate(string s)
    {
        if (s == null || s.Length == 0)
        {
            return 0;
        }

        Stack<int> stack = new Stack<int>();
        int current = 0;
        char ops = '+';
        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (Char.IsDigit(ch))
            {
                current = current * 10 + (ch - '0');
            }

            if (!Char.IsDigit(ch) && ch != ' ' || i == s.Length - 1)
            {
                if (ops == '+')
                {
                    stack.Push(current);
                }
                else if (ops == '-')
                {
                    stack.Push(-current);
                }
                else if (ops == '*')
                {
                    stack.Push(stack.Pop() * current);
                }
                else if (ops == '/')
                {
                    stack.Push(stack.Pop() / current);
                }
                ops = ch;
                current = 0;
            }
        }

        int res = 0;
        while (stack.Count != 0)
        {
            res += stack.Pop();
        }

        return res;
    }
}
