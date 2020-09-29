/*
#844 - https://leetcode.com/problems/backspace-string-compare/

Given two strings S and T, return if they are equal when both are typed into empty text editors. # means a backspace character.

Example 1:

Input: S = "ab#c", T = "ad#c"
Output: true
Explanation: Both S and T become "ac".
Example 2:

Input: S = "ab##", T = "c#d#"
Output: true
Explanation: Both S and T become "".
Example 3:

Input: S = "a##c", T = "#a#c"
Output: true
Explanation: Both S and T become "c".
Example 4:

Input: S = "a#c", T = "b"
Output: false
Explanation: S becomes "c" while T becomes "b".

*/

using System;
using System.Collections.Generic;

public class BackspaceStringCompare
{
    public bool BackspaceCompare(string S, string T)
    {
        return String.Equals(Evaluate(S), Evaluate(T));
    }

    public string Evaluate(string str)
    {
        Stack<char> stack = new Stack<char>();
        foreach (var ch in str)
        {
            if (ch == '#' && stack.Count != 0)
            {
                stack.Pop();
            }
            else if (ch != '#')
            {
                stack.Push(ch);
            }
        }

        return new String(stack.ToArray());
    }
}