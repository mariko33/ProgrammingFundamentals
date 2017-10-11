using System;
using System.Linq;


namespace _10_PairsByDifference
{
   public class Program
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int difference = int.Parse(Console.ReadLine());
            int countDifference = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j <= arr.Length-1; j++)
                {
                    int current = (arr[i]) - (arr[j]);
                    if (Math.Abs(current)==difference)
                    {
                        countDifference++;
                    }
                }
            }

            Console.WriteLine(countDifference);
        }
    }
}
