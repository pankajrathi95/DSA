/*
https://leetcode.com/problems/valid-palindrome/
*/

public class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        if (s.Length == 1 || s.Length == 0)
        {
            return true;
        }

        int start = 0, end = s.Length - 1;
        while (start < end)
        {
            if (!char.IsLetterOrDigit(s[start]))
            {
                start++;
                continue;
            }
            else if (!char.IsLetterOrDigit(s[end]))
            {
                end--;
                continue;
            }

            if (!s[start++].Equals(s[end--]))
            {
                return false;
            }
        }

        return true;
    }

}