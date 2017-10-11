using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class Program
    {
        static void Main()
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            string thirdNumber = Console.ReadLine();
            string forthNumber = Console.ReadLine();

            Console.WriteLine($"{GetNumber(firstNumber)} {GetNumber(secondNumber)} {GetNumber(thirdNumber)} {GetNumber(forthNumber)}");
            


        }

        private static string GetNumber(string input)
        {
            int inputNumber = int.Parse(input);
            
                return $"{inputNumber:d4}";
            
        }
    }
    
    
}
