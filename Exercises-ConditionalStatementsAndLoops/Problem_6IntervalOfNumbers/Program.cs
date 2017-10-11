using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6IntervalOfNumbers
{
    class Program
    {
        static void Main()
        {
            int firsInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int maxNumber = Math.Max(firsInput, secondInput);
            int minNumber = Math.Min(firsInput, secondInput);

            for (int i = minNumber; i <= maxNumber; i++)
            {
                Console.WriteLine(i);
            }
            

        }
    }
}
