using System.Collections.Generic;

public class PermutationswithDups
{
    public HashSet<string> FindPermutations(string str)
    {
        HashSet<string> permutation = new HashSet<string>();
        if (str.Length == 0)
        {
            permutation.Add("");
            return permutation;
        }

        char ch = str[0];
        string remainder = str.Substring(1);
        HashSet<string> words = FindPermutations(remainder);
        foreach (var word in words)
        {
            for (int i = 0; i <= word.Length; i++)
            {
                string temp = word.Substring(0, i) + ch + word.Substring(i);
                if (!permutation.Contains(temp))
                {
                    permutation.Add(temp);
                }
            }
        }

        return permutation;
    }
}