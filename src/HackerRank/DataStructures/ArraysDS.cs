/*
https://www.hackerrank.com/challenges/arrays-ds/problem
*/

class ArraysDS
{
    public static int[] reverseArray(int[] a)
    {
        int[] b = new int[a.Length];
        int index = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            b[index++] = a[i];
        }

        return b;
    }
}