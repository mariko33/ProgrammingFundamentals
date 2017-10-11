using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14_FactorialTrailingZeroes
{
    class Program
    {
        static void Main()
        {
            BigInteger input=BigInteger.Parse(Console.ReadLine());

            BigInteger factoriel = Factoriel(input);

            Console.WriteLine(CountTrailingZeros(factoriel));
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

        static int CountTrailingZeros(BigInteger input)
        {
            string inputNumber = input.ToString();
            int digit;
            int count = 1;
            int countOfZeros = 0;

            while ((digit = (int)Char.GetNumericValue(inputNumber[inputNumber.Length - count]))==0)
            {
                count++;
                countOfZeros += 1;
            }

            return countOfZeros;
        }
    }
}
