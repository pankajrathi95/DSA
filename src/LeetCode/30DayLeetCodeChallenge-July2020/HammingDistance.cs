/*
The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

Given two integers x and y, calculate the Hamming distance.

Note:
0 ≤ x, y < 231.

Example:

Input: x = 1, y = 4

Output: 2

Explanation:
1   (0 0 0 1)
4   (0 1 0 0)
       ↑   ↑

The above arrows point to positions where the corresponding bits are different.
*/

using System;

public class HammingDistance
{
    public int FindHammingDistance(int x, int y)
    {
        if (x > y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        string xVal = Convert.ToString(x, 2);
        string yVal = Convert.ToString(y, 2);
        int hammingDistance = 0;

        for (int i = 0; i < yVal.Length - xVal.Length; i++)
        {
            if (yVal[i] == '1')
            {
                hammingDistance++;
            }
        }

        for (int i = 0, j = yVal.Length - xVal.Length; i < xVal.Length; i++, j++)
        {
            if (xVal[i] != yVal[j])
            {
                hammingDistance++;
            }
        }

        return hammingDistance;
    }
}