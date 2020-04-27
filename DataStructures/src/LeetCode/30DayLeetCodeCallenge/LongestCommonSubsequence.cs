/*
Given two strings text1 and text2, return the length of their longest common subsequence.
A subsequence of a string is a new string generated from the original string with some characters(can be none) deleted without changing the relative order of the remaining characters. (eg, "ace" is a subsequence of "abcde" while "aec" is not). A common subsequence of two strings is a subsequence that is common to both strings.

If there is no common subsequence, return 0.

Example 1:
Input: text1 = "abcde", text2 = "ace" 
Output: 3  
Explanation: The longest common subsequence is "ace" and its length is 3.

Example 2:
Input: text1 = "abc", text2 = "abc"
Output: 3
Explanation: The longest common subsequence is "abc" and its length is 3.

Example 3:
Input: text1 = "abc", text2 = "def"
Output: 0
Explanation: There is no such common subsequence, so the result is 0.

Constraints:
1 <= text1.length <= 1000
1 <= text2.length <= 1000
The input strings consist of lowercase English characters only.
   Hide Hint #1  
Try dynamic programming. DP[i][j] represents the longest common subsequence of text1[0 ... i] & text2[0 ... j].
   Hide Hint #2  
DP[i][j] = DP[i - 1][j - 1] + 1 , if text1[i] == text2[j] DP[i][j] = max(DP[i - 1][j], DP[i][j - 1]) , otherwise
*/

https://www.youtube.com/watch?v=NnD96abizww

//Recursive solution:

using System;

class Solution
{

    public int longestCommonSubsequence(String text1, String text2, int m, int n)
    {
        if (m == 0 || n == 0)
            return 0;

        if (text1.charAt(m - 1) == text2.charAt(n - 1))
            return longestCommonSubsequence(text1, text2, m - 1, n - 1) + 1;

        return Math.max(longestCommonSubsequence(text1, text2, m - 1, n), longestCommonSubsequence(text1, text2, m, n - 1));

    }
    public int longestCommonSubsequence(String text1, String text2)
    {
        return longestCommonSubsequence(text1, text2, text1.length(), text2.length());
    }
}


//Dynamic programming solution:

class LongestCommonSubsequence
{
    public int FindLongestCommonSubsequence(string text1, string text2)
    {
        int m = text1.Length;
        int n = text2.Length;
        if (m == 0 || n == 0)
        {
            return 0;
        }

        int[][] dp = new int[m + 1][];
        for (int i = 0; i <= m; i++)
        {
            dp[i] = new int[n + 1];
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    dp[i][j] = 0;
                else if (text1[i - 1] == text2[j - 1])
                {
                    dp[i][j] = dp[i - 1][j - 1] + 1;
                }
                else
                {
                    dp[i][j] = Math.Max(dp[i - 1][j], dp[i][j - 1]);
                }
            }
        }
        return dp[m][n];
    }
}