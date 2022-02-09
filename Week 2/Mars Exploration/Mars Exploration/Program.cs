using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Exploration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "SOSSOSSOS";
            Console.WriteLine(marsExploration(s));
        }

        public static int marsExploration(string s) //return an integer for how many times a letter was changed from SOS
        {
            int counter = 0;
            int length = s.Length / 3;
            char[] ch = s.ToCharArray();
            string comparisionString = String.Concat(Enumerable.Repeat("SOS", length));
            char[] comparision = comparisionString.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] != comparision[i])
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}
