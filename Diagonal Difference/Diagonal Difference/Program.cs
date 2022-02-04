using System;
using System.Collections.Generic;

namespace Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>> {
                new List<int>() { 11, 2, 4 }, 
                new List<int>() { 4, 5, 6 }, 
                new List<int>() { 10, 8, -12 },
            };
            Console.WriteLine(diagonalDifference(matrix));
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftDiagSum = 0;
            int rightDiagSum = 0;
            int arrCount = arr.Count;
            
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i; j == i; j++)
                {
                    rightDiagSum += arr[i][j];
                }
            }

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = arrCount - 1; j == arrCount - 1; arrCount--)
                {
                    leftDiagSum += arr[i][j];
                }
            }

            return Math.Abs(leftDiagSum - rightDiagSum);
        }
    }
}
