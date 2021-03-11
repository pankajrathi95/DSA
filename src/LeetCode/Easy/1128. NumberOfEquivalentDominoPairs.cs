/*
https://leetcode.com/problems/number-of-equivalent-domino-pairs/

Given a list of dominoes, dominoes[i] = [a, b] is equivalent to dominoes[j] = [c, d] if and only if either (a==c and b==d), or (a==d and b==c) - that is, one domino can be rotated to be equal to another domino.

Return the number of pairs (i, j) for which 0 <= i < j < dominoes.length, and dominoes[i] is equivalent to dominoes[j].

 

Example 1:

Input: dominoes = [[1,2],[2,1],[3,4],[5,6]]
Output: 1
 

Constraints:

1 <= dominoes.length <= 40000
1 <= dominoes[i][j] <= 9
*/

using System;
using System.Collections.Generic;

public class NumberOfEquivalentDominoPairs
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        Dictionary<int, int> values = new Dictionary<int, int>();
        int count = 0;
        foreach (var domino in dominoes)
        {
            int small = Math.Min(domino[0], domino[1]);
            int big = Math.Max(domino[0], domino[1]);

            int key = 10 * small + big;
            if (values.ContainsKey(key))
            {
                count += ++values[key];
            }
            else
            {
                values.Add(key, 0);
            }
        }

        return count;
    }
}