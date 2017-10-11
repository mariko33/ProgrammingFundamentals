using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CalculateTriangleArea
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            PrintTriangleArea(a,h);
        }

        static void PrintTriangleArea(double a, double h)
        {
            Console.WriteLine(a*h/2);
        }
        
    }
}
