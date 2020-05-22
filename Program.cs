using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 0, 1, 1, 1 };
            matrix[1] = new int[] { 1, 1, 1, 1 };
            matrix[2] = new int[] { 0, 1, 1, 1 };

            CountSquareSubmatricesWithAllOnes allOnes = new CountSquareSubmatricesWithAllOnes();
            allOnes.CountSquares(matrix);
        }
    }
}
