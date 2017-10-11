using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EnglishNameOfLastDigit
{
    class Program
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(PrintNameOfLastDigit(input));
        }

        public static string PrintNameOfLastDigit(long input)
        {
            int digit = (int)Math.Abs(input % 10);
            switch (digit)
            {
                case 0:
                    return "zero";
                    break;
                case 1:
                    return "one";
                    break;
                case 2:
                    return "two";
                    break;
                case 3:
                    return "three";
                    break;
                case 4:
                    return "four";
                    break;
                case 5:
                    return "five";
                    break;
                case 6:
                    return "six";
                    break;
                case 7:
                    return "seven";
                    break;
                case 8:
                    return "eight";
                    break;
                case 9:
                    return "nine";
                    break;
                    default: return "Wrong digit";
                        break;

            }
        }
        
    }
}
