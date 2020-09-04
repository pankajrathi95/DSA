/*
A string S of lowercase English letters is given. We want to partition this string into as many parts as possible so that each letter appears in at most one part, and return a list of integers representing the size of these parts.

 

Example 1:

Input: S = "ababcbacadefegdehijhklij"
Output: [9,7,8]
Explanation:
The partition is "ababcbaca", "defegde", "hijhklij".
This is a partition so that each letter appears in at most one part.
A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits S into less parts.
 

Note:

S will have length in range [1, 500].
S will consist of lowercase English letters ('a' to 'z') only.
*/

using System;
using System.Collections.Generic;

public class PartitionLabels
{
    public IList<int> PartitionTheLabels(string S)
    {
        IList<int> result = new List<int>();
        int max = 0;
        for (int i = 0; i < S.Length; i++)
        {
            char ch = S[i];
            int lastIndex = S.LastIndexOf(ch);
            max = Math.Max(max, lastIndex);
            if (max == i)
            {
                result.Add(lastIndex + 1);
            }
        }

        for (int i = result.Count - 1; i > 0; i--)
        {
            result[i] -= result[i - 1];
        }
        return result;
    }
}