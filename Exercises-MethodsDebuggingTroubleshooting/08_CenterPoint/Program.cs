using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CenterPoint
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1= double.Parse(Console.ReadLine());
            double x2= double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            
            PrintCenterPoint(x1,y1,x2,y2);
            
        }

        static void PrintCenterPoint(double xFirst, double yFirst, double xSecond, double ySecond)
        {
            //distance from (0,0)
            double firstDistance = Math.Sqrt(xFirst * xFirst + yFirst * yFirst);
            double secondDistance = Math.Sqrt(xSecond * xSecond + ySecond * ySecond);
            if (firstDistance<=secondDistance)
            {
                Console.WriteLine($"({xFirst}, {yFirst})");
            }
            else
            {
                Console.WriteLine($"({xSecond}, {ySecond})");
            }
        }
    }
}
