using System;
using System.Collections.Generic;

namespace Counting_Valleys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countingValleys(8, "UDDDUDUU"));
        }

        public static int countingValleys(int steps, string path)
        {
            int valleyCounter = 0;
            int sealevel = 0;
            bool flag = false;

            char[] travel = path.ToCharArray();

            while (!flag)
            {
                for (int i = 0; i < travel.Length - 1; i++)
                {
                    if (travel[i] == 'D' && sealevel == 0)
                    {
                        valleyCounter++;
                        sealevel--;
                    }
                    else if (travel[i] == 'D')
                    {
                        sealevel--;
                    }
                    else if (travel[i] == 'U')
                    {
                        sealevel++;
                    }
                    else if (sealevel == 0)
                    {
                        break;
                    }
                }
                flag = true;
                
            }
            return valleyCounter;




        }


    }
}
