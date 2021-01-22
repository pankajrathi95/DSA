/*
#1657 - https://leetcode.com/problems/determine-if-two-strings-are-close/
Two strings are considered close if you can attain one from the other using the following operations:

Operation 1: Swap any two existing characters.
For example, abcde -> aecdb
Operation 2: Transform every occurrence of one existing character into another existing character, and do the same with the other character.
For example, aacabb -> bbcbaa (all a's turn into b's, and all b's turn into a's)
You can use the operations on either string as many times as necessary.

Given two strings, word1 and word2, return true if word1 and word2 are close, and false otherwise.

 

Example 1:

Input: word1 = "abc", word2 = "bca"
Output: true
Explanation: You can attain word2 from word1 in 2 operations.
Apply Operation 1: "abc" -> "acb"
Apply Operation 1: "acb" -> "bca"
Example 2:

Input: word1 = "a", word2 = "aa"
Output: false
Explanation: It is impossible to attain word2 from word1, or vice versa, in any number of operations.
Example 3:

Input: word1 = "cabbba", word2 = "abbccc"
Output: true
Explanation: You can attain word2 from word1 in 3 operations.
Apply Operation 1: "cabbba" -> "caabbb"
Apply Operation 2: "caabbb" -> "baaccc"
Apply Operation 2: "baaccc" -> "abbccc"
Example 4:

Input: word1 = "cabbba", word2 = "aabbss"
Output: false
Explanation: It is impossible to attain word2 from word1, or vice versa, in any amount of operations.
 

Constraints:

1 <= word1.length, word2.length <= 105
word1 and word2 contain only lowercase English letters.
   Hide Hint #1  
Operation 1 allows you to freely reorder the string.
   Hide Hint #2  
Operation 2 allows you to freely reassign the letters' frequencies.
*/

using System;

public class DetermineIfTwoStringsAreClose
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        int[] word1Count = new int[26];
        foreach (var word in word1)
        {
            word1Count[word - 'a']++;
        }

        int[] word2Count = new int[26];
        foreach (var word in word2)
        {
            if (word1Count[word - 'a'] == 0)
            {
                return false;
            }

            word2Count[word - 'a']++;
        }

        Array.Sort(word1Count);
        Array.Sort(word2Count);

        for (int i = 0; i < word1Count.Length; i++)
        {
            if (word1Count[i] != word2Count[i])
            {
                return false;
            }
        }

        return true;
    }
}