using System;
using System.Collections.Generic;

public class SortStack
{
    Stack<int> main;
    Stack<int> sorted;

    public SortStack()
    {
        main = new Stack<int>();
        sorted = new Stack<int>();
    }

    public void Push(int item)
    {
        if (main.Count == 0)
        {
            main.Push(item);
            return;
        }

        while (main.Count != 0)
        {
            if (item > main.Peek())
            {
                sorted.Push(main.Pop());
            }
            else
            {
                sorted.Push(item);
            }
        }

        if (sorted.Peek() != item)
        {
            sorted.Push(item);
        }

        while (sorted.Count != 0)
        {
            main.Push(sorted.Pop());
        }
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("stack is empty");
            return -1;
        }
        return main.Pop();
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("stack is empty");
            return -1;
        }
        return main.Peek();
    }

    public bool IsEmpty()
    {
        return main.Count == 0;
    }
}