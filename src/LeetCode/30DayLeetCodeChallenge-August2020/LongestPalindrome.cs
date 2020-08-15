/*
Given a string which consists of lowercase or uppercase letters, find the length of the longest palindromes that can be built with those letters.

This is case sensitive, for example "Aa" is not considered a palindrome here.

Note:
Assume the length of given string will not exceed 1,010.

Example:

Input:
"abccccdd"

Output:
7

Explanation:
One longest palindrome that can be built is "dccaccd", whose length is 7.
*/

using System.Collections.Generic;

public class LongestPalindrome
{
    public int FindLongestPalindrome(string s)
    {
        Dictionary<char, int> values = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (!values.ContainsKey(c))
            {
                values.Add(c, 1);
            }
            else
            {
                values[c]++;
            }
        }

        int result = 0;
        foreach (var kvp in values)
        {
            if (kvp.Value % 2 == 0)
            {
                result += kvp.Value;
            }
            else if (kvp.Value % 2 != 0 && kvp.Value > 1)
            {
                result += kvp.Value - 1;
            }
        }

        foreach (var kvp in values)
        {
            if (kvp.Value == 1 || kvp.Value % 2 != 0)
            {
                result += 1;
                break;
            }
        }

        return result;
    }
}