using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_115DifferentNumbers
{
    class Program
    {
        static void Main()
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int maxInput = Math.Max(firstInput, secondInput);
            int minInput = Math.Min(firstInput, secondInput);

            if (maxInput-minInput<4)
            {
                Console.WriteLine("No");
            }

            for (int i = minInput; i <= maxInput; i++)
            {
                for (int j = minInput; j <= maxInput; j++)
                {
                    for (int k = minInput; k <= maxInput; k++)
                    {
                        for (int l = minInput; l <= maxInput; l++)
                        {
                            for (int m = minInput; m <= maxInput; m++)
                            {
                                if (i<j && j<k && k<l &&l<m)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
           
        }
    }
}
