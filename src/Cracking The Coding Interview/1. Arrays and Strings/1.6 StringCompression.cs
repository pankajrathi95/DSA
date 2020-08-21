/*
Problem Statement:
Implement a method to perform basic string compression using the counts of repeated characetrs. For example, the string aabcccccaaa would
become a2b1c5a3. If the "compressed" string would not become smaller than the original string, your method should return the oriinal string.
you can assume the string has only uppercase ond lowercase letters(a-z).
*/
using System.Text;

public class StringCompression
{
    public static string CompressString(string s)
    {
        StringBuilder sb = new StringBuilder();
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            count++;
            if (i + 1 >= s.Length || s[i] != s[i + 1])
            {
                sb.Append(s[i] + "" + count);
                count = 0;
            }
        }

        return sb.ToString().Length < s.Length ? sb.ToString() : s;
    }
}