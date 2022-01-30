using System;
using System.Collections.Generic;

namespace Breaking_the_Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static List<int> breakingRecords(List<int> scores) // scores = [12, 24, 10, 24]
        {
            int maxScore = scores[0];
            int minScore = scores[0];
            int maxCount = 0;
            int minCount = 0;
            
            List<int> result = new List<int>(2); 

            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                    maxCount++;
                }
                else if (scores[i] < minScore)
                {
                    minScore = scores[i];
                    minCount++;
                }
            }

            result.Add(maxCount);
            result.Add(minCount);
            
            return result;
        }
    }
}
