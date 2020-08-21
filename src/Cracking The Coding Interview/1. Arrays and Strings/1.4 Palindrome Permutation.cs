/*
Problem Statement:
Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome. A palindrome is a word or
phrase that is the same forwards and backwards. A permutation is a rearrangement of letters. The palindrome does not need to be limited
to just dictionary words.

Example:
Input: Tach Coa
Output: True (Permutations: "taco cat", "atco cta", etc.)
*/
public class PalindromePermutation
{
    public static bool CheckPalindrome(string s)
    {
        int[] values = new int[(int)'z' - (int)'a' + 1];
        int countOdds = 0;
        foreach (var ch in s)
        {
            if (char.IsLetter(ch))
            {
                values[ch - 'a']++;
                if (values[ch - 'a'] % 2 == 1)
                {
                    countOdds++;
                }
                else
                {
                    countOdds--;
                }
            }
        }

        return countOdds <= 1;
    }
}