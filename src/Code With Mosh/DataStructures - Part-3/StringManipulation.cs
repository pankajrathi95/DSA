using System;
using System.Collections.Generic;
using System.Text;

public class StringManipulation
{
    public int NumberOfVowels(string input)
    {
        if (input == null)
        {
            return 0;
        }

        int count = 0;
        string vowels = "aeiouAEIOU";
        for (int i = 0; i < input.Length; i++)
        {
            if (vowels.Contains(input[i]))
            {
                count++;
            }
        }

        return count;
    }

    public string Reverse(string input)
    {
        StringBuilder s = new StringBuilder(input);
        int i = 0, j = s.Length - 1;
        while (i < j)
        {
            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;

            i++;
            j--;
        }

        return s.ToString();
    }

    public string ReverseWords(string input)
    {
        string[] values = input.Trim().Split(' ');
        StringBuilder sb = new StringBuilder();
        foreach (var value in values)
        {
            sb.Append(Reverse(value) + " ");
        }

        return sb.ToString().Trim();
    }

    public bool AreRotations(string a, string b)
    {
        return (a.Length == b.Length && (a + b).Contains(b));
    }

    public string RemoveDuplicates(String s)
    {
        StringBuilder sb = new StringBuilder();
        HashSet<char> seen = new HashSet<char>();

        foreach (var ch in s)
        {
            if (!seen.Contains(ch))
            {
                seen.Add(ch);
                sb.Append(ch);
            }
        }

        return sb.ToString();
    }

    public char MostRepeatedChar(string s)
    {
        if (s == null || s.Length == 0)
        {
            throw new InvalidProgramException();
        }
        int[] count = new int[256];
        foreach (var ch in s)
        {
            count[ch]++;
        }

        int max = 0;
        char result = ' ';
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] > max)
            {
                max = count[i];
                result = (char)i;
            }
        }

        return result;
    }

    public string Capitalize(string sentence)
    {
        string[] words = sentence.Trim().Split(' ');
        StringBuilder sb = new StringBuilder();
        foreach (var word in words)
        {
            sb.Append(word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ");
        }

        return sb.ToString();
    }

    public bool IsAnagram(string a, string b)
    {
        if (a.Length != b.Length)
        {
            return false;
        }
        Dictionary<char, int> values = new Dictionary<char, int>();
        for (int i = 0; i < a.Length; i++)
        {
            if (!values.ContainsKey(a[i]))
            {
                values.Add(a[i], 1);
            }
            else
            {
                values[a[i]]++;
            }
        }

        for (int i = 0; i < b.Length; i++)
        {
            if (values.ContainsKey(b[i]))
            {
                if (values[b[i]] == 1)
                {
                    values.Remove(b[i]);
                }
                else
                {
                    values[b[i]]--;
                }
            }
            else
            {
                return false;
            }
        }
        return values.Count == 0;
    }

    public bool IsPalindrome(string input)
    {
        int i = 0, j = input.Length - 1;
        while (i < j)
        {
            if (input[i++] != input[j--])
            {
                return false;
            }
        }

        return true;
    }


}