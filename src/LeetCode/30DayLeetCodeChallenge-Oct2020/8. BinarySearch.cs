/*

*/

public class BinarySearch
{
    //Recursive solution
    public int Search(int[] nums, int target)
    {
        return Search(nums, target, 0, nums.Length - 1);
    }

    private int Search(int[] nums, int target, int start, int end)
    {
        if (start > end)
        {
            return -1;
        }

        int mid = (start + end) / 2;
        if (nums[mid] > target)
        {
            return BinarySearch(nums, target, start, mid - 1);
        }
        else if (nums[mid] < target)
        {
            return BinarySearch(nums, target, mid + 1, end);
        }
        else
        {
            return mid;
        }
    }

    //Iterative Approach
    public int Search_Binary(int[] nums, int target)
    {
        int start = 0, end = nums.Length - 1;
        while (start <= end)
        {
            int mid = (start + end) / 2;
            if (nums[mid] > target)
            {
                end = mid - 1;
            }
            else if (nums[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                return mid;
            }
        }

        return -1;
    }
}