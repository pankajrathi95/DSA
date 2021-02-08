/*
#295 - https://leetcode.com/problems/find-median-from-data-stream/

Median is the middle value in an ordered integer list. If the size of the list is even, there is no middle value. So the median is the mean of the two middle value.

For example,
[2,3,4], the median is 3

[2,3], the median is (2 + 3) / 2 = 2.5

Design a data structure that supports the following two operations:

void addNum(int num) - Add a integer number from the data stream to the data structure.
double findMedian() - Return the median of all elements so far.
 

Example:

addNum(1)
addNum(2)
findMedian() -> 1.5
addNum(3) 
findMedian() -> 2
 

Follow up:

If all integer numbers from the stream are between 0 and 100, how would you optimize it?
If 99% of all integer numbers from the stream are between 0 and 100, how would you optimize it?
*/


using System.Collections.Generic;

public class MedianFinder
{
    MinHeap minHeap;
    MaxHeap maxHeap;

    public class MinHeap
    {
        List<int> min;
        public int Count
        {
            get { return min.Count; }
            set { }
        }

        public int Top()
        {
            return min[0];
        }

        public MinHeap()
        {
            min = new List<int>();
        }


        public void Insert(int num)
        {
            min.Add(num);
            BubbleUp();
        }

        public int Remove()
        {
            int val = min[0];
            min[0] = min[min.Count - 1];
            min.RemoveAt(min.Count - 1);
            BubbleDown();
            return val;
        }

        private void BubbleUp()
        {
            int index = min.Count - 1;
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (min[index] < min[parent])
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
            while (index < min.Count)
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;

                if (leftChild >= min.Count && rightChild >= min.Count)
                {
                    return;
                }

                int smallerChild = SmallerChild(index, leftChild, rightChild);
                if (min[smallerChild] < min[index])
                {
                    Swap(index, smallerChild);
                    index = smallerChild;
                }
                else
                {
                    return;
                }
            }
        }

        private int SmallerChild(int index, int leftChild, int rightChild)
        {
            if (leftChild >= min.Count)
            {
                return rightChild;
            }

            if (rightChild >= min.Count)
            {
                return leftChild;
            }

            return min[leftChild] < min[rightChild] ? leftChild : rightChild;
        }
        private void Swap(int first, int second)
        {
            int temp = min[first];
            min[first] = min[second];
            min[second] = temp;
        }
    }

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
    /** initialize your data structure here. */
    public MedianFinder()
    {
        minHeap = new MinHeap();
        maxHeap = new MaxHeap();
    }

    public void AddNum(int num)
    {
        if (maxHeap.Count == 0 || maxHeap.Top() > num)
        {
            maxHeap.Insert(num);
        }
        else
        {
            minHeap.Insert(num);
        }

        if (maxHeap.Count > minHeap.Count + 1)
        {
            minHeap.Insert(maxHeap.Remove());
        }
        else if (minHeap.Count > maxHeap.Count + 1)
        {
            maxHeap.Insert(minHeap.Remove());
        }
    }

    public double FindMedian()
    {
        if (maxHeap.Count == minHeap.Count)
        {
            return (double)((minHeap.Top() + maxHeap.Top()) / 2.0);
        }

        return minHeap.Count > maxHeap.Count ? minHeap.Top() : maxHeap.Top();
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */