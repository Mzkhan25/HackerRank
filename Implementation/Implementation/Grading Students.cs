using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public class Grading_Students
    {
        static int[] gradingStudents(int[] grades)
        {
            for (var index = 0; index < grades.Length; index++)
            {
                int modulus = grades[index] % 5;
                if ((grades[index] >= 38) && (modulus > 2))
                {
                    grades[index] = grades[index] + (5 - (modulus));
                }
            }

            return grades;
        }

         public Grading_Students()
        {
            TextWriter tw = new StreamWriter("F:/d.txt", true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            int[] result = gradingStudents(grades);

            tw.WriteLine(string.Join("\n", result));

            tw.Flush();
            tw.Close();
        }
    }
}
