using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_IntegerToHexAndBinary
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(input,16).ToUpper());
            Console.WriteLine(Convert.ToString(input,2));
        }
    }
}
