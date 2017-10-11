using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloName
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintHello(name);
        }

        private static void PrintHello(string name)
        {
           Console.WriteLine($"Hello, {name}!");
        }
    }
}
