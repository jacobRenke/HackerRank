using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Divisible_Sum_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int k = 3;
            List<int> ar = new List<int> { 1, 3, 2, 6, 1 };
            Console.WriteLine(divisibleSumPairs(n, k, ar));
        }

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int[] array = ar.ToArray();
            int result = 0;
            
            for (int i = 0; i < array.Length; ++i)//1..
            {
                for (int j = i; j < array.Length; ++j)//3, 2, 6, 1, 2..
                {
                    if ((array[i] + array[j]) % k == 0)
                    {
                        Console.WriteLine(array[j]);
                        
                        result++;
                    }
                    Console.WriteLine(array[j]);
                    
                }
            }

            return result;
        }
    }
}
