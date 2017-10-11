using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_TemperatureConversion
{
    class Program
    {
        static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FarenheitToCelsius(fahrenheit);
            Console.WriteLine($"{celsius:f2}");
        }

        static double FarenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
