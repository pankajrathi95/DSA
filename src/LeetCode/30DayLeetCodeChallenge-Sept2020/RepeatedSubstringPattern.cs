/*
Given a non-empty string check if it can be constructed by taking a substring of it and appending multiple copies of the substring together. You may assume the given string consists of lowercase English letters only and its length will not exceed 10000.

 

Example 1:

Input: "abab"
Output: True
Explanation: It's the substring "ab" twice.
Example 2:

Input: "aba"
Output: False
Example 3:

Input: "abcabcabcabc"
Output: True
Explanation: It's the substring "abc" four times. (And the substring "abcabc" twice.)
*/

using System.Collections.Generic;

public class RepeatedSubstringPattern
{
    public bool RepeatedTheSubstringPattern(string s)
    {
        List<int> factors = new List<int>();
        for (int i = 1; i <= s.Length / 2; i++)
        {
            if (s.Length % i == 0)
            {
                factors.Add(i);
            }
        }

        for (int i = factors.Count - 1; i >= 0; i--)
        {
            string str = s.Substring(0, factors[i]);
            string temp = "";
            while (temp.Length < s.Length)
            {
                temp += str;
            }

            if (temp.Equals(s))
            {
                return true;
            }
        }

        return false;
    }
}
