/*
https://www.hackerrank.com/challenges/cats-and-a-mouse/problem
*/

using System;

public class CatsAndMouse
{

    // Complete the catAndMouse function below.
    static string catAndAMouse(int x, int y, int z)
    {
        int sumA = Math.Abs(Math.Abs(x) - Math.Abs(z));
        int sumB = Math.Abs(Math.Abs(y) - Math.Abs(z));

        if (sumA < sumB)
        {
            return "Cat A";
        }
        else if (sumA > sumB)
        {
            return "Cat B";
        }
        else
        {
            return "Mouse C";
        }
    }
}