/*
#1446 - https://leetcode.com/problems/consecutive-characters/
Given a string s, the power of the string is the maximum length of a non-empty substring that contains only one unique character.

Return the power of the string.

 

Example 1:

Input: s = "leetcode"
Output: 2
Explanation: The substring "ee" is of length 2 with the character 'e' only.
Example 2:

Input: s = "abbcccddddeeeeedcba"
Output: 5
Explanation: The substring "eeeee" is of length 5 with the character 'e' only.
Example 3:

Input: s = "triplepillooooow"
Output: 5
Example 4:

Input: s = "hooraaaaaaaaaaay"
Output: 11
Example 5:

Input: s = "tourist"
Output: 1
 

Constraints:

1 <= s.length <= 500
s contains only lowercase English letters.
   Hide Hint #1  
Keep an array power where power[i] is the maximum power of the i-th character.
   Hide Hint #2  
The answer is max(power[i]).
*/

using System;

public class ConsecutiveCharacters
{
    public int MaxPower(string s)
    {
        if (s.Length == 1)
        {
            return 1;
        }

        int max = 1;
        int[] power = new int[s.Length];
        power[0] = 1;
        for (int i = 1; i < s.Length; i++)
        {
            if (!s[i].Equals(s[i - 1]))
            {
                power[i] = 1;
            }
            else
            {
                power[i] = power[i - 1] + 1;
                max = Math.Max(max, power[i]);
            }
        }

        return max;
    }
}