using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_LongerLine
{
    class Program
    {
        static void Main()
        {
            //first line points
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            //second line points
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firsLineWidth = WidthLine(x1, y1, x2, y2);
            double secondLineWidth = WidthLine(x3, y3, x4, y4);

            if (firsLineWidth >= secondLineWidth)
            {
                PrintCenterPoint(x1, y1, x2, y2);
            }
            else
            {
                PrintCenterPoint(x3, y3, x4, y4);
            }

        }

        static void PrintCenterPoint(double xFirst, double yFirst, double xSecond, double ySecond)
        {
            //distance from (0,0)
            double firstDistance = Math.Sqrt(Math.Pow(xFirst, 2) + Math.Pow(yFirst, 2));
            double secondDistance = Math.Sqrt(xSecond * xSecond + ySecond * ySecond);
            if (firstDistance <= secondDistance)
            {
                Console.WriteLine($"({xFirst}, {yFirst})({xSecond}, {ySecond})");
            }
            else
            {
                Console.WriteLine($"({xSecond}, {ySecond})({xFirst}, {yFirst})");
            }
        }

        static double WidthLine(double firstX, double firstY, double secondX, double secondY)
        {
            //pitagor's theorema
            double a = firstX - secondX;
            double b = firstY - secondY;
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        }
    }
}
