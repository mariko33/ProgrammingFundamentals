using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_FastPrimeChecker
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            for (int firstInRange = 2; firstInRange <= input; firstInRange++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(firstInRange); i++)
                {
                    if (firstInRange % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{firstInRange} -> {isPrime}");
            }
        }
    }
}
