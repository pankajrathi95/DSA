/*
Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.

You may return any answer array that satisfies this condition.

 

Example 1:

Input: [3,1,2,4]
Output: [2,4,3,1]
The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
 

Note:

1 <= A.length <= 5000
0 <= A[i] <= 5000
*/

public class SortArrayByParity
{
    public int[] SortByParity(int[] A)
    {
        int start = 0, end = A.Length - 1;
        while (start < end)
        {
            if (A[start] % 2 != 0 && A[end] % 2 == 0)
            {
                int temp = A[start];
                A[start] = A[end];
                A[end] = temp;
                start++;
                end--;
            }
            else if (A[start] % 2 != 0 && A[end] % 2 != 0)
            {
                end--;
            }
            else if (A[start] % 2 == 0 && A[end] % 2 == 0)
            {
                start++;
            }
            else
            {
                start++;
                end--;
            }
        }

        return A;
    }
}