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

    public List<string> FindPer_Rec(string str)
    {
        List<string> permutation = new List<string>();
        if (str.Length == 0)
        {
            permutation.Add("");
            return permutation;
        }

        char ch = str[0];
        string remainder = str.Substring(1);
        List<string> words = FindPer_Rec(remainder);
        foreach (var word in words)
        {
            for (int k = 0; k < word.Length + 1; k++)
            {
                permutation.Add(word.Substring(0, k) + ch + word.Substring(k));
            }
        }

        return permutation;
    }
}