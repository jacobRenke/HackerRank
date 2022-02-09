using System;
using System.Collections.Generic;

namespace Pangrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "qmExzBIJmdELxyOFWv LOCmefk TwPhargKSPEqSxzveiun";
            Console.WriteLine(pangrams(s));
        }

        public static string pangrams(string s)
        {
            s = s.ToLower();
            char[] ch = s.ToCharArray();
            Array.Sort(ch);
            Dictionary<int, char> alphabet = new Dictionary<int, char>(); //dictionary for alphabet 
            for (char c = 'a'; c <= 'z'; c++)
            {
                int key = c - 'a' + 1;
                alphabet.Add(key, c);
            }

            Dictionary<int, bool> checks = new Dictionary<int, bool>();
            
            string resultTrue = "pangram";
            string resultFalse = "not pangram";

                for (int i = 0; i < ch.Length; i++)
                {
                    for (int j = 1; j < alphabet.Count; j++)
                    {
                        if (ch[i] == alphabet[j])
                        {
                            if (!checks.ContainsKey(alphabet[j]))
                            {
                                checks.Add(alphabet[j], true);
                            }
                            
                        }
                    }
                }
                if (checks.ContainsValue(false))
                {
                    return resultFalse;
                }
                else if (checks.Count <= 24)
                {
                    return resultFalse;
                }
                else
                {
                    return resultTrue;
                }

        }
    }
}
