/*
https://leetcode.com/problems/merge-sorted-array/submissions/
*/

public class MergeSortedArray
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int first = m - 1, second = n - 1;
        bool flag = false;
        for (int i = m + n - 1; i >= 0; i--)
        {
            if (second < 0)
            {
                break;
            }

            if (first < 0)
            {
                flag = true;
                break;
            }

            if (nums1[first] < nums2[second])
            {
                nums1[i] = nums2[second];
                second--;
            }
            else
            {
                nums1[i] = nums1[first];
                first--;
            }
        }

        if (flag)
        {
            for (int i = second; i >= 0; i--)
            {
                if (second < 0)
                {
                    break;
                }

                nums1[i] = nums2[second];
                second--;
            }
        }
    }
}