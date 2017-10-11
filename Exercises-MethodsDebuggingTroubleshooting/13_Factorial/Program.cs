using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _13_Factorial
{
    class Program
    {
        static void Main()
        {
            BigInteger input=BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(Factoriel(input));
        }

        static BigInteger Factoriel(BigInteger input)
        {
            BigInteger factoriel = 1;

            for (int i = 1; i <= input; i++)
            {
                factoriel *= i;
            }

            return factoriel;
        }
    }
}
