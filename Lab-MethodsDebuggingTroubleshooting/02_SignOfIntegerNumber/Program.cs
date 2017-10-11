using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SignOfIntegerNumber
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            PrintSign(input);

        }

        private static void PrintSign(int input)
        {
            if (input>0)
            {
                Console.WriteLine($"The number {input} is positive.");
            }
            if (input<0)
            {
                Console.WriteLine($"The number {input} is negative.");
            }
            if (input==0)
            {
                Console.WriteLine($"The number {input} is zero.");
            }
        }
    }
}
