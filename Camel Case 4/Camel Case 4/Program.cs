using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        //M indicates method, C indicates class, and V indicates variable
        string[] inputString = new string[] { "S;V;iPad", "C;M;mouse pad", "C;C;code swarm", "S;C;OrangeHighlighter" };
        CamelCase4(inputString);
    }

    public static string CamelCase4(string[] inputString)
    {
        string[] phrase = new string[3];
        char ssOperation = ' '; 
        char ssMCV = ' ';
        string ssContent = "";

        for (int i = 0; i < inputString.Length; i++)
        {
            for (int j = 0; j < inputString[i].Length; j++)
            {
                phrase = inputString[i].Split(';');
                Console.WriteLine(phrase[j]);
            }
            
        }
        return null;
    }


}
