/*
Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, determine if s can be segmented into a space-separated sequence of one or more dictionary words.

Note:

The same word in the dictionary may be reused multiple times in the segmentation.
You may assume the dictionary does not contain duplicate words.
Example 1:

Input: s = "leetcode", wordDict = ["leet", "code"]
Output: true
Explanation: Return true because "leetcode" can be segmented as "leet code".
Example 2:

Input: s = "applepenapple", wordDict = ["apple", "pen"]
Output: true
Explanation: Return true because "applepenapple" can be segmented as "apple pen apple".
             Note that you are allowed to reuse a dictionary word.
Example 3:

Input: s = "catsandog", wordDict = ["cats", "dog", "sand", "and", "cat"]
Output: false
*/

using System.Collections.Generic;

public class WordBreak
{
    public bool WordBreakk(string s, IList<string> wordDict)
    {
        return Dfs(s, wordDict, new Dictionary<string, bool>());
    }

    private bool Dfs(string s, IList<string> wordDict, Dictionary<string, bool> map)
    {
        if (s.Equals(""))
        {
            return true;
        }

        if (map.ContainsKey(s))
        {
            return map[s];
        }

        for (int i = 1; i <= s.Length; i++)
        {
            if (wordDict.Contains(s.Substring(0, i)) && Dfs(s.Substring(i), wordDict, map))
            {
                map.Add(s.Substring(i), true);
                return true;
            }
        }

        map.Add(s, false);
        return false;
    }
}