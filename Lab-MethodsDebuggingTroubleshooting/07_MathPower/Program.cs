using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MathPower
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(number,power));

        }

        static double RaiseToPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
