/*
Given a string, sort it in decreasing order based on the frequency of characters.

Example 1:

Input:
"tree"

Output:
"eert"

Explanation:
'e' appears twice while 'r' and 't' both appear once.
So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
Example 2:

Input:
"cccaaa"

Output:
"cccaaa"

Explanation:
Both 'c' and 'a' appear three times, so "aaaccc" is also a valid answer.
Note that "cacaca" is incorrect, as the same characters must be together.
Example 3:

Input:
"Aabb"

Output:
"bbAa"

Explanation:
"bbaA" is also a valid answer, but "Aabb" is incorrect.
Note that 'A' and 'a' are treated as two different characters.
*/

using System.Collections.Generic;
using System.Text;

public class SortCharactersByFrequency
{
    public string FrequencySort(string s)
    {
        Dictionary<char, int> values = new Dictionary<char, int>();
        if (s == null || s.Length == 0 || s.Length == 1)
        {
            return s;
        }

        foreach (char ch in s)
        {
            if (values.ContainsKey(ch))
            {
                values[ch]++;
            }
            else
            {
                values.Add(ch, 1);
            }
        }

        StringBuilder str = new StringBuilder();
        while (values.Count != 0)
        {
            int max = 0;
            KeyValuePair<char, int> newKvp = new KeyValuePair<char, int>();

            foreach (var kvp in values)
            {
                if (max < kvp.Value)
                {
                    max = kvp.Value;
                    newKvp = kvp;
                }
            }

            for (int i = 0; i < max; i++)
            {
                str.Append(newKvp.Key);
            }

            values.Remove(newKvp.Key);
            max = 0;

        }

        return str.ToString();
    }
}