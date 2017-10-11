using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GeometryCalculator
{
    class Program
    {
        static void Main()
        {
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{TriangleArea(side, height):f2}");
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{SquareArea(side):f2}");
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{RectangleArea(width, height):f2}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{CircleArea(radius):f2}");
                    break;

            }
        }

        static double TriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }

        static double SquareArea(double side)
        {
            return Math.Pow(side, 2);
        }

        static double RectangleArea(double width, double height)
        {
            return width * height;
        }

        static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
