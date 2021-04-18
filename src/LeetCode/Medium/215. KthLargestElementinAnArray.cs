/*
https://leetcode.com/problems/kth-largest-element-in-an-array/

Find the kth largest element in an unsorted array. Note that it is the kth largest element in the sorted order, not the kth distinct element.

Example 1:

Input: [3,2,1,5,6,4] and k = 2
Output: 5
Example 2:

Input: [3,2,3,1,2,4,5,5,6] and k = 4
Output: 4
Note:
You may assume k is always valid, 1 ≤ k ≤ array's length.
*/

using System;
using System.Collections.Generic;

public class KthLargestElementinAnArray
{
    //Sorting of array.
    public int FindKthLargest(int[] nums, int k)
    {
        if (nums.Length == 0)
        {
            return -1;
        }

        Array.Sort(nums);
        return nums[nums.Length - k];
    }

    //Using MaxHeap
    public class MaxHeap
    {
        List<int> max;
        public int Count
        {
            get { return max.Count; }
            set { }
        }

        public int Top()
        {
            return max[0];
        }

        public MaxHeap()
        {
            max = new List<int>();
        }

        public void Insert(int num)
        {
            max.Add(num);
            BubbleUp();
        }

        public int Remove()
        {
            int val = max[0];
            max[0] = max[max.Count - 1];
            max.RemoveAt(max.Count - 1);
            BubbleDown();
            return val;
        }

        private void BubbleUp()
        {
            int index = max.Count - 1;
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (max[index] > max[parent])
                {
                    Swap(index, parent);
                    index = parent;
                }
                else
                {
                    return;
                }
            }
        }

        private void BubbleDown()
        {
            int index = 0;
            while (index < max.Count)
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;

                if (leftChild >= max.Count && rightChild >= max.Count)
                {
                    return;
                }

                int largerChild = LargerChild(index, leftChild, rightChild);
                if (max[largerChild] > max[index])
                {
                    Swap(index, largerChild);
                    index = largerChild;
                }
                else
                {
                    return;
                }
            }
        }

        private int LargerChild(int index, int leftChild, int rightChild)
        {
            if (leftChild >= max.Count)
            {
                return rightChild;
            }

            if (rightChild >= max.Count)
            {
                return leftChild;
            }

            return max[leftChild] > max[rightChild] ? leftChild : rightChild;
        }

        private void Swap(int first, int second)
        {
            int temp = max[first];
            max[first] = max[second];
            max[second] = temp;
        }
    }

    public int FindKthLargest_Heap(int[] nums, int k)
    {
        MaxHeap maxHeap = new MaxHeap();

        foreach (var num in nums)
        {
            maxHeap.Insert(num);
        }

        while (k > 1)
        {
            maxHeap.Remove();
            k--;
        }

        return maxHeap.Top();
    }
}