using System;
using System.Collections.Generic;
using System.Linq;


namespace _03_SearchForNumber
{
    public class Program
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] arr = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numbersFromList = arr[0];
            int numbersForDelete = arr[1];
            int numberOfSearch = arr[2];

            List<int> result = input
                .Take(numbersFromList)
                .ToList();
            result.RemoveRange(0, numbersForDelete);
            int count = 0;
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == numberOfSearch)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("NO!");
            }
            else
            {
                Console.WriteLine("YES!");
            }


        }
    }
}
