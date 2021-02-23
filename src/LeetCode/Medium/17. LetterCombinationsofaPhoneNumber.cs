/*
https://leetcode.com/problems/letter-combinations-of-a-phone-number/
Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.



 

Example 1:

Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
Example 2:

Input: digits = ""
Output: []
Example 3:

Input: digits = "2"
Output: ["a","b","c"]
 

Constraints:

0 <= digits.length <= 4
digits[i] is a digit in the range ['2', '9']
*/

using System.Collections.Generic;

public class LetterCombinationsofaPhoneNumber
{
    public IList<string> LetterCombinations(string digits)
    {
        Dictionary<char, IList<char>> map = new Dictionary<char, IList<char>>();
        map.Add('2', new List<char>() { 'a', 'b', 'c' });
        map.Add('3', new List<char>() { 'd', 'e', 'f' });
        map.Add('4', new List<char>() { 'g', 'h', 'i' });
        map.Add('5', new List<char>() { 'j', 'k', 'l' });
        map.Add('6', new List<char>() { 'm', 'n', 'o' });
        map.Add('7', new List<char>() { 'p', 'q', 'r', 's' });
        map.Add('8', new List<char>() { 't', 'u', 'v' });
        map.Add('9', new List<char>() { 'w', 'x', 'y', 'z' });

        IList<string> result = new List<string>();
        if (digits.Length == 0)
            return result;

        BackTrack(result, 0, digits.Length, map, "", digits);
        return result;
    }

    private void BackTrack(IList<string> result, int i, int n, Dictionary<char, IList<char>> map, string res, string digits)
    {
        if (i == n)
        {
            result.Add(res);
            return;
        }

        foreach (var item in map[digits[i]])
        {
            res += item + "";
            BackTrack(result, i + 1, n, map, res, digits);
            res = res.Remove(res.Length - 1);
        }
    }
}