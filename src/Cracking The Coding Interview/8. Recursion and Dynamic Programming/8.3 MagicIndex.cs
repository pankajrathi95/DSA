using System;

public class MagicIndex
{
    public int FindMagicIndex(int[] arr)
    {
        ret urn FindMagicIndex(arr, 0, arr.Length - 1);
    }

    private int FindMagicIndex(int[] arr, int start, int end)
    {
        if (end < start)
        {
            return -1;
        }

        int mid = (start + end) / 2;
        if (arr[mid] == mid)
        {
            return mid;
        }
        else if (arr[mid] > mid)
        {
            return FindMagicIndex(arr, start, mid - 1);
        }
        else
        {
            return FindMagicIndex(arr, mid + 1, end);
        }
    }
}