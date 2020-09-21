using System.Collections.Generic;

public class PermutationwithoutDups
{
    //Interative approach
    public List<string> FindPermutation(string str)
    {
        List<string> result = new List<string>();
        result.Add(str.Substring(0, 2));
        result.Add(str[1].ToString() + str[0]);

        for (int i = 2; i < str.Length; i++)
        {
            char ch = str[i];
            List<string> newWords = new List<string>();
            for (int j = 0; j < result.Count; j++)
            {
                string word = result[j];
                for (int k = 0; k < word.Length + 1; k++)
                {
                    newWords.Add(word.Substring(0, k) + ch + word.Substring(k));
                }
            }

            result = newWords;
        }

        return result;
    }
}