/*

Given an arbitrary ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.

Each letter in the magazine string can only be used once in your ransom note.

Note:
You may assume that both strings contain only lowercase letters.

canConstruct("a", "b") -> false
canConstruct("aa", "ab") -> false
canConstruct("aa", "aab") -> true

*/

using System.Collections.Generic;

public class RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> mag = new Dictionary<char, int>();
        foreach (var ch in magazine)
        {
            if (mag.ContainsKey(ch))
            {
                mag[ch]++;
            }
            else
            {
                mag.Add(ch, 1);
            }
        }

        foreach (var ch in ransomNote)
        {
            if (!mag.ContainsKey(ch))
            {
                return false;
            }
            else
            {
                if (mag[ch] == 1)
                {
                    mag.Remove(ch);
                }
                else
                {
                    mag[ch]--;
                }
            }
        }

        return true;
    }
}