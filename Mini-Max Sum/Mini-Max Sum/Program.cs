using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Max_Sum
{
    class Program
    {
        static void miniMaxSum(ulong[] arr)
        {
            if (arr.Length > 0)
            {
                ulong minValue = Convert.ToUInt64(arr[0]);
                ulong maxValue = Convert.ToUInt64(arr[0]);
                int minValueIndex = 0;
                int maxValueIndex = 0;
                ulong minSum = 0;
                ulong maxSum = 0;
                for (var index = 0; index < arr.Length; index++)
                {
                    var item = arr[index];
                    if (minValue > Convert.ToUInt64(item))
                    {
                        minValue = Convert.ToUInt64(item);
                        minValueIndex = index;
                    }

                    if (maxValue < Convert.ToUInt64(item))
                    {
                        maxValue = Convert.ToUInt64(item);
                        maxValueIndex = index;
                    }
                        
                }

                for (var index = 0; index < arr.Length; index++)
                {
                    var item = arr[index];
                    if (minValueIndex !=index)
                        maxSum = maxSum + Convert.ToUInt64(item);
                    if (maxValueIndex != index)
                        minSum = minSum + Convert.ToUInt64(item);
                }

                Console.Write(minSum);
                Console.Write(' ');
                Console.Write(maxSum);
            }
            else
                Console.Write("Invalid Input");

        }

        static void Main(string[] args)
        {
            ulong[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToUInt64(arrTemp))
                ;
            miniMaxSum(arr);
        }
    }
}
