using System;
using System.Linq;
using System.Numerics;

namespace _02_ConvertFrombase_NTobase_10
{
    public class StartUp
    {
        public static void Main()
        {
            var inputArr = Console.ReadLine().Trim().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var baseN = BigInteger.Parse(inputArr[0]);
            var numberToTen = inputArr[1];

            var numberToTenReverce = numberToTen.Reverse().ToArray();

            BigInteger result = 0;

            for (int i = 0; i < numberToTenReverce.Length; i++)
            {
                result += (BigInteger)Char.GetNumericValue(numberToTenReverce[i]) * BigInteger.Pow(baseN, i);
            }

            Console.WriteLine(result);
            
            
            
        }
    }
}
