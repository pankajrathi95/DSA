/*
Stack of Plates: Implement a Data structure has several stacks in it and if any stack exceeds the limit,
it goes to the next stack.

Also implement PopAt(index) wich Pops item from the sub stack at index 
*/
using System;

public class StackofPlates
{
    public class Stack
    {
        public int size;
        public int[] values;
        public int top;

        public Stack(int size)
        {
            this.size = size;
            values = new int[size];
            top = 0;
        }

        public void Push(int item)
        {
            if (IsFull())
            {
                throw new StackOverflowException();
            }

            values[top++] = item;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidProgramException();
            }

            return values[--top];
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

    Stack[] stackofPlates;
    public int currentIndex;

    public StackofPlates(int size)
    {
        stackofPlates = new Stack[size];
        for (int i = 0; i < stackofPlates.Length; i++)
        {
            stackofPlates[i] = new Stack(3);
        }
        currentIndex = 0;
    }

    public void Push(int item)
    {
        if (stackofPlates[currentIndex].IsFull())
        {
            currentIndex++;
        }

        if (currentIndex == stackofPlates.Length)
        {
            Console.WriteLine("Complete stack is Full");
            return;
        }

        stackofPlates[currentIndex].Push(item);
    }

    public int Pop()
    {
        if (stackofPlates[currentIndex].IsEmpty())
        {
            currentIndex--;
        }

        if (currentIndex == -1)
        {
            Console.WriteLine("Complete stack is Empty");
            return -1;
        }

        return stackofPlates[currentIndex].Pop();
    }

    public int PopAt(int index)
    {
        if (index >= stackofPlates.Length || index < 0)
        {
            Console.WriteLine("Invalid Index Value");
            return -1;
        }

        if (stackofPlates[index].IsEmpty())
        {
            Console.WriteLine("Sub-stack is Empty");
            return -1;
        }

        return stackofPlates[index].Pop();
    }
}