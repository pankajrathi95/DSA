/*
It's New Year's Day and everyone's in line for the Wonderland rollercoaster ride! There are a number of people queued up, and each person wears a sticker indicating their initial position in the queue. Initial positions increment by  from  at the front of the line to  at the back.

Any person in the queue can bribe the person directly in front of them to swap positions. If two people swap positions, they still wear the same sticker denoting their original places in line. One person can bribe at most two others. For example, if  and  bribes , the queue will look like this: .

Fascinated by this chaotic queue, you decide you must know the minimum number of bribes that took place to get the queue into its current state!

Function Description

Complete the function minimumBribes in the editor below. It must print an integer representing the minimum number of bribes necessary, or Too chaotic if the line configuration is not possible.

minimumBribes has the following parameter(s):

q: an array of integers
Input Format

The first line contains an integer , the number of test cases.

Each of the next  pairs of lines are as follows:
- The first line contains an integer , the number of people in the queue
- The second line has  space-separated integers describing the final state of the queue.

Constraints

Subtasks

For  score 
For  score 

Output Format

Print an integer denoting the minimum number of bribes needed to get the queue into its final state. Print Too chaotic if the state is invalid, i.e. it requires a person to have bribed more than  people.

Sample Input

2
5
2 1 5 3 4
5
2 5 1 3 4

Sample Output

3
Too chaotic
*/

using System;
using System.Collections.Generic;

class NewYearChaos
{
    public void MinimumBribes(int[] q)
    {
        int count = 0;
        List<int> numbers = new List<int>(q);
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            if (numbers[i] == i + 1)
            {
                numbers.RemoveAt(i);
            }
            else if (numbers[i - 1] == i + 1)
            {
                count++;
                numbers.RemoveAt(i - 1);
            }
            else if (numbers[i - 2] == i + 1)
            {
                count += 2;
                numbers.RemoveAt(i - 2);
            }
            else
            {
                Console.WriteLine("Too chaotic");
                return;
            }
        }

        Console.WriteLine(count);
    }
}