/*
#821 - https://leetcode.com/problems/shortest-distance-to-a-character/
Given a string s and a character c that occurs in s, return an array of integers answer where answer.length == s.length and answer[i] is the shortest distance from s[i] to the character c in s.

 

Example 1:

Input: s = "loveleetcode", c = "e"
Output: [3,2,1,0,1,0,0,1,2,2,1,0]
Example 2:

Input: s = "aaab", c = "b"
Output: [3,2,1,0]
 

Constraints:

1 <= s.length <= 104
s[i] and c are lowercase English letters.
c occurs at least once in s.
*/

using System;
using System.Collections.Generic;

public class ShortestDistancetoaCharacter
{
    /**
    1. Basically the idea is to store all the occurrences of c in s in a LinkedList
    2. remove the first element from linkedlist and store in variable say first.
    3. also store the first element in variable called second.
    4. Now compare first and second values with i. At any point if we get second is giving mininum distance then make first = second and remove the first element from linkedlist
    **/
    public int[] ShortestToChar(string s, char c)
    {
        int[] result = new int[s.Length];
        LinkedList<int> mins = new LinkedList<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == c)
            {
                mins.AddLast(i);
            }
        }

        int first = mins.First.Value;
        mins.RemoveFirst();
        for (int i = 0; i < s.Length; i++)
        {
            int second = 0;
            if (mins.Count != 0)
            {
                second = mins.First.Value;
            }

            if (second == 0)
            {
                result[i] = Math.Abs(first - i);
                continue;
            }

            if (second != 0 && (Math.Abs(second - i) < Math.Abs(first - i)))
            {
                first = second;
                mins.RemoveFirst();
            }

            result[i] = Math.Abs(first - i);
        }

        return result;
    }
}