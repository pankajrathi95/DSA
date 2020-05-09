/*

Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

Examples:

s = "leetcode"
return 0.

s = "loveleetcode",
return 2.
Note: You may assume the string contain only lowercase letters.
*/

using System.Collections.Generic;

public class FirstUniqueCharacterInAString
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> values = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if (values.ContainsKey(ch))
            {
                values[ch]++;
            }
            else
            {
                values.Add(ch, 1);
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (values[s[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}