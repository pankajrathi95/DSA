/*
https://leetcode.com/problems/factorial-trailing-zeroes/
*/

public class FactorialTrailingZeroes
{
    public int TrailingZeroes(int n)
    {
        int temp = n, count = 0;
        while (temp != 0)
        {
            int val = temp / 5;
            count += val;
            if (val >= 5)
            {
                temp = val;
            }
            else
            {
                return count;
            }
        }

        return count;
    }
}