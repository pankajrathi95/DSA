/*
https://leetcode.com/problems/shuffle-an-array/
*/

using System;

public class ShuffleAnArray
{
    int[] values;
    int[] reset;
    public ShuffleAnArray(int[] nums)
    {
        reset = new int[nums.Length];
        Array.Copy(nums, reset, nums.Length);
        values = nums;
    }

    /** Resets the array to its original configuration and return it. */
    public int[] Reset()
    {
        return reset;
    }

    /** Returns a random shuffling of the array. */
    public int[] Shuffle()
    {
        for (int i = values.Length; i > 0; i--)
        {
            Random rand = new Random();
            int randomIndex = rand.Next() % i;
            int temp = values[i - 1];
            values[i - 1] = values[randomIndex];
            values[randomIndex] = temp;
        }

        return values;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */