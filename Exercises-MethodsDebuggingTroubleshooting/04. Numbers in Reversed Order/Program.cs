using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NumbersInReversedOrder
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            PrintReversedString(input);
        }

        static void PrintReversedString(string input)
        {
            for (int i = input.Length-1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
