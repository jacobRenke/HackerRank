using System;
using System.Collections.Generic;

namespace Migratory_Birds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //'n' is the size of the array
            List<int> arr = new List<int>() { 1, 4, 4, 4, 5, 3 };
            Console.WriteLine(migratoryBirds(arr));
        }

        public static int migratoryBirds(List<int> arr)
        {
            int[] numOfIds = new int[5];
            int index = 0;
            int max = 0;
            foreach (var i in arr)
            {
                numOfIds[i - 1]++;
            }

            for (int i = 0; i < numOfIds.Length; i++)
                if (numOfIds[i] > max)
                {
                    max = numOfIds[i];
                    index = i;
                }
            return index + 1;
        }
    }
}
