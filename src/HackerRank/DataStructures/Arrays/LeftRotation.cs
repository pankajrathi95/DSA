/*
https://www.hackerrank.com/challenges/array-left-rotation
*/

using System;

public class LeftRotation
{
    public void Rotation(int n, int d, int[] a)
    {
        d = d % a.Length;
        int[] temp = new int[a.Length];
        Array.Copy(a, 0, temp, 0, a.Length);
        int count = d;
        for (int i = 0; i < a.Length - d; i++)
        {
            a[i] = temp[count++];
            Console.Write(a[i] + " ");
        }
        count = 0;
        for (int i = a.Length - d; i < a.Length; i++)
        {
            a[i] = temp[count++];
            Console.Write(a[i] + " ");
        }
    }
}