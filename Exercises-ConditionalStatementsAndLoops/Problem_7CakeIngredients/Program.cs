using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int countOfIngredients = 0;
            while ((input=Console.ReadLine())!= "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                countOfIngredients++;
            }

            Console.WriteLine($"Preparing cake with {countOfIngredients} ingredients.");
        }
    }
}
