/*
Problem Statement:
Three in One: Describe how you could use a single array to implement three stacks.
*/

using System;

public class ThreeInOne
{
    public int numberOfStacks = 3;
    public int stackCapacity;
    public int[] sizes;
    public int[] values;

    public ThreeInOne(int stackSize)
    {
        stackCapacity = stackSize;
        sizes = new int[numberOfStacks];
        values = new int[stackSize * numberOfStacks];
    }

    public void Push(int item, int stackNum)
    {
        if (IsFull(stackNum))
        {
            throw new StackOverflowException();
        }

        values[IndexOfTop(stackNum) - 1] = item;
        sizes[stackNum]++;
    }

    public int Pop(int stackNum)
    {
        if (IsEmpty(stackNum))
        {
            throw new InvalidProgramException();
        }

        sizes[stackNum]--;
        return values[IndexOfTop(stackNum) - 1];
    }

    public int Peek(int stackNum)
    {
        if (IsEmpty(stackNum))
        {
            throw new InvalidProgramException();
        }

        return values[IndexOfTop(stackNum) - 1];
    }

    public bool IsFull(int stackNum)
    {
        return sizes[stackNum] == stackCapacity;
    }

    public bool IsEmpty(int stackNum)
    {
        return sizes[stackNum] == 0;
    }

    public int IndexOfTop(int stackNum)
    {
        return stackNum * stackCapacity + sizes[stackNum];
    }
}