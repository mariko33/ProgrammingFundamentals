using System;
using System.Collections.Generic;
using System.Linq;


namespace _07_BombNumbers
{
   public class Program
    {
        public static void Main()
        {
            var listInput = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var bombArr = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < listInput.Count; i++)
            {
                if (listInput[i]==bombArr[0])
                {
                    int left = Math.Max((i - bombArr[1]), 0);
                    int right = Math.Min((i + bombArr[1]), listInput.Count - 1);
                    int len = right - left + 1;
                    listInput.RemoveRange(left,len);
                    i--;

                }
                
            }

            // --other way--
            //int bombIndex = listInput.IndexOf(bombArr[0]);
            //while (bombIndex != -1)
            //{
            //    int left = Math.Max(bombIndex - bombArr[1], 0);
            //    int right = Math.Min(bombIndex + bombArr[1], listInput.Count - 1);
            //    int len = right - left + 1;
            //    listInput.RemoveRange(left, len);

            //    bombIndex = listInput.IndexOf(bombArr[0]);
            //}

            Console.WriteLine(listInput.Sum());
        }
    }
}
