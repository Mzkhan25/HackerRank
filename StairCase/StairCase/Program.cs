using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StairCase
{
    class Program
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int outerIndex = n; outerIndex >0 ; outerIndex--)
            {
                for (int innerIndex = 1; innerIndex <= n; innerIndex++)
                {
                    if(innerIndex>=outerIndex)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.Write(Environment.NewLine);
            }

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
