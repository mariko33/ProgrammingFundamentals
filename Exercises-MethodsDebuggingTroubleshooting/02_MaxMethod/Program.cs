using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MaxMethod
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int firstMax = GetMax(first, second);
            int finalMax = GetMax(firstMax, third);
            Console.WriteLine(finalMax);
        }

        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}
