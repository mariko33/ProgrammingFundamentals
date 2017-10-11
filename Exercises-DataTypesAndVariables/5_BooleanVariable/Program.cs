using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BooleanVariable
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool isTrue = input == "True";
            Console.WriteLine(isTrue?"Yes":"No");
        }
    }
}
