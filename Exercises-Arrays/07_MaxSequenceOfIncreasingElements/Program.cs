using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MaxSequenceOfIncreasingElements
{
    public class Program
    {
       public static void Main()
       {
           int[] arr = Console.ReadLine()
               .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

           int currentLength = 1;
           List<int> start = new List<int>();

           int maxLength = 1;
           List<int>bestNumbers=new List<int>();
           start.Add(arr[0]);

           for (int i = 1; i < arr.Length; i++)
           {
               if (arr[i]>arr[i-1])
               {
                    currentLength++;
                    start.Add(arr[i]);
                   

               }
               
               else
               {
                   currentLength = 1;
                   start.Clear();
                   start.Add(arr[i]);
               }

               if (currentLength>maxLength)
               {
                   bestNumbers.Clear();
                   maxLength = currentLength;
                   bestNumbers.AddRange(start);
               }
           }

           if (maxLength==1)
           {
               Console.WriteLine(arr[0]);
               return;
           }

           Console.WriteLine(string.Join(" ",bestNumbers));

       }
    }
}
