using System;

public class StackMin
{
    public int[] min;
    public int size;
    public int[] values;
    public int top;

    public StackMin(int size)
    {
        this.size = size;
        values = new int[size];
        min = new int[size];
        top = 0;
    }

    public void Push(int item)
    {
        if (IsFull())
        {
            throw new StackOverflowException();
        }

        if (top == 0)
        {
            min[top] = item;
        }
        else
        {
            int lastItem = min[top - 1];
            min[top] = Math.Min(item, lastItem);
        }
        values[top] = item;
        top++;
    }

    public int Min()
    {
        if (IsEmpty())
        {
            throw new InvalidProgramException();
        }

        if (IsEmpty())
        {
            throw new InvalidProgramException();
        }

        return min[top - 1];
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidProgramException();
        }

        return values[top--];
    }
    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidProgramException();
        }

        return values[top];
    }

    public bool IsFull()
    {
        return top == size;
    }

    public bool IsEmpty()
    {
        return top == 0;
    }
}