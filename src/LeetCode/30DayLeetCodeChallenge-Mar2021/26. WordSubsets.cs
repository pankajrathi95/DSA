/*
#916 - https://leetcode.com/problems/word-subsets/

We are given two arrays A and B of words.  Each word is a string of lowercase letters.

Now, say that word b is a subset of word a if every letter in b occurs in a, including multiplicity.  For example, "wrr" is a subset of "warrior", but is not a subset of "world".

Now say a word a from A is universal if for every b in B, b is a subset of a. 

Return a list of all universal words in A.  You can return the words in any order.

 

Example 1:

Input: A = ["amazon","apple","facebook","google","leetcode"], B = ["e","o"]
Output: ["facebook","google","leetcode"]
Example 2:

Input: A = ["amazon","apple","facebook","google","leetcode"], B = ["l","e"]
Output: ["apple","google","leetcode"]
Example 3:

Input: A = ["amazon","apple","facebook","google","leetcode"], B = ["e","oo"]
Output: ["facebook","google"]
Example 4:

Input: A = ["amazon","apple","facebook","google","leetcode"], B = ["lo","eo"]
Output: ["google","leetcode"]
Example 5:

Input: A = ["amazon","apple","facebook","google","leetcode"], B = ["ec","oc","ceo"]
Output: ["facebook","leetcode"]
 

Note:

1 <= A.length, B.length <= 10000
1 <= A[i].length, B[i].length <= 10
A[i] and B[i] consist only of lowercase letters.
All words in A[i] are unique: there isn't i != j with A[i] == A[j].
*/

using System;
using System.Collections.Generic;

public class WordSubsets
{
    public IList<string> Wordsubsets(string[] A, string[] B)
    {
        IList<string> result = new List<string>();
        int[] target = new int[26];
        foreach (var b in B)
        {
            int[] temp = new int[26];
            foreach (var c in b)
            {
                temp[c - 'a']++;
                target[c - 'a'] = Math.Max(target[c - 'a'], temp[c - 'a']);
            }
        }

        foreach (var a in A)
        {
            int[] arr = new int[26];
            foreach (var c in a)
            {
                arr[c - 'a']++;
            }

            if (Subset(arr, target))
            {
                result.Add(a);
            }
        }

        return result;
    }

    private bool Subset(int[] arr, int[] target)
    {
        for (int i = 0; i < 26; i++)
        {
            if (target[i] > arr[i])
            {
                return false;
            }
        }

        return true;
    }
}