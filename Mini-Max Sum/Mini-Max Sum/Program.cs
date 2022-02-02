using System;
using System.Collections.Generic;

namespace Mini_Max_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 256741038, 623958417, 467905213, 714532089, 938071625 };
            List<int> list = new List<int>(numbers);
            miniMaxSum(list);
        }

        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            double minSum = 0;
            double maxSum = 0;


            for (int i = 0; i < arr.Count - 1; i++)
            {
                minSum += arr[i];
            }

            for (int i = 1; i < arr.Count; i++)
            {
                maxSum += arr[i];
            }
            Console.WriteLine("{0} {1}", minSum, maxSum);
        }

    }
}
