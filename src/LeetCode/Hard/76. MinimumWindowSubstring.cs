/*
https://leetcode.com/problems/minimum-window-substring/
Given two strings s and t, return the minimum window in s which will contain all the characters in t. If there is no such window in s that covers all characters in t, return the empty string "".

Note that If there is such a window, it is guaranteed that there will always be only one unique minimum window in s.

 

Example 1:

Input: s = "ADOBECODEBANC", t = "ABC"
Output: "BANC"
Example 2:

Input: s = "a", t = "a"
Output: "a"
 

Constraints:

1 <= s.length, t.length <= 105
s and t consist of English letters.
 

Follow up: Could you find an algorithm that runs in O(n) time?
*/

using System;
using System.Collections.Generic;

public class MinimumWindowSubstring
{
    public string MinWindow(string s, string t)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if (!map.ContainsKey(ch))
            {
                map.Add(ch, 0);
            }
        }

        foreach (var ch in t)
        {
            if (map.ContainsKey(ch))
            {
                map[ch]++;
            }
            else
            {
                return string.Empty;
            }
        }

        int start = 0, end = 0, minLength = Int32.MaxValue, counter = t.Length;
        string result = string.Empty;
        while (end < s.Length)
        {
            if (map[s[end]] > 0)
            {
                counter--;
            }

            map[s[end]]--;
            end++;
            while (counter == 0)
            {
                if (minLength > end - start)
                {
                    minLength = end - start;
                    result = s.Substring(start, minLength);
                }

                map[s[start]]++;
                if (map[s[start]] > 0)
                {
                    counter++;
                }

                start++;
            }
        }

        return result;
    }
}