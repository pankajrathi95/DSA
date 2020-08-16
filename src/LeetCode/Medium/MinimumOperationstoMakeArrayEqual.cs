/*
https://leetcode.com/problems/minimum-operations-to-make-array-equal/
*/

public class MinimumOperationstoMakeArrayEqual
{
    public int MinOperations(int n)
    {
        int mid = 0;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = 2 * i + 1;
        }

        if (n % 2 == 0)
        {
            mid = (arr[n / 2] + arr[n / 2 - 1]) / 2;
        }
        else
        {
            mid = arr[n / 2];
        }

        int operations = 0;
        for (int i = 0; i < mid / 2; i++)
        {
            operations += mid - arr[i];
        }

        return operations;
    }
}