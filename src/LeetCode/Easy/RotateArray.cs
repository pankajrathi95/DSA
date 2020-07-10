/*
https://leetcode.com/problems/rotate-array/submissions/
*/

public class RotateArray
{
    public void Rotate(int[] nums, int k)
    {
        int[] A = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            A[(i + k) % nums.Length] = nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = A[i];
        }
    }
}