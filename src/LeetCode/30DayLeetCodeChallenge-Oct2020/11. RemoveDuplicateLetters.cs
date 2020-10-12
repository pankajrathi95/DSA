/*

*/

using System;
using System.Collections.Generic;
using System.Text;

public class RemoveDuplicateLetters
{
    public string RemoveTheDuplicateLetters(string s)
    {
        int[] count = new int[26];
        HashSet<char> used = new HashSet<char>();
        foreach (var ch in s)
        {
            count[ch - 'a']++;
        }

        Console.WriteLine('c'.CompareTo('b'));
        StringBuilder sb = new StringBuilder();
        sb.Append(s[0]);
        used.Add(s[0]);
        count[s[0] - 'a']--;
        for (int i = 1; i < s.Length; i++)
        {
            var current = s[i];
            if (used.Contains(current))
            {
                count[current - 'a']--;
                continue;
            }

            bool flag = true;
            while (sb.Length != 0)
            {
                char prev = sb[sb.Length - 1];
                if (count[prev - 'a'] > 0 && current.CompareTo(prev) < 0)
                {
                    used.Remove(prev);
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    used.Add(current);
                    sb.Append(current);
                    count[current - 'a']--;
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                used.Add(current);
                sb.Append(current);
                count[current - 'a']--;
            }
        }

        return sb.ToString();
    }
}