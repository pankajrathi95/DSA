/*
#1640 - https://leetcode.com/problems/check-array-formation-through-concatenation/

You are given an array of distinct integers arr and an array of integer arrays pieces, where the integers in pieces are distinct. Your goal is to form arr by concatenating the arrays in pieces in any order. However, you are not allowed to reorder the integers in each array pieces[i].

Return true if it is possible to form the array arr from pieces. Otherwise, return false.

 

Example 1:

Input: arr = [85], pieces = [[85]]
Output: true
Example 2:

Input: arr = [15,88], pieces = [[88],[15]]
Output: true
Explanation: Concatenate [15] then [88]
Example 3:

Input: arr = [49,18,16], pieces = [[16,18,49]]
Output: false
Explanation: Even though the numbers match, we cannot reorder pieces[0].
Example 4:

Input: arr = [91,4,64,78], pieces = [[78],[4,64],[91]]
Output: true
Explanation: Concatenate [91] then [4,64] then [78]
Example 5:

Input: arr = [1,3,5,7], pieces = [[2,4,6,8]]
Output: false
 

Constraints:

1 <= pieces.length <= arr.length <= 100
sum(pieces[i].length) == arr.length
1 <= pieces[i].length <= arr.length
1 <= arr[i], pieces[i][j] <= 100
The integers in arr are distinct.
The integers in pieces are distinct (i.e., If we flatten pieces in a 1D array, all the integers in this array are distinct).
   Hide Hint #1  
Note that the distinct part means that every position in the array belongs to only one piece
   Hide Hint #2  
Note that you can get the piece every position belongs to naively
*/

using System.Collections.Generic;

public class CheckArrayFormationThroughConcatenationSolution
{
    public bool CanFormArray(int[] arr, int[][] pieces)
    {
        //Store all the first values, row number in Dictionary for the pieces array.
        Dictionary<int, int> values = new Dictionary<int, int>();
        for (int i = 0; i < pieces.Length; i++)
        {
            values.Add(pieces[i][0], i);
        }

        for (int i = 0; i < arr.Length;)
        {
            int val = arr[i];
            //Check if you have found the value from the hashmap.
            if (values.ContainsKey(val))
            {
                int index = values[val];
                //once you found the index value for that element iterate over the inner elements of pieces[index] array
                for (int j = 0; j < pieces[index].Length; j++)
                {
                    //at any point if you have not found the element matching with arr[] array just return false otherwise increment i.
                    if (arr[i] != pieces[index][j])
                    {
                        return false;
                    }

                    i++;
                }
            }
            //If you have not found then you can return false as we didn't find the required element
            else
            {
                return false;
            }
        }

        return true;
    }
}