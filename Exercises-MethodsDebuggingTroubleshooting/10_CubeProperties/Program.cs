using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CubeProperties
{
    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            switch (command)
            {
                case "face":
                    Console.WriteLine($"{FaceDiagonal(side):f2}");
                    break;
                case "space":
                    Console.WriteLine($"{SpaceDiagonal(side):f2}");
                    break;
                case "volume":
                    Console.WriteLine($"{Voulume(side):f2}");
                    break;
                case "area":
                    Console.WriteLine($"{Surface(side):f2}");
                    break;
            }
        }

        static double FaceDiagonal(double side)
        {
            return Math.Sqrt(2 * Math.Pow(side, 2));
        }

        static double SpaceDiagonal(double side)
        {
            return Math.Sqrt(3 * Math.Pow(side, 2));
        }

        static double Voulume(double side)
        {
            return Math.Pow(side, 3);
        }

        static double Surface(double side)
        {
            return 6 * Math.Pow(side, 2);
        }
    }
}
