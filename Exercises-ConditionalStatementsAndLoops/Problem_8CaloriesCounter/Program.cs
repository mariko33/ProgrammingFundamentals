using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            int totlaCalories = 0;
            for (int i = 0; i < numberOfInput; i++)
            {
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "cheese":
                        totlaCalories += 500;
                        break;
                    case "tomato sauce":
                        totlaCalories += 150;
                        break;
                    case "salami":
                        totlaCalories += 600;
                        break;
                    case "pepper":
                        totlaCalories += 50;
                        break;
                        default:
                            break;

                }

                
                    
            }

            Console.WriteLine($"Total calories: {totlaCalories}");

        }
    }
}
