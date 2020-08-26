
/*
Problem Statement:
Assume you have a method isSubstring which checks if one word is a substring of another. Given two strings, s1 and s2, 
write code to check if s2 is a rotation of s1 using only one call to isSubstring(e.g., "waterbottle" is a rotation of "erbottlewat").
*/

using System;

public class StringRotation
{
    public static bool StringRotate(string s1, string s2)
    {
        if (s1.Length == s2.Length && s1.Length > 0)
        {
            return IsSubString((s1 + s2), s2);
        }

        return false;
    }

    private static bool IsSubString(string v, string s2)
    {
        return v.Contains(s2);
    }
}