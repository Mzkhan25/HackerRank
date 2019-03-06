using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter code to run the program");
            var value = Console.ReadLine();

            switch (value)
            {
                case "1":
                    Grading_Students gradingStudents= new Grading_Students();
                    break;

                default:
                    break;

            }
        }
    }
}
