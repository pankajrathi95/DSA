/*
https://leetcode.com/problems/count-primes/submissions/
*/

public class CountPrimes
{
    public int CountThePrimes(int n)
    {
        bool[] primes = new bool[n];
        for (int i = 0; i < n; i++)
        {
            primes[i] = true;
        }

        for (int i = 2; i * i < primes.Length; i++)
        {
            if (primes[i])
            {
                for (int j = i; j * i < primes.Length; j++)
                {
                    primes[i * j] = false;
                }
            }
        }

        int count = 0;
        for (int i = 2; i < primes.Length; i++)
        {
            if (primes[i])
            {
                count++;
            }
        }

        return count;
    }
}