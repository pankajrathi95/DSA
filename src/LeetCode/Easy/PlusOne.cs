/*
https://leetcode.com/problems/plus-one/
*/

using System.Collections.Generic;

public class PlusOne
{
    public int[] AddPlusOne(int[] A)
    {
        int count = A.Length;
        int carry = 0;

        A[count - 1] += 1;
        carry = A[count - 1] / 10;
        A[count - 1] = A[count - 1] % 10;

        for (int i = count - 2; i >= 0; i--)
        {
            if (carry == 1)
            {
                A[i] += 1;
                carry = A[i] / 10;
                A[i] = A[i] % 10;
            }

        }

        List<int> B = new List<int>();
        if (carry == 1)
        {
            B.Add(carry);
        }

        foreach (int i in A)
        {
            B.Add(i);
        }
        return B.ToArray();
    }
}