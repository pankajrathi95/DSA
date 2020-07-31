/*
Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, add spaces in s to construct a sentence where each word is a valid dictionary word. Return all such possible sentences.

Note:

The same word in the dictionary may be reused multiple times in the segmentation.
You may assume the dictionary does not contain duplicate words.
Example 1:

Input:
s = "catsanddog"
wordDict = ["cat", "cats", "and", "sand", "dog"]
Output:
[
  "cats and dog",
  "cat sand dog"
]
Example 2:

Input:
s = "pineapplepenapple"
wordDict = ["apple", "pen", "applepen", "pine", "pineapple"]
Output:
[
  "pine apple pen apple",
  "pineapple pen apple",
  "pine applepen apple"
]
Explanation: Note that you are allowed to reuse a dictionary word.
Example 3:

Input:
s = "catsandog"
wordDict = ["cats", "dog", "sand", "and", "cat"]
Output:
[]
*/

using System;
using System.Collections.Generic;

public class WordBreakII
{
    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        return WordBreak_Rec(s, wordDict, new Dictionary<string, IList<string>>());
    }

    private IList<string> WordBreak_Rec(string s, IList<string> wordDict, Dictionary<string, IList<string>> memo)
    {
        if (memo.ContainsKey(s))
        {
            return memo[s];
        }
        IList<string> result = new List<string>();
        if (s.Length == 0)
        {
            result.Add("");
            return result;
        }

        foreach (string word in wordDict)
        {
            if (s.StartsWith(word))
            {
                string sub = s.Substring(word.Length);
                IList<string> subStrings = WordBreak_Rec(sub, wordDict, memo);
                foreach (string subString in subStrings)
                {
                    string optionalSpace = String.IsNullOrEmpty(subString) ? "" : " ";
                    result.Add(word + optionalSpace + subString);
                }
            }
        }

        memo.Add(s, result);
        return result;
    }
}