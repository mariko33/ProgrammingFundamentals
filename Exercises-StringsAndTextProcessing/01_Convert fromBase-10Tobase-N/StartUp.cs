using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01_Convert_fromBase_10Tobase_N
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var inputArr = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();

            BigInteger baseConvert = inputArr[0];
            BigInteger decBase = inputArr[1];

            string result=String.Empty;

            while (decBase>0)
            {
                var reminder = decBase % baseConvert;
                result = reminder + result;
                decBase = decBase / baseConvert;
            }

            Console.WriteLine(result);
        }
    }
}
