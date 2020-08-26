/*
https://leetcode.com/problems/longest-substring-without-repeating-characters/
*/

using System;
using System.Collections.Generic;

public class LongestSubstringwithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        int slow = 0, fast = 0, maxLength = 0;
        HashSet<char> values = new HashSet<char>();
        while (fast < s.Length)
        {
            if (!values.Contains(s[fast]))
            {
                values.Add(s[fast]);
                fast++;
            }
            else
            {
                values.Remove(s[slow]);
                slow = slow + 1;
            }

            maxLength = Math.Max(fast - slow, maxLength);
        }

        return maxLength;
    }
}