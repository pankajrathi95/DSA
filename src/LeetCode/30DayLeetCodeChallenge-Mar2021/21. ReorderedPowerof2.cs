/*
#869 - https://leetcode.com/problems/reordered-power-of-2/

Starting with a positive integer N, we reorder the digits in any order (including the original order) such that the leading digit is not zero.

Return true if and only if we can do this in a way such that the resulting number is a power of 2.

 

Example 1:

Input: 1
Output: true
Example 2:

Input: 10
Output: false
Example 3:

Input: 16
Output: true
Example 4:

Input: 24
Output: false
Example 5:

Input: 46
Output: true
 

Note:

1 <= N <= 10^9
*/

using System.Linq;

public class ReorderedPowerof2
{
    public bool ReorderedPowerOf2(int N)
    {
        int[] countN = Count(N);
        int num = 1;
        for (int i = 0; i < 31; i++)
        {
            if (countN.SequenceEqual(Count(num)))
            {
                return true;
            }

            num = num * 2;
        }

        return false;
    }

    private int[] Count(int N)
    {
        int[] arr = new int[10];
        while (N > 0)
        {
            arr[N % 10]++;
            N /= 10;
        }

        return arr;
    }
}