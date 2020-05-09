/*
You are in an infinite 2D grid where you can move in any of the 8 directions :

 (x,y) to 
    (x+1, y), 
    (x - 1, y), 
    (x, y+1), 
    (x, y-1), 
    (x-1, y-1), 
    (x+1,y+1), 
    (x-1,y+1), 
    (x+1,y-1) 
You are given a sequence of points and the order in which you need to cover the points. Give the minimum number of steps in which you can achieve it. You start from the first point.
*/

using System;
using System.Collections.Generic;

class MinStepsInfiniteGrid
{
    public int CoverPoints(List<int> A, List<int> B)
    {
        int steps = 0;
        if (A.Count == 1 || B.Count == 1)
        {
            return 0;
        }

        for (int i = 0; i < A.Count - 1; i++)
        {
            if (Math.Abs(A[i + 1] - A[i]) <= Math.Abs(B[i + 1] - B[i]))
            {
                steps += Math.Abs(B[i + 1] - B[i]);
            }
            else
            {
                steps += Math.Abs(A[i + 1] - A[i]);
            }
        }

        return steps;
    }
}
