using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
            Object common = first + " " + second;
            string third = (string) common;
            Console.WriteLine(third);
        }
    }
}
