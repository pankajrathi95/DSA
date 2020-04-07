/*
Given an integer array arr, count element x such that x + 1 is also in arr.
If there're duplicates in arr, count them seperately.

Example 1:

Input: arr = [1,2,3]
Output: 2
Explanation: 1 and 2 are counted cause 2 and 3 are in arr.
Example 2:

Input: arr = [1,1,3,3,5,5,7,7]
Output: 0
Explanation: No numbers are counted, cause there's no 2, 4, 6, or 8 in arr.
Example 3:

Input: arr = [1,3,2,3,5,0]
Output: 3
Explanation: 0, 1 and 2 are counted cause 1, 2 and 3 are in arr.
Example 4:

Input: arr = [1,1,2,2]
Output: 2
Explanation: Two 1s are counted cause 2 is in arr.
 

Constraints:

1 <= arr.length <= 1000
0 <= arr[i] <= 1000

*/
using System;
using System.Collections.Generic;

public class CountingElements
{
    public int CountElements(int[] arr)
    {
        Array.Sort(arr);
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        foreach (int i in arr)
        {
            if (dictionary.ContainsKey(i))
            {
                dictionary[i]++;
            }
            else
            {
                dictionary.Add(i, 1);
            }
        }

        KeyValuePair<int, int> previousValue = new KeyValuePair<int, int>(arr[0], dictionary[arr[0]]);
        int count = 0;
        foreach (KeyValuePair<int, int> kvp in dictionary)
        {
            if (kvp.Key == previousValue.Key)
            {
                continue;
            }

            if (previousValue.Key + 1 == kvp.Key)
            {
                count += previousValue.Value;
            }

            previousValue = kvp;
        }
        return count;
    }
}