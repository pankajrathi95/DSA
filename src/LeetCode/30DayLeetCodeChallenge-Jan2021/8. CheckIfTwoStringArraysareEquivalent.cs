/*
#1662 - https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/

Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.

A string is represented by an array if the array elements concatenated in order forms the string.

Example 1:

Input: word1 = ["ab", "c"], word2 = ["a", "bc"]
Output: true
Explanation:
word1 represents string "ab" + "c" -> "abc"
word2 represents string "a" + "bc" -> "abc"
The strings are the same, so return true.
Example 2:

Input: word1 = ["a", "cb"], word2 = ["ab", "c"]
Output: false
Example 3:

Input: word1  = ["abc", "d", "defg"], word2 = ["abcddefg"]
Output: true
 

Constraints:

1 <= word1.length, word2.length <= 103
1 <= word1[i].length, word2[i].length <= 103
1 <= sum(word1[i].length), sum(word2[i].length) <= 103
word1[i] and word2[i] consist of lowercase letters.
   Hide Hint #1  
Concatenate all strings in the first array into a single string in the given order, the same for the second array.
   Hide Hint #2  
Both arrays represent the same string if and only if the generated strings are the same.
*/

public class CheckIfTwoStringArraysareEquivalent
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string result1 = string.Empty;
        foreach (var word in word1)
        {
            result1 += word;
        }

        string result2 = string.Empty;
        foreach (var word in word2)
        {
            result2 += word;
        }

        return result1.Equals(result2);
    }
}