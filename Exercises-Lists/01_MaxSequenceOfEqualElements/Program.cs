using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_MaxSequenceOfEqualElements
{
   public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int count = 1;
            int maxCount = 0;
            int maxNumber = 0;
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i]==numbers[i+1])
                {
                    count++;
                    if (maxCount<count)
                    {
                        maxCount = count;
                        maxNumber = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            if (count==1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write(maxNumber+" ");
                }
            }
        }
    }
}
