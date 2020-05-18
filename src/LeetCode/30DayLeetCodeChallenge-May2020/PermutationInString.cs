/*
Given two strings s1 and s2, write a function to return true if s2 contains the permutation of s1. In other words, one of the first string's permutations is the substring of the second string.

Example 1:

Input: s1 = "ab" s2 = "eidbaooo"
Output: True
Explanation: s2 contains one permutation of s1 ("ba").
Example 2:

Input:s1= "ab" s2 = "eidboaoo"
Output: False
 

Note:

1. The input strings only contain lower case letters.
2. The length of both given strings is in range [1, 10,000].

   Hide Hint #1  
Obviously, brute force will result in TLE. Think of something else.
   Hide Hint #2  
How will you check whether one string is a permutation of another string?
   Hide Hint #3  
One way is to sort the string and then compare. But, Is there a better way?
   Hide Hint #4  
If one string is a permutation of another string then they must one common metric. What is that?
   Hide Hint #5  
Both strings must have same character frequencies, if one is permutation of another. Which data structure should be used to store frequencies?
   Hide Hint #6  
What about hash table? An array of size 26?
*/

using System.Collections.Generic;

public class PermutationInString
{
    public bool CheckInclusion(string s1, string s2)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();

        foreach (char ch in s1)
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

        while (windowEnd < s2.Length)
        {
            if (map.ContainsKey(s2[windowEnd]))
            {
                if (map[s2[windowEnd]] == 1)
                {
                    map.Remove(s2[windowEnd]);
                }
                else
                {
                    map[s2[windowEnd]]--;
                }

                windowEnd++;

                if (windowEnd - windowStart == s1.Length)
                {
                    return true;
                }
            }
            else if (windowStart == windowEnd)
            {
                windowStart++;
                windowEnd++;
            }
            else
            {
                if (!map.ContainsKey(s2[windowStart]))
                {
                    map.Add(s2[windowStart], 1);
                }
                else
                {
                    map[s2[windowStart]]++;
                }
                windowStart++;
            }
        }

        return false;
    }
}