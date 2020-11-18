/*
https://leetcode.com/problems/break-a-palindrome/
Given a palindromic string palindrome, replace exactly one character by any lowercase English letter so that the string becomes the lexicographically smallest possible string that isn't a palindrome.

After doing so, return the final string.  If there is no way to do so, return the empty string.

 

Example 1:

Input: palindrome = "abccba"
Output: "aaccba"
Example 2:

Input: palindrome = "a"
Output: ""
 

Constraints:

1 <= palindrome.length <= 1000
palindrome consists of only lowercase English letters.
*/

using System.Text;

public class BreakaPalindrome
{
    public string BreakPalindrome(string palindrome)
    {
        if (palindrome.Length == 1)
        {
            return "";
        }

        StringBuilder sb = new StringBuilder(palindrome);
        for (int i = 0; i < palindrome.Length; i++)
        {
            if (!palindrome[i].Equals('a'))
            {
                //Replace any non-a character with a.
                sb[i] = 'a';
                //Now check the newly formed string is palindrome or not if it is then change back what you did above and continue.
                if (IsPalindrome(sb.ToString()))
                {
                    sb[i] = palindrome[i];
                    continue;
                }

                break;
            }
        }

        //If we didn't find any replacement and both strings are equal then just change the last character to b.
        if (sb.ToString().Equals(palindrome))
        {
            sb[sb.Length - 1] = 'b';
        }

        return sb.ToString();
    }

    //Function to check if a string is palindrome or not.
    private bool IsPalindrome(string str)
    {
        int start = 0, end = str.Length - 1;
        while (start <= end)
        {
            if (!str[start].Equals(str[end]))
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }
}