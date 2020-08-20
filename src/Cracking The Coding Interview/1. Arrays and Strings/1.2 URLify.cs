/*
Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end to hold the 
additional characters, and that you are given the "true" length of the string. (Note: If Implementing in Java, please use a character array
so that you can perform ths operation in place.)

Example
Input:  "Mr John Smith    ", 13
Output: "Mr%20John%20Smith"
*/
using System;

public class URLify
{
    public static string Urlify(string s, int trueLength)
    {
        if (s.Length == trueLength)
        {
            return s;
        }

        char[] charArray = s.ToCharArray();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (charArray[trueLength - 1] == ' ')
            {
                charArray[i] = '0';
                charArray[i - 1] = '2';
                charArray[i - 2] = '%';
                i -= 2;
            }
            else
            {
                charArray[i] = charArray[trueLength - 1];
            }

            trueLength--;
        }

        return new String(charArray);
    }
}