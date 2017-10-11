using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_VariableInHexadecimalFormat
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(input, 16));
        }
    }
}
