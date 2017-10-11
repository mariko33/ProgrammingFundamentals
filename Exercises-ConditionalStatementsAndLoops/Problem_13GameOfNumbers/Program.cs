using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13GameOfNumbers
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int magicFirst = 0;
            int magicSecond = 0;
            int countOfCombination = 0;
            int sumOfCombination = 0;
            int magicCombination = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    sumOfCombination = i + j;
                    countOfCombination++;
                    
                    if (sumOfCombination==magicNumber)
                    {
                        magicFirst = i;
                        magicSecond = j;
                        magicCombination = sumOfCombination;
                    }
                }
            }

            if (magicCombination==0)
            {
                Console.WriteLine($"{countOfCombination} combinations - neither equals {magicNumber}");
            }
            else
            {
                Console.WriteLine($"Number found! {magicFirst} + {magicSecond} = {magicNumber}");
            }

        }
    }
}
