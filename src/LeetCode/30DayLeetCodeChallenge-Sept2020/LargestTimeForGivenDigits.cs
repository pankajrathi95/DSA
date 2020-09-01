/*
Given an array of 4 digits, return the largest 24 hour time that can be made.

The smallest 24 hour time is 00:00, and the largest is 23:59.  Starting from 00:00, a time is larger if more time has elapsed since midnight.

Return the answer as a string of length 5.  If no valid time can be made, return an empty string.

 

Example 1:

Input: [1,2,3,4]
Output: "23:41"
Example 2:

Input: [5,5,5,5]
Output: ""
 

Note:

A.length == 4
0 <= A[i] <= 9
*/

using System.Collections.Generic;
using System.Text;

public class LargestTimeForGivenDigits
{
    public string LargestTimeFromDigits(int[] A)
    {
        string result = "";
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (i == j || j == k || k == i)
                    {
                        continue;
                    }

                    string hh = A[i] + "" + A[j];
                    string mm = A[k] + "" + A[6 - i - j - k];
                    string time = hh + ":" + mm;
                    if (hh.CompareTo("24") < 0 && mm.CompareTo("60") < 0 && time.CompareTo(result) > 0)
                    {
                        result = time;
                    }
                }
            }
        }

        return result;
    }
}