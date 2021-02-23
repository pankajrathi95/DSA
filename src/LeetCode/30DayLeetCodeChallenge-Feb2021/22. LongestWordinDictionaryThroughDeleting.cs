/*
#524 - https://leetcode.com/problems/longest-word-in-dictionary-through-deleting/

Given a string and a string dictionary, find the longest string in the dictionary that can be formed by deleting some characters of the given string. If there are more than one possible results, return the longest word with the smallest lexicographical order. If there is no possible result, return the empty string.

Example 1:
Input:
s = "abpcplea", d = ["ale","apple","monkey","plea"]

Output: 
"apple"
Example 2:
Input:
s = "abpcplea", d = ["a","b","c"]

Output: 
"a"
Note:
All the strings in the input will only contain lower-case letters.
The size of the dictionary won't exceed 1,000.
The length of all the strings in the input won't exceed 1,000.
*/

using System;
using System.Collections.Generic;

public class LongestWordinDictionaryThroughDeleting
{
    public string FindLongestWord(string s, IList<string> d)
    {
        IList<string> result = new List<string>();
        foreach (var word in d)
        {
            if (SubSequence(s, word))
            {
                result.Add(word);
            }
        }


        if (result.Count == 0)
        {
            return "";
        }
        else
        {
            string longest = "";
            foreach (var res in result)
            {
                if (res.Length > longest.Length ||
                    (res.Length == longest.Length && String.Compare(longest, res) > 0))
                {
                    longest = res;
                }
            }

            return longest;
        }
    }

    public bool SubSequence(string s, string dic)
    {
        int i = 0, j = 0;
        while (i < s.Length && j < dic.Length)
        {
            if (s[i++] == dic[j])
                j++;
        }

        return j == dic.Length;
    }
}