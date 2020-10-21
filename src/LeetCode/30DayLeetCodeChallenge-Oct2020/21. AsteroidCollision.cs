/*
#735 - https://leetcode.com/problems/asteroid-collision/
We are given an array asteroids of integers representing asteroids in a row.

For each asteroid, the absolute value represents its size, and the sign represents its direction (positive meaning right, negative meaning left). Each asteroid moves at the same speed.

Find out the state of the asteroids after all collisions. If two asteroids meet, the smaller one will explode. If both are the same size, both will explode. Two asteroids moving in the same direction will never meet.

 

Example 1:

Input: asteroids = [5,10,-5]
Output: [5,10]
Explanation: The 10 and -5 collide resulting in 10.  The 5 and 10 never collide.
Example 2:

Input: asteroids = [8,-8]
Output: []
Explanation: The 8 and -8 collide exploding each other.
Example 3:

Input: asteroids = [10,2,-5]
Output: [10]
Explanation: The 2 and -5 collide resulting in -5. The 10 and -5 collide resulting in 10.
Example 4:

Input: asteroids = [-2,-1,1,2]
Output: [-2,-1,1,2]
Explanation: The -2 and -1 are moving left, while the 1 and 2 are moving right. Asteroids moving the same direction never meet, so no asteroids will meet each other.
 

Constraints:

1 <= asteroids <= 104
-1000 <= asteroids[i] <= 1000
asteroids[i] != 0
*/

using System;
using System.Collections.Generic;

public class AsteroidCollision
{
    public int[] AsteroidCollisions(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(asteroids[0]);
        for (int i = 1; i < asteroids.Length; i++)
        {
            int item = asteroids[i];
            if (item > 0)
            {
                stack.Push(item);
            }
            else
            {
                if (stack.Count == 0)
                {
                    stack.Push(item);
                    continue;
                }

                while (stack.Count != 0)
                {
                    int peek = stack.Peek();
                    if (peek < 0 && item < 0 || peek > 0 && item > 0)
                    {
                        stack.Push(item);
                        break;
                    }

                    if (Math.Abs(item) > Math.Abs(peek))
                    {
                        stack.Pop();
                        if (stack.Count == 0)
                        {
                            stack.Push(item);
                            break;
                        }
                    }
                    else if (Math.Abs(item) == Math.Abs(peek))
                    {
                        stack.Pop();
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        int[] res = new int[stack.Count];
        for (int i = res.Length - 1; i >= 0; i--)
        {
            res[i] = stack.Pop();
        }

        return res;
    }
}