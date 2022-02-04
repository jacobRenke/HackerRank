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


namespace Grading_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int> { 100, 0, 40 };
            Console.WriteLine(gradingStudents(grades));
        }

        // If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5.
        // If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> roundedGrades = new List<int>(grades.Count);

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38)
                {
                    if ((grades[i] + 2) % 5 == 0)
                    {
                        roundedGrades.Add(grades[i] + 2);
                    }
                    else if ((grades[i] + 1) % 5 == 0)
                    {
                        roundedGrades.Add(grades[i] + 1);
                    }
                    else
                    {
                        roundedGrades.Add(grades[i]);
                    }

                }
                else
                {
                    roundedGrades.Add(grades[i]);
                }
            }
            return roundedGrades;
        }
    }
}
