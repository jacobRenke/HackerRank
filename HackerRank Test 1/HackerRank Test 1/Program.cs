using System;
using System.Collections.Generic;

namespace HackerRank_Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>(7) { 0, 1, 3, 4, 6, 5, 2};
            Console.WriteLine(findMedian(arr));
        }
        public static int findMedian(List<int> arr)
        {
            int[] array = arr.ToArray();
            Array.Sort(array);
            int result = 0;

            if ((array.Length / 2) == 0)
            {
                result = (array[7 / 2]) + 1;
            }
            else
            {
                result = (array[7 / 2]);
            }
            return result;
        }

        
    }
}
