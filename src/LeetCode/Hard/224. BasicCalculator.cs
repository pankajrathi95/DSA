/*
https://leetcode.com/problems/basic-calculator/
Given a string s representing an expression, implement a basic calculator to evaluate it.

 

Example 1:

Input: s = "1 + 1"
Output: 2
Example 2:

Input: s = " 2-1 + 2 "
Output: 3
Example 3:

Input: s = "(1+(4+5+2)-3)+(6+8)"
Output: 23
 

Constraints:

1 <= s.length <= 3 * 105
s consists of digits, '+', '-', '(', ')', and ' '.
s represents a valid expression.
*/

using System.Collections.Generic;

public class BasicCalculator
{
    public int Calculate(string s)
    {
        Stack<int> stack = new Stack<int>();
        int sum = 0, sign = 1;
        for (int i = 0; i < s.Length; i++)
        {
            //number
            if (s[i] >= '0' && s[i] <= '9')
            {
                int num = 0;
                while (i < s.Length && s[i] >= '0' && s[i] <= '9')
                {
                    num = num * 10 + s[i] - '0';
                    i++;
                }

                sum += num * sign;
                i--;
            }
            else if (s[i] == '-')
            {
                sign = -1;
            }
            else if (s[i] == '+')
            {
                sign = 1;
            }
            else if (s[i] == '(')
            {
                stack.Push(sum);
                stack.Push(sign);
                sign = 1;
                sum = 0;
            }
            else if (s[i] == ')')
            {
                sum = sum * stack.Pop();
                sum += stack.Pop();
            }
        }

        return sum;
    }
}