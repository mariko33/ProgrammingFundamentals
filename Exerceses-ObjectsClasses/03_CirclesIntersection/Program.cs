using System;
using System.Collections.Generic;
using System.Linq;


namespace _03_CirclesIntersection
{
    public class Program
    {
        public static void Main()
        {
            var inputCircleFirst = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            
            var inputCircleSecond= Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            
            Circle circleFirst=new Circle(inputCircleFirst[2],inputCircleFirst[0],inputCircleFirst[1]);
            Circle circleSecond=new Circle(inputCircleSecond[2],inputCircleSecond[0],inputCircleSecond[1]);

            if (Point.Intersect(circleFirst,circleSecond))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }

    public class Circle
    {
        private double radius;
        private List<double> center;

        public Circle(double radius, double x, double y)
        {
            this.radius = radius;
            this.center = new List<double>() {x, y};

        }

        public double Radius { get { return this.radius; } set { this.radius = value; } }
        
        public List<double> Center { get { return this.center; } set { this.center = value; } }
        
        
    }

    public static class Point
    {
        public static bool Intersect(Circle c1, Circle c2)
        {
            double distance = Math.Sqrt(Math.Pow((c1.Center[0] - c2.Center[0]), 2) +
                                        Math.Pow((c1.Center[1] - c2.Center[1]), 2));

            if (distance>c1.Radius+c2.Radius)
            {
                return false;
            }
            
            return true;
        }
    }
}
