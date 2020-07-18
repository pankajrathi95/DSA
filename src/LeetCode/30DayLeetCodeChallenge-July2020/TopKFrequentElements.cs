/*
Given a non-empty array of integers, return the k most frequent elements.

Example 1:

Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]
Example 2:

Input: nums = [1], k = 1
Output: [1]
Note:

You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
It's guaranteed that the answer is unique, in other words the set of the top k frequent elements is unique.
You can return the answer in any order.
*/

using System.Collections.Generic;
using System.Linq;

public class TopKFrequentElements
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> values = new Dictionary<int, int>();
        int[] array = new int[k];
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (values.ContainsKey(nums[i]))
            {
                values[nums[i]]++;
            }
            else
            {
                values.Add(nums[i], 1);
            }
        }

        foreach (var kvp in values.OrderByDescending(key => key.Value))
        {
            array[j++] = kvp.Key;
            if (j == k)
            {
                break;
            }
        }

        return array;
    }
}