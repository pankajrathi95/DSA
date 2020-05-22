/*
Implement strStr().

Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

Example 1:

Input: haystack = "hello", needle = "ll"
Output: 2
Example 2:

Input: haystack = "aaaaa", needle = "bba"
Output: -1
Clarification:

What should we return when needle is an empty string? This is a great question to ask during an interview.

For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().
*/

public class ImplementStrStr
{
    public int StrStr(string haystack, string needle)
    {
        if (needle == "")
        {
            return 0;
        }

        int start = 0;

        for (int i = 0; i < haystack.Length; i++)
        {
            start = 0;
            int j = i;
            while (start < needle.Length && j < haystack.Length)
            {
                if (needle[start] != haystack[j])
                {
                    break;
                }

                start++;
                j++;
            }

            if (start == needle.Length)
            {
                return i;
            }
        }

        return -1;
    }

    public int StrStr_2(string haystack, string needle)
    {
        if (haystack == null || needle == null)
            return 0;

        if (needle.Length == 0)
            return 0;
        if (haystack.Contains(needle))
        {
            return haystack.IndexOf(needle);
        }
        else
            return -1;
    }
}