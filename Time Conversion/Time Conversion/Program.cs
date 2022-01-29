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

namespace Time_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exampleTime = "09:05:45PM";
            Console.Write(timeConversion(exampleTime));
            Console.ReadKey();
        }

        public static string timeConversion(string s) //12:01:00PM
        {
            Dictionary<string, string> militaryTime = new Dictionary<string, string>();

            for (int i = 1; i <= 12; i++)
            {
                if (i != 12)
                {
                    militaryTime.Add(ConvertToString(i), ConvertToString(i + 12));
                }
                else
                    militaryTime.Add(ConvertToString(i), "00");
            }

            string firstTwo = s.Substring(0,2);

            if (s.Contains("PM") && firstTwo != "12")
            {
                firstTwo = militaryTime[firstTwo];

            } 
            else if (s.Contains("AM") && firstTwo == "12")
            {
                firstTwo = militaryTime[firstTwo];
            }

            s = s.Remove(0, 2).Insert(0, firstTwo);
            s = s.Remove(8, 2);

            return s;
            

        }
        //helper function to make Dictionary
        public static string ConvertToString(int i)
        {
            if (i <= 9)
            {
                return ($"0{i.ToString()}");
            }
            else
                return i.ToString();
        }


            //        Function Description

            //Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

            //timeConversion has the following parameter(s):
            //string s: a time in 12-hour format

            //Returns time in 24 hour

            //string: the time in  hour format
            //Input Format

            //A single string  that represents a time in 12-hour clock format (i.e.: hh:mm:ssAM or hh:mm:ssPM ).

            //Constraints

            //All input times are valid
        }
}
