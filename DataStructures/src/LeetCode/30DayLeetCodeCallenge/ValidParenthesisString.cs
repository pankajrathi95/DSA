/*
Given a string containing only three types of characters: '(', ')' and '*', write a function to check whether this string is valid. We define the validity of a string by these rules:

Any left parenthesis '(' must have a corresponding right parenthesis ')'.
Any right parenthesis ')' must have a corresponding left parenthesis '('.
Left parenthesis '(' must go before the corresponding right parenthesis ')'.
'*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string.
An empty string is also valid.
Example 1:
Input: "()"
Output: True
Example 2:
Input: "(*)"
Output: True
Example 3:
Input: "(*))"
Output: True

*/


using System.Collections.Generic;

public class ValidParenthesisString
{
    public bool CheckValidString(string s)
    {
        int balance = 0;
        foreach (char ch in s)
        {
            if (ch == ')')
            {
                balance--;
            }
            else
            {
                balance++;
            }

            if (balance < 0)
            {
                return false;
            }
        }

        if (balance == 0)
        {
            return true;
        }

        balance = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '(')
            {
                balance--;
            }
            else
            {
                balance++;
            }

            if (balance < 0)
            {
                return false;
            }
        }

        return true;
    }
}