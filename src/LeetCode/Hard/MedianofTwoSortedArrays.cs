/*
https://leetcode.com/problems/median-of-two-sorted-arrays/
*/

public class MedianofTwoSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int i = 0, j = 0, k = 0;
        int[] arr = new int[nums1.Length + nums2.Length];
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
            {
                arr[k++] = nums1[i++];
            }
            else
            {
                arr[k++] = nums2[j++];
            }
        }

        while (i < nums1.Length)
        {
            arr[k++] = nums1[i++];
        }

        while (j < nums2.Length)
        {
            arr[k++] = nums2[j++];
        }

        return arr.Length % 2 == 0 ? (arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2.0 : arr[arr.Length / 2];
    }
}