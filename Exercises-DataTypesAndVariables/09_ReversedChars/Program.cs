using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ReversedChars
{
    class Program
    {
        static void Main()
        {
            char firlstLetter = char.Parse(Console.ReadLine());
            char secondLetter= char.Parse(Console.ReadLine());
            char thirdLetter= char.Parse(Console.ReadLine());
            Console.WriteLine($"{thirdLetter}{secondLetter}{firlstLetter}");
        }
    }
}
