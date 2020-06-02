/*
https://www.hackerrank.com/challenges/sparse-arrays/problem
*/
using System;
using System.Collections.Generic;

public class SparseArrays
{
    static int[] matchingStrings(string[] strings, string[] queries)
    {
        Dictionary<string, int> values = new Dictionary<string, int>();
        int[] result = new int[queries.Length];
        foreach (var str in strings)
        {
            if (values.ContainsKey(str))
            {
                values[str]++;
            }
            else
            {
                values.Add(str, 1);
            }
        }

        for (int i = 0; i < queries.Length; i++)
        {
            if (values.ContainsKey(queries[i]))
            {
                result[i] = values[queries[i]];
            }
            else
            {
                result[i] = 0;
            }
        }

        return result;
    }
}