/*
#131 - https://leetcode.com/problems/palindrome-partitioning/
Given a string s, partition s such that every substring of the partition is a palindrome.

Return all possible palindrome partitioning of s.

Example:

Input: "aab"
Output:
[
  ["aa","b"],
  ["a","a","b"]
]
*/

using System.Collections.Generic;

public class PalindromePartitionings
{
    public IList<IList<string>> Partition(string s)
    {
        IList<IList<string>> result = new List<IList<string>>();
        BackTrack(result, new List<string>(), 0, s);
        return result;
    }

    private void BackTrack(IList<IList<string>> result, IList<string> current, int index, string s)
    {
        if (index == s.Length)
        {
            result.Add(new List<string>(current));
            return;
        }

        for (int i = index; i < s.Length; i++)
        {
            if (IsPalindrome(s, index, i))
            {
                current.Add(s.Substring(index, i + 1 - index));
                BackTrack(result, current, i + 1, s);
                current.RemoveAt(current.Count - 1);
            }
        }
    }

    private bool IsPalindrome(string s, int start, int end)
    {
        while (start < end)
        {
            if (s[start++] != s[end--])
            {
                return false;
            }
        }

        return true;
    }
}