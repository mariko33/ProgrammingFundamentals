using System;
using System.Collections.Generic;
using System.Linq;


namespace _05_ArrayManipulator
{
    public class Program // 91/100 time limit
    {
        public static void Main()
        {
            List<int> listInput = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            bool isRunning = true;

            while (isRunning)
            {
                var inputCommand = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                
                string command = inputCommand[0];

                switch (command)
                {
                    case "add":
                        {
                            int index = int.Parse(inputCommand[1]);
                            int element = int.Parse(inputCommand[2]);
                            AddElement(index, element, listInput);
                            break;
                        }

                    case "addMany":
                        {
                            int index = int.Parse(inputCommand[1]);
                            var elements = inputCommand
                                .Skip(2)
                                .Select(int.Parse)
                                .ToArray();
                            listInput.InsertRange(index, elements);
                            break;

                        }

                    case "contains":
                        {
                            int element = int.Parse(inputCommand[1]);
                            PrintContainsElement(element, listInput);
                            break;
                        }

                    case "remove":
                        {
                            int index = int.Parse(inputCommand[1]);
                            listInput.RemoveAt(index);
                            break;
                        }

                    case "shift":
                        {
                            int position = int.Parse(inputCommand[1]);
                            ShiftElement(position, listInput);
                            break;

                        }

                    case "sumPairs":
                        {
                            SumListOnPairs(listInput);
                            break;
                        }

                    case "print":
                        {
                            Console.WriteLine($"[{String.Join(", ", listInput)}]");
                            isRunning = false;
                            break;
                        }

                }
                
            }
            
        }


        private static void SumListOnPairs(List<int> listInput)
        {
            for (int i = 0; i < listInput.Count-1; i++)
            {
                var sum = listInput[i] + listInput[i + 1];
                listInput[i] = sum;
                listInput.RemoveAt(i+1);
            }


        }

        private static void ShiftElement(int position, List<int> listInput)
        {
            position = position % listInput.Count;
            for (int i = 0; i < position; i++)
            {
                listInput.Add(listInput[0]);
                listInput.RemoveAt(0);
            }

        }

        private static void PrintContainsElement(int element, List<int> listInput)
        {
            if (listInput.Contains(element))
            {
                Console.WriteLine(listInput.IndexOf(element));
            }
            else
            {
                Console.WriteLine(-1);
            }

        }

        private static void AddElement(int index, int element, List<int> listInput)
        {
            listInput.Insert(index, element);
        }
    }
}
