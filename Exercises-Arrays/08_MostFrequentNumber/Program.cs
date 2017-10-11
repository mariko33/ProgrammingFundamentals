using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MostFrequentNumber
{
    public class Program
    {
      public static void Main()
      {
          int[] arr = Console.ReadLine()
              .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

          int maxCount = 1;
          int numberMostFreq = arr[0];


          for (int i = 0; i < arr.Length; i++)
          {
              int count = 0;
              for (int j = 0; j < arr.Length; j++)
              {
                  if (arr[i]==arr[j])
                  {
                      count++;

                      
                  }
                  if (maxCount < count)
                  {
                      maxCount=count;
                      numberMostFreq = arr[j];
                  }

                }
          }

          Console.WriteLine(numberMostFreq);
       
      }
    }
}
