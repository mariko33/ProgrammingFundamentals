using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ChangeList
{
   public class Program
    {
       public static void Main()
       {
           List<int> numbers = Console.ReadLine()
               .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
           string input = Console.ReadLine();
           while (input!= "Even"&& input!= "Odd")
           {
               var arrInput = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
               string command = arrInput[0];
               switch (command)
               {
                    case "Delete":
                        int element = int.Parse(arrInput[1]);
                        numbers.RemoveAll(e=>e==element);
                        break;
                    case "Insert":
                        element = int.Parse(arrInput[1]);
                        int position = int.Parse(arrInput[2]);
                        numbers.Insert(position,element);
                        break;
               }

               input = Console.ReadLine();

           }
           if (input == "Even")
           {
               for (int i = 0; i < numbers.Count; i++)
               {
                   if (numbers[i] % 2 == 0)
                   {
                       Console.Write(numbers[i] + " ");
                   }
               }
           }

           if (input == "Odd")
           {
               for (int i = 0; i < numbers.Count; i++)
               {
                   if (numbers[i] % 2 != 0)
                   {
                       Console.Write(numbers[i] + " ");
                   }
               }
           }
        }
    }
}
