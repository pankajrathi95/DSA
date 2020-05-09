/*
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
using System.Collections;

public class BackspaceStringCompare
{
    public bool BackspaceCompare(string S, string T)
    {
        return String.Equals(Evaluate(S), Evaluate(T));
    }

    public string Evaluate(string str)
    {
        Stack myStack = new Stack();
        foreach (char ch in str)
        {
            if (ch == '#' && myStack.Count != 0)
            {
                myStack.Pop();
            }
            else
            {
                myStack.Push(ch);
            }
        }

        object[] objectArray = myStack.ToArray();
        string newString = string.Empty;
        foreach (object o in objectArray)
        {
            if ((char)o != '#')
            {
                newString += (char)o;
            }
        }

        return newString;
    }
}