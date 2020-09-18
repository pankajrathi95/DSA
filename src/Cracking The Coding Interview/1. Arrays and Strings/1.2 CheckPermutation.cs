/*
Problem Statement : Given two strings, write a method to decide if one is a permutation of the other.
*/
public class CheckPermutation
{
    public static bool CheckIfPermutation(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }

        int[] values = new int[128];
        for (int i = 0; i < s1.Length; i++)
        {
            values[s1[i]]++;
        }

        for (int i = 0; i < s2.Length; i++)
        {
            values[s2[i]]--;
            if (values[s2[i]] == -1)
            {
                return false;
            }
        }

        return true;
    }
}