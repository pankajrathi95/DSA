using System;

class Heap
{
    private int[] nums;

    private int size;
    public Heap(int size)
    {
        nums = new int[size];
    }

    public void Insert(int value)
    {
        if (IsFull())
        {
            throw new InvalidOperationException();
        }
        nums[size++] = value;
        BubbleUp();
    }

    public int Remove()
    {
        int root = nums[0];
        if (IsEmpty())
        {
            throw new InvalidOperationException();
        }
        nums[0] = nums[--size];

        BubbleDown();
        return root;
    }

    private void BubbleDown()
    {
        int parent = 0;
        while (parent <= size && !IsValidParent(parent))
        {
            int largerChildIndex = LargerChild(parent);
            Swap(parent, largerChildIndex);
            parent = largerChildIndex;
        }
    }

    private int LargerChild(int index)
    {
        if (!HasLeftChild(index))
        {
            return index;
        }

        if (!HasRightChild(index))
        {
            return LeftChild(index);
        }

        return nums[LeftChild(index)] > nums[RightChild(index)] ? LeftChild(index) : RightChild(index);
    }


    private bool IsValidParent(int parent)
    {
        if (!HasLeftChild(parent))
        {
            return true;
        }

        if (!HasRightChild(parent))
        {
            return nums[LeftChild(parent)] >= nums[parent];
        }

        return nums[LeftChild(parent)] <= nums[parent] && nums[RightChild(parent)] <= nums[parent];
    }

    private bool HasLeftChild(int index)
    {
        return LeftChild(index) <= size;
    }

    private bool HasRightChild(int index)
    {
        return RightChild(index) <= size;
    }
    private void BubbleUp()
    {
        int index = size - 1;
        while (index > 0 && nums[index] > nums[Parent(index)])
        {
            Swap(index, Parent(index));
            index = Parent(index);
        }
    }
    private int Parent(int index)
    {
        return (index - 1) / 2;
    }

    private int LeftChild(int index)
    {
        return (2 * index) + 1;
    }

    private int RightChild(int index)
    {
        return (2 * index) + 2;
    }
    private void Swap(int first, int second)
    {
        int temp = nums[first];
        nums[first] = nums[second];
        nums[second] = temp;
    }

    public bool IsFull()
    {
        return size == nums.Length;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public int Max()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException();
        }

        return nums[0];
    }
}