using System;
using System.Collections.Generic;

namespace Hacker_Rank_Mock_Test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>();
            matrix.Add(new List<int>(3) { 112, 42, 83, 119 });
            matrix.Add(new List<int>(3) { 56, 125, 56, 49 });
            matrix.Add(new List<int>(3) { 15, 78, 101, 43 });
            matrix.Add(new List<int>(3) { 62, 98, 114, 108 });
            Console.WriteLine(flippingMatrix(matrix));
        }

        public static int flippingMatrix(List<List<int>> matrix)
        {
            int q = 1;
            int n = 2;
            int result = 0;
            int temp = 0; 
            
            //Try reversing the columns before rows
            // These nested For Loops will reverse the list of the last index of the List is lower than the first index
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    if (matrix[i][j] < matrix[i][(j + (n * 2) - 1)])
                    {
                        matrix[i].Reverse();
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //Need to make an algorithm that will do the same as above but for each column 
            for (int i = 0; i < matrix.Count; i++) //need to iterate the width
            {
                for (int j = 0; j < matrix[i].Count; j++) //need to iterate the height 
                {
                    if (matrix[i][j] < matrix[(i + (n * 2) - 1)][j])
                    {
                        //maybe create an array from each index on each column, then reverse, then put back?
                        matrix[i][j] ();
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //Find the maximum sum of numbers in the upper-left quadrent
            for (int i = 0; i < matrix.Count / 2; i++)
            {
                for (int j = 0; j < (matrix[i].Count / (n * 2)); j++)
                {
                    result += matrix[i][j] + (matrix[i][j + 1]);
                }
            }
            return result;
        }
    }
}
