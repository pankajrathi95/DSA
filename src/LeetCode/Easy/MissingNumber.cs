/*
https://leetcode.com/problems/missing-number/
*/

public class MissingNumber
{
    public int MissingNumber(int[] nums)
    {
        int[] counter = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            counter[nums[i]] = nums[i];
        }

        for (int i = 1; i < counter.Length; i++)
        {
            if (counter[i] == 0)
            {
                return i;
            }
        }

        return 0;
    }
}