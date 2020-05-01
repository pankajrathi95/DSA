using System;
public class Heapify
{
    int[] numbers;
    public int[] HeapifyIt(int[] nums)
    {
        numbers = nums;
        for (int i = 0; i < numbers.Length; i++)
        {
            BubbleDown(i);
        }

        return numbers;
    }

    private void BubbleDown(int i)
    {
        while (i < numbers.Length && !IsValidParent(i))
        {
            int largerindex = LargerChild(i);
            Swap(numbers[i], largerindex);
            i = largerindex;
        }
    }

    private int GetLeftChildIndex(int parent)
    {
        return parent * 2 + 1;
    }

    private int GetRightChildIndex(int parent)
    {
        return parent * 2 + 2;
    }

    private int GetLeftChild(int parent)
    {
        if (!HasLeftChild(parent))
        {
            throw new InvalidOperationException();
        }

        return numbers[GetLeftChildIndex(parent)];
    }

    private int GetRightChild(int parent)
    {
        if (!HasRightChild(parent))
        {
            throw new InvalidOperationException();
        }

        return numbers[GetRightChildIndex(parent)];
    }

    private bool IsValidParent(int index)
    {
        if (!HasLeftChild(index))
        {
            return true;
        }

        if (!HasRightChild(index))
        {
            return GetLeftChild(index) <= numbers[index];
        }

        return GetLeftChild(index) <= numbers[index] && GetRightChild(index) <= numbers[index];
    }

    private bool HasLeftChild(int index)
    {
        return GetLeftChildIndex(index) < numbers.Length;
    }

    private bool HasRightChild(int index)
    {
        return GetRightChildIndex(index) < numbers.Length;
    }

    private void Swap(int first, int second)
    {
        int temp = numbers[first];
        numbers[first] = numbers[second];
        numbers[second] = temp;
    }

    private int LargerChild(int index)
    {
        if (!HasLeftChild(index))
        {
            return index;
        }

        if (!HasRightChild(index))
        {
            return GetLeftChild(index);
        }

        return GetLeftChild(index) > GetRightChild(index) ? GetLeftChildIndex(index) : GetRightChildIndex(index);
    }
}