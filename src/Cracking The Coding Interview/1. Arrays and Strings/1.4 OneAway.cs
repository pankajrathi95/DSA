
/*
Problem Statement:
There are three types o edits that can be performed on strings: 
insert a character, remove a character, or replace a character. Given two 
Strings, write a function to check if they are one edit(or zero edit) away.

Example:
pale, ple -> true
pales, pale -> true
pale, bale -> true
pale, bake -> false
*/
using System.Collections.Generic;

public class OneAway
{
    public static bool FindIfOneWay(string s1, string s2)
    {
        HashSet<char> values = new HashSet<char>();
        foreach (var ch in s1)
        {
            if (values.Contains(ch))
            {
                values.Remove(ch);
            }
            else
            {
                values.Add(ch);
            }
        }

        foreach (var ch in s2)
        {
            if (values.Contains(ch))
            {
                values.Remove(ch);
            }
            else
            {
                values.Add(ch);
            }
        }

        return values.Count <= 2;
    }
}