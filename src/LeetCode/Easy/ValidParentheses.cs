/*
Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Note that an empty string is also considered valid.

Example 1:

Input: "()"
Output: true
Example 2:

Input: "()[]{}"
Output: true
Example 3:

Input: "(]"
Output: false
Example 4:

Input: "([)]"
Output: false
Example 5:

Input: "{[]}"
Output: true
*/

using System.Collections.Generic;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in s)
        {
            if (ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }
            else if (stack.Count == 0 && (ch == ')' || ch == ']' || ch == '}'))
            {
                return false;
            }
            else if (stack.Count != 0 && ch == ')' && stack.Pop() != '(')
            {
                return false;
            }
            else if (stack.Count != 0 && ch == ']' && stack.Pop() != '[')
            {
                return false;
            }
            else if (stack.Count != 0 && ch == '}' && stack.Pop() != '{')
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}