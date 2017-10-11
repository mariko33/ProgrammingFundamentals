using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14MagicLetter
{
    class Program
    {
        static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());
            
            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        string result = $"{i}{j}{k}";
                        if (!result.Contains(skip))
                        {
                            Console.Write($"{result} ");
                        }
                        

                    }
                }
            }
        }
    }
}
