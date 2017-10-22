using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_1ArrayManipulator
{
    public class Program // 100/100
    {
       public static void Main()
       {
           var listInput = Console.ReadLine()
               .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

           string input;

           while ((input=Console.ReadLine())!="print")
           {
               var inputArr = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
               string command = inputArr[0];
               switch (command)
               {
                    case "add":
                        listInput.Insert(int.Parse(inputArr[1]),int.Parse(inputArr[2]));
                        break;
                    case "addMany":
                        listInput.InsertRange(int.Parse(inputArr[1]), inputArr.Skip(2).Select(int.Parse));
                        break;
                    case "contains":
                        if (listInput.Contains(int.Parse(inputArr[1])))
                        {
                            Console.WriteLine(listInput.IndexOf(int.Parse(inputArr[1])));
                        }
                        else
                        {
                            Console.WriteLine(-1);
                        }
                        
                        break;
                    case "remove":
                        listInput.RemoveAt(int.Parse(inputArr[1]));
                        break;
                    case "shift":
                        int position = int.Parse(inputArr[1]);
                        position = position % listInput.Count;
                        for (int i = 0; i < position; i++)
                        {
                            listInput.Add(listInput[0]);
                            listInput.RemoveAt(0);
                        }
                        break;
                    case "sumPairs":
                        for (int i = 0; i < listInput.Count - 1; i++)
                        {
                            var sum = listInput[i] + listInput[i + 1];
                            listInput[i] = sum;
                            listInput.RemoveAt(i + 1);
                        }
                        break;
                        
                }


           }

           Console.WriteLine($"[{String.Join(", ", listInput)}]");
       }
    }
}
