using System;
using System.Collections.Generic;

class ContiguousArray
{
    public int FindMaxLength(int[] nums)
    {
        Dictionary<int, int> hm = new Dictionary<int, int>();
        hm.Add(0, -1);
        int count = 0, max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            count = count + (nums[i] == 1 ? 1 : -1);
            if (hm.ContainsKey(count))
            {
                max = Math.Max(max, i - hm[count]);
            }
            else
            {
                hm.Add(count, i);
            }
        }
        return max;
    }
}