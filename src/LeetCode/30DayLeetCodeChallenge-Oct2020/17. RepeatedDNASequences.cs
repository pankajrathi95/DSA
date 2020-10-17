/*
#187 - https://leetcode.com/problems/repeated-dna-sequences/

All DNA is composed of a series of nucleotides abbreviated as 'A', 'C', 'G', and 'T', for example: "ACGAATTCCG". When studying DNA, it is sometimes useful to identify repeated sequences within the DNA.

Write a function to find all the 10-letter-long sequences (substrings) that occur more than once in a DNA molecule.

 

Example 1:

Input: s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT"
Output: ["AAAAACCCCC","CCCCCAAAAA"]
Example 2:

Input: s = "AAAAAAAAAAAAA"
Output: ["AAAAAAAAAA"]
 

Constraints:

0 <= s.length <= 105
s[i] is 'A', 'C', 'G', or 'T'.
*/

using System.Collections.Generic;

public class RepeatedDNASequences
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {
        IList<string> result = new List<string>();
        Dictionary<string, int> values = new Dictionary<string, int>();
        if (s == null || s.Length < 10)
        {
            return result;
        }

        for (int i = 0; i <= s.Length - 10; i++)
        {
            string subString = s.Substring(i, 10);
            if (!values.ContainsKey(subString))
            {
                values.Add(subString, 1);
            }
            else
            {
                if (values[subString] == 1)
                {
                    result.Add(subString);
                }

                values[subString]++;
            }
        }

        return result;
    }
}