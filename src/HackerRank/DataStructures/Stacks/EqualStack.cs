/*
https://www.hackerrank.com/challenges/equal-stacks/problem
*/

using System.Collections.Generic;

public class EqualStack
{
    public static int EqualStacks(int[] h1, int[] h2, int[] h3)
    {
        Stack<int> st1 = new Stack<int>();
        Stack<int> st2 = new Stack<int>();
        Stack<int> st3 = new Stack<int>();

        int st1TotalHeight = 0, st2TotalHeight = 0, st3TotalHeight = 0;

        // pushing consolidated height into the stack instead of individual cylinder
        // height
        for (int i = h1.Length - 1; i >= 0; i--)
        {
            st1TotalHeight += h1[i];
            st1.Push(st1TotalHeight);
        }
        for (int i = h2.Length - 1; i >= 0; i--)
        {
            st2TotalHeight += h2[i];
            st2.Push(st2TotalHeight);
        }
        for (int i = h3.Length - 1; i >= 0; i--)
        {
            st3TotalHeight += h3[i];
            st3.Push(st3TotalHeight);
        }

        while (true)
        {

            // If any stack is empty
            if (st1.Count == 0 || st2.Count == 0 || st3.Count == 0)
                return 0;

            st1TotalHeight = st1.Peek();
            st2TotalHeight = st2.Peek();
            st3TotalHeight = st3.Peek();

            // If sum of all three stack are equal.
            if (st1TotalHeight == st2TotalHeight && st2TotalHeight == st3TotalHeight)
                return st1TotalHeight;

            // Finding the stack with maximum sum and
            // removing its top element.
            if (st1TotalHeight >= st2TotalHeight && st1TotalHeight >= st3TotalHeight)
                st1.Pop();
            else if (st2TotalHeight >= st3TotalHeight && st2TotalHeight >= st1TotalHeight)
                st2.Pop();
            else if (st3TotalHeight >= st2TotalHeight && st3TotalHeight >= st1TotalHeight)
                st3.Pop();
        }
    }
}