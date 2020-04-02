/*
Given a non-empty array of integers, every element appears twice except for one. Find that single one.

Note:

Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory? 
SOLUTION: This works on the principle of Bitwise XOR as XOR of two same numbers is zero and the XOR of number and zero is the number itself.
*/


public class SingleNumber
{
    public int IsSingleNumber(int[] nums)
    {
        int result = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            result = result ^ nums[i];
        }

        return result;
    }
}