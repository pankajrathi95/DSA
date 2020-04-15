public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];

        left[0] = 1;
        right[right.Length - 1] = 1;

        for (int i = 0; i < left.Length - 1; i++)
        {
            left[i + 1] = left[i] * nums[i];
        }

        for (int i = right.Length - 1; i > 0; i--)
        {
            right[i - 1] = right[i] * nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = left[i] * right[i];
        }

        return nums;
    }
}