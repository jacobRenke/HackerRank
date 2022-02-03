using System;
using System.Collections.Generic;

namespace Lonely_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 1, 2 };
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
