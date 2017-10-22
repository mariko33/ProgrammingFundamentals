using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SumReversedNumbers
{
   public class Program
    {
      public static void Main()
      {
          var input = Console.ReadLine()
              .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
              .ToList();
          int result = 0;
          for (int i = 0; i < input.Count; i++)
          {
              result += ReverceNumber(input[i]);
          }
          Console.WriteLine(result);

      }

        public static int ReverceNumber(string input)
        {
            string curr = "";
            for (int i = input.Length-1; i >= 0; i--)
            {
                curr += input[i];
            }
            return int.Parse(curr);
        }
    }
   
}
