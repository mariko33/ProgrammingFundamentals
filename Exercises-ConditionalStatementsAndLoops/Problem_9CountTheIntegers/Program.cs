using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9CountTheIntegers
{
    class Program
    {
        static void Main()
        {
            string input;
            int count = 0;
            while ((input=Console.ReadLine()).Any(char.IsDigit))
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
