/*
#966 - https://leetcode.com/problems/vowel-spellchecker/

Given a wordlist, we want to implement a spellchecker that converts a query word into a correct word.

For a given query word, the spell checker handles two categories of spelling mistakes:

Capitalization: If the query matches a word in the wordlist (case-insensitive), then the query word is returned with the same case as the case in the wordlist.
Example: wordlist = ["yellow"], query = "YellOw": correct = "yellow"
Example: wordlist = ["Yellow"], query = "yellow": correct = "Yellow"
Example: wordlist = ["yellow"], query = "yellow": correct = "yellow"
Vowel Errors: If after replacing the vowels ('a', 'e', 'i', 'o', 'u') of the query word with any vowel individually, it matches a word in the wordlist (case-insensitive), then the query word is returned with the same case as the match in the wordlist.
Example: wordlist = ["YellOw"], query = "yollow": correct = "YellOw"
Example: wordlist = ["YellOw"], query = "yeellow": correct = "" (no match)
Example: wordlist = ["YellOw"], query = "yllw": correct = "" (no match)
In addition, the spell checker operates under the following precedence rules:

When the query exactly matches a word in the wordlist (case-sensitive), you should return the same word back.
When the query matches a word up to capitlization, you should return the first such match in the wordlist.
When the query matches a word up to vowel errors, you should return the first such match in the wordlist.
If the query has no matches in the wordlist, you should return the empty string.
Given some queries, return a list of words answer, where answer[i] is the correct word for query = queries[i].

 

Example 1:

Input: wordlist = ["KiTe","kite","hare","Hare"], queries = ["kite","Kite","KiTe","Hare","HARE","Hear","hear","keti","keet","keto"]
Output: ["kite","KiTe","KiTe","Hare","hare","","","KiTe","","KiTe"]
 

Note:

1 <= wordlist.length <= 5000
1 <= queries.length <= 5000
1 <= wordlist[i].length <= 7
1 <= queries[i].length <= 7
All strings in wordlist and queries consist only of english letters.
*/

using System.Collections.Generic;
using System.Text;

public class VowelSpellchecker
{
    public string[] Spellchecker(string[] wordlist, string[] queries)
    {
        HashSet<string> exactMatch = new HashSet<string>();
        Dictionary<string, string> caseInsensitive = new Dictionary<string, string>();
        Dictionary<string, string> caseInsensitiveConsonants = new Dictionary<string, string>();
        foreach (var word in wordlist)
        {
            exactMatch.Add(word);
            if (!caseInsensitive.ContainsKey(word.ToLower()))
            {
                caseInsensitive.Add(word.ToLower(), word);
            }

            if (!caseInsensitiveConsonants.ContainsKey(DeVowel(word.ToLower())))
            {
                caseInsensitiveConsonants.Add(DeVowel(word.ToLower()), word);
            }
        }

        string[] result = new string[queries.Length];
        int i = 0;
        foreach (var query in queries)
        {
            if (exactMatch.Contains(query))
            {
                result[i++] = query;
            }
            else if (caseInsensitive.ContainsKey(query.ToLower()))
            {
                result[i++] = caseInsensitive[query.ToLower()];
            }
            else if (caseInsensitiveConsonants.ContainsKey(DeVowel(query.ToLower())))
            {
                result[i++] = caseInsensitiveConsonants[DeVowel(query.ToLower())];
            }
            else
            {
                result[i++] = "";
            }

        }

        return result;

    }

    private string DeVowel(string word)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var ch in word)
        {
            sb.Append(IsVowel(ch) ? '*' : ch);
        }

        return sb.ToString();
    }

    private bool IsVowel(char ch)
    {
        return (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');
    }
}