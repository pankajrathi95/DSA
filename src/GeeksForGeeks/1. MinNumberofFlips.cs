/*
https://practice.geeksforgeeks.org/problems/min-number-of-flips/

Given a binary string, that is it contains only 0s and 1s. We need to make this string a sequence of alternate characters by flipping some of the bits, our goal is to minimize the number of bits to be flipped.
Examples:

Input : str = “001”
Output : 1
Minimum number of flips required = 1
We can flip 1st bit from 0 to 1 

Input : str = “0001010111”
Output : 2
Minimum number of flips required = 2
We can flip 2nd bit from 0 to 1 and 9th 
bit from 1 to 0 to make alternate 
string “0101010101”.
Input:

The first line of input contains a single integer T denoting the number of test cases. Then T test cases follow. Each test case consists of one line. The line contains a string of 0's and 1's.

Output:

Minimum number of characters to be removed to make string alternate.

Constraints:

1 ≤ T ≤ 100
1 ≤ string length ≤ 1000

Example:

Input
2
01010
1111

Output
0
2
*/

using System;
public class MinNumberofFlips
{
    static public void MinimumNumberOfFlips()
    {
        int testCases = Convert.ToInt32(Console.ReadLine());
        while (testCases > 0)
        {
            string input = Console.ReadLine();
            MinNumberFlips(input);
            testCases--;
        }
    }

    private static void MinNumberFlips(string input)
    {
        Console.WriteLine(Math.Min(MinFlips(input, '0'), MinFlips(input, '1')));
    }

    private static int MinFlips(string input, char ch)
    {
        if (input == null)
        {
            return 0;
        }

        int flips = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ch)
            {
                flips++;
            }

            ch = Flip(ch);
        }

        return flips;
    }

    private static char Flip(char ch)
    {
        return ch == '0' ? '1' : '0';
    }
}