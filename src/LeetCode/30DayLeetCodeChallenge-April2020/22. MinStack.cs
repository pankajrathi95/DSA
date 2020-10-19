/*
#155 - https://leetcode.com/problems/min-stack/
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

    Stack<int> min;
    Stack<int> stack;
    /** initialize your data structure here. */
    public MinStack()
    {
        min = new Stack<int>();
        stack = new Stack<int>();
    }

    public void Push(int x)
    {
        if (stack.Count == 0)
        {
            stack.Push(x);
            min.Push(x);
            return;
        }

        int peek = min.Peek();
        if (peek > x)
        {
            min.Push(x);
        }
        else
        {
            min.Push(peek);
        }

        stack.Push(x);
    }

    public void Pop()
    {
        stack.Pop();
        min.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return min.Peek();
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
