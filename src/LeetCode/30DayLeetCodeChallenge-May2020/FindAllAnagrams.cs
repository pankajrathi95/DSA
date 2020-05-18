/*
Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.

Strings consists of lowercase English letters only and the length of both strings s and p will not be larger than 20,100.

The order of output does not matter.

Example 1:

Input:
s: "cbaebabacd" p: "abc"

Output:
[0, 6]

Explanation:
The substring with start index = 0 is "cba", which is an anagram of "abc".
The substring with start index = 6 is "bac", which is an anagram of "abc".
Example 2:

Input:
s: "abab" p: "ab"

Output:
[0, 1, 2]

Explanation:
The substring with start index = 0 is "ab", which is an anagram of "ab".
The substring with start index = 1 is "ba", which is an anagram of "ab".
The substring with start index = 2 is "ab", which is an anagram of "ab".
*/

using System.Collections.Generic;

public class FindAllAnagrams
{
    public IList<int> FindAnagrams(string s, string p)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        List<int> list = new List<int>();

        foreach (char ch in p)
        {
            if (!map.ContainsKey(ch))
            {
                map.Add(ch, 1);
            }
            else
            {
                map[ch]++;
            }
        }

        int windowStart = 0;
        int windowEnd = 0;

        while (windowEnd < s.Length)
        {
            if (map.ContainsKey(s[windowEnd]))
            {
                if (map[s[windowEnd]] == 1)
                {
                    map.Remove(s[windowEnd]);
                }
                else
                {
                    map[s[windowEnd]]--;
                }

                windowEnd++;

                if (windowEnd - windowStart == p.Length)
                {
                    list.Add(windowStart);
                }
            }
            else if (windowStart == windowEnd)
            {
                windowStart++;
                windowEnd++;
            }
            else
            {
                if (!map.ContainsKey(s[windowStart]))
                {
                    map.Add(s[windowStart], 1);
                }
                else
                {
                    map[s[windowStart]]++;
                }
                windowStart++;
            }
        }

        return list;
    }
}