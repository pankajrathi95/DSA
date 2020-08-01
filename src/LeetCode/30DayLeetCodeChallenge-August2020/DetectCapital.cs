/*
Given a word, you need to judge whether the usage of capitals in it is right or not.

We define the usage of capitals in a word to be right when one of the following cases holds:

All letters in this word are capitals, like "USA".
All letters in this word are not capitals, like "leetcode".
Only the first letter in this word is capital, like "Google".
Otherwise, we define that this word doesn't use capitals in a right way.
 

Example 1:

Input: "USA"
Output: True
 

Example 2:

Input: "FlaG"
Output: False
 

Note: The input will be a non-empty word consisting of uppercase and lowercase latin letters.
*/

public class DetectCapital
{
    public bool DetectCapitalUse(string word)
    {
        if (word.Length == 0)
        {
            return true;
        }

        int[] array = new int[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            array[i] = word[i] - 0;
        }

        if (array[0] >= 65 && array[0] <= 90)
        {
            if (array.Length == 1)
            {
                return true;
            }

            if (array[1] >= 65 && array[1] <= 90)
            {
                for (int i = 2; i < array.Length; i++)
                {
                    if (!(array[i] >= 65 && array[i] <= 90))
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 2; i < array.Length; i++)
                {
                    if (array[i] >= 65 && array[i] <= 90)
                    {
                        return false;
                    }
                }
            }
        }
        else
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= 65 && array[i] <= 90)
                {
                    return false;
                }
            }
        }

        return true;
    }
}