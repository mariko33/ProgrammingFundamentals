using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PrimeChecker
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            if (number == 0 || number == 1)
            {
                Console.WriteLine(false);
            }
            else
            {
                if (isPrime(number))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        private static bool isPrime(long n)
        {
            //int k = 2;
            //while (k * k <= n)
            //{
            //    if (n % k == 0)
            //    {
            //        return false;
            //    }
            //    k++;
            //}

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        

    }
}
