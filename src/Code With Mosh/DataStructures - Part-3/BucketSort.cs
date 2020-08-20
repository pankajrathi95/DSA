using System.Collections.Generic;

public class BucketSort
{
    public void Sort(int[] array, int numberOfBuckets)
    {
        List<List<int>> buckets = new List<List<int>>();
        for (int i = 0; i < numberOfBuckets; i++)
        {
            buckets.Add(new List<int>());
        }

        foreach (var item in array)
        {
            buckets[item / numberOfBuckets].Add(item);
        }

        int k = 0;
        foreach (var bucket in buckets)
        {
            bucket.Sort();
            foreach (var item in bucket)
            {
                array[k++] = item;
            }
        }
    }
}