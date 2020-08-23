/*
https://leetcode.com/problems/length-of-last-word/
*/

public class LengthOfLastWord
{
    public int LengthOfTheLastWord(string s)
    {
        string[] words = s.Trim().Split(' ');
        return words[words.Length - 1].Length;
    }
}
