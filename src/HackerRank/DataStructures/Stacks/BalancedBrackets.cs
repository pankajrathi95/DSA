/*
https://www.hackerrank.com/challenges/balanced-brackets/problem
*/

using System.Collections.Generic;

class BalancedBrackets
{
    public static string isBalanced(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char ch in s)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            else if (stack.Count == 0 && (ch == ')' || ch == '}' || ch == ']'))
            {
                return "NO";
            }
            else if (stack.Count != 0 && ch == ')' && stack.Pop() != '(')
            {
                return "NO";
            }
            else if (stack.Count != 0 && ch == '}' && stack.Pop() != '{')
            {
                return "NO";
            }
            else if (stack.Count != 0 && ch == ']' && stack.Pop() != '[')
            {
                return "NO";
            }
        }

        return stack.Count == 0 ? "YES" : "NO";
    }
}