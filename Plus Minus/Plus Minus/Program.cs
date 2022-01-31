using System;

namespace Plus_Minus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void plusMinus(List<int> arr)
        {
            double pos = 0;
            double neg = 0;
            double zero = 0;
            double n = arr.Count;
            double posRatio = 0;
            double negRatio = 0;
            double zeroRatio = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 0)
                {
                    zero++;
                }
                else if (arr[i] > 0)
                {
                    pos++;
                }
                else if (arr[i] < 0)
                {
                    neg++;
                }

            }

            posRatio = pos / n;
            negRatio = neg / n;
            zeroRatio = zero / n;

            Console.WriteLine("{0:0.000000}\n{1:0.000000}\n{2:0.000000}", posRatio, negRatio, zeroRatio);
        }
    }
}
