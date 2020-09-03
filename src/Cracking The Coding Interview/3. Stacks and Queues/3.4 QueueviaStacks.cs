using System.Collections.Generic;

public class QueueviaStacks
{
    Stack<int> oldStack;
    Stack<int> newStack;

    public QueueviaStacks()
    {
        oldStack = new Stack<int>();
        newStack = new Stack<int>();
    }

    public void Enqueue(int item)
    {
        newStack.Push(item);
    }

    public int Dequeue()
    {
        ShiftStacks();
        return oldStack.Pop();
    }

    private void ShiftStacks()
    {
        if (oldStack.Count == 0)
        {
            while (newStack.Count != 0)
            {
                oldStack.Push(newStack.Pop());
            }
        }
    }
}