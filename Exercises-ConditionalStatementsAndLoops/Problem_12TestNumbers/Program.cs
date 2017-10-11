using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12TestNumbers
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber= int.Parse(Console.ReadLine());
            int boundarySum = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int countOfCombinations = 0;
            
            for (int i = firstNumber; i >= 1; i--)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    int tempResult = (i * j) * 3;
                    totalSum += tempResult;
                    countOfCombinations++;
                    if (totalSum >= boundarySum)
                    {
                        Console.WriteLine($"{countOfCombinations} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {boundarySum}");
                        return;
                    }

                }
            }

            
            
                Console.WriteLine($"{countOfCombinations} combinations");
                Console.WriteLine($"Sum: {totalSum}");
            

            
        }
    }
}
