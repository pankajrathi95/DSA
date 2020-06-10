/*
https://www.hackerrank.com/challenges/maximum-element/problem
*/

using System;
using System.Collections.Generic;
using System.IO;
public class MaximumElement
{
    public static void FindMaxElement()
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int queries = Int32.Parse(Console.ReadLine());
        Stack<int> myStack = new Stack<int>();
        Stack<int> traceStack = new Stack<int>();

        while (queries != 0)
        {
            string line = Console.ReadLine();

            string[] lineArray = line.Split(' ');

            if (lineArray[0].Equals("1"))
            {
                if (myStack.Count == 0)
                {
                    traceStack.Push(Int32.Parse(lineArray[1]));
                }
                else
                {
                    int item = traceStack.Peek();

                    if (Int32.Parse(lineArray[1]) > item)
                    {
                        traceStack.Push(Int32.Parse(lineArray[1]));
                    }
                    else
                    {
                        traceStack.Push(item);
                    }
                }
                myStack.Push(Int32.Parse(lineArray[1]));
            }
            else if (lineArray[0].Equals("2"))
            {
                myStack.Pop();
                traceStack.Pop();
            }
            else
            {
                Console.WriteLine(traceStack.Peek());
            }

            queries--;
        }
    }
}