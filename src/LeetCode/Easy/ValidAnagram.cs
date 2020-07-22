/*
https://leetcode.com/problems/valid-anagram/
*/

using System;

public class ValidAnagram
{
    //brute force solution
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        char[] sArray = s.ToCharArray();
        Array.Sort(sArray);
        string newS = new String(sArray);

        char[] tArray = t.ToCharArray();
        Array.Sort(tArray);
        string newT = new String(tArray);

        return newS.Equals(newT);
    }

    //optimized solution
    public bool IsAnagramOrNOt(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] counter = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            counter[s[i] - 'a']++;
            counter[t[i] - 'a']--;
        }

        foreach (var count in counter)
        {
            if (count != 0)
            {
                return false;
            }
        }

        return true;
    }
}