/*
Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

push(x) -- Push element x onto stack.
pop() -- Removes the element on top of the stack.
top() -- Get the top element.
getMin() -- Retrieve the minimum element in the stack.
 

Example:

MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin();   --> Returns -3.
minStack.pop();
minStack.top();      --> Returns 0.
minStack.getMin();   --> Returns -2.
*/

using System.Collections.Generic;

public class MinStack
{

    /** initialize your data structure here. */
    LinkedList<int> linkedList;
    int top = 0;
    int minValue = 0;
    public MinStack()
    {
        linkedList = new LinkedList<int>();
    }

    public void Push(int x)
    {
        linkedList.AddLast(x);
        top++;
    }

    public void Pop()
    {
        linkedList.RemoveLast();

    }

    public int Top()
    {
        return linkedList.Last.Value;
    }

    public int GetMin()
    {
        minValue = linkedList.First.Value;
        foreach (var item in linkedList)
        {
            if (minValue > item)
            {
                minValue = item;
            }
        }
        return minValue;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
