using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DrawFilledSquare
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            PrintHeaderRow(input);
            for (int i = 1; i <= input-2; i++)
            {
                PrintMiddleRow(input);
            }
            PrintHeaderRow(input);

        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new String('-',2*n));
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}
