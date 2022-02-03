using System;
using System.Collections.Generic;

namespace Lonely_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 15, 60, 74, 1, 94, 93, 28, 48, 70, 98, 45, 94, 42, 45, 48, 1, 72, 9, 24, 93, 41, 70, 60, 28, 11, 20, 72, 35, 11, 98, 31, 74, 31, 41, 9, 42, 20, 35, 24 };
            Console.WriteLine(lonelyinteger(list));
        }

        public static int lonelyinteger(List<int> a)
        {
            a.Sort();
            int i = 0;

            if (a.Count == 1)
            {
                return a[0];
            }
            else
            {
                for (i = 0; i < a.Count - 1; i += 2)
                {
                    if (a[i] != a[i + 1])  // 1, 1,  2, 3, 4, 5, 6, 7
                    {
                        break;
                    }
                }
            }
            return a[i];
        }
    }
}
