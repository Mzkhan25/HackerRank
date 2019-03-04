using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            int length = arr.Length;
            float negative, zero;
            var positive = negative = zero = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0)
                    positive = positive + 1;
                else if (arr[i] < 0)
                    negative = negative + 1;
                else
                    zero = zero + 1;
            }
            Console.Write(positive % length);
            Console.Write(negative % length);
            Console.Write(zero % length);

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
            plusMinus(arr);
        }
    }
}
