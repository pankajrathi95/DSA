/*
https://www.hackerrank.com/challenges/picking-numbers/problem
*/

using System;
using System.Collections.Generic;

class PickingNumbers
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int PickingTheNumbers(List<int> a)
    {
        int[] count = new int[100];
        for (int i = 0; i < a.Count; i++)
        {
            count[a[i]]++;
        }

        int max = 0;
        for (int i = 0; i < 99; i++)
        {
            max = Math.Max(max, count[i] + count[i + 1]);
        }

        return max;
    }

}