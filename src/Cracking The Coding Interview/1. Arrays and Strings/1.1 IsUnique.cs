/*
Problem Statement:
Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structres?
*/
using System;

public class IsUnique
{
    public static bool IsUniqueOrNot(string s)
    {
        int[] values = new int[128];
        if (s.Length > 128)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (values[s[i]] == 1)
            {
                return false;
            }

            values[s[i]]++;
        }

        return true;
    }
}