using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _02_CommandInterpreter
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { " ", "  ", "\t" }, StringSplitOptions.RemoveEmptyEntries)
                //.Select(int.Parse)
                .ToList();

            string inputCommand;

            while ((inputCommand = Console.ReadLine()) != "end")
            {
                var inputArr = inputCommand.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string command = inputArr[0].ToLower();

                switch (command)
                {
                    case "reverse":
                        {
                            int index = int.Parse(inputArr[2]);
                            int count = int.Parse(inputArr[4]);
                            if (!IsInputValid(index, count, numbers))
                            {
                                Console.WriteLine("Invalid input parameters.");
                                break;
                            }
                            Reverse(index, count, numbers);

                        }
                        break;
                    case "sort":
                        {
                            int index = int.Parse(inputArr[2]);
                            int count = int.Parse(inputArr[4]);
                            if (!IsInputValid(index, count, numbers))
                            {
                                Console.WriteLine("Invalid input parameters.");
                                break;
                            }
                            numbers = SortList(index, count, numbers);

                        }
                        break;
                    case "rollleft":
                        {
                            int count = int.Parse(inputArr[1]);
                            if (count < 0)
                            {
                                Console.WriteLine("Invalid input parameters.");
                                break;
                            }
                            RollLeft(count, numbers);

                        }
                        break;
                    case "rollright":
                        {
                            int count = int.Parse(inputArr[1]);
                            if (count < 0)
                            {
                                Console.WriteLine("Invalid input parameters.");
                                break;
                            }
                            RollRight(count, numbers);

                        }
                        break;


                }
            }

            Console.WriteLine($"[{String.Join(", ", numbers)}]");
        }

        public static bool IsInputValid(int index, int count, List<string> numbers)
        {
            if ((index < 0 || index >= numbers.Count) || (index + count) > numbers.Count 
                || index < 0 || count < 0)
            {
                return false;
            }
            return true;
        }

        public static void Reverse(int index, int count, List<string> numbers)
        {
            numbers.Reverse(index, count);

        }

        public static List<string> SortList(int index, int count, List<string> numbers)
        {
            var sorted = numbers.GetRange(index, count).OrderBy(str => str);
            numbers.RemoveRange(index, count);
            numbers.InsertRange(index,sorted);
            return numbers;

        }

        public static void RollLeft(int count, List<string> numbers)
        {
            for (int i = 1; i <= count%numbers.Count; i++)
            {
                var firsIndex = numbers[0];
                for (int j = 1; j < numbers.Count; j++)
                {
                    numbers[j - 1] = numbers[j];
                }
                numbers[numbers.Count - 1] = firsIndex;
            }


        }

        public static void RollRight(int count, List<string> numbers)
        {
            for (int i = 1; i <= count%numbers.Count; i++)
            {
                var lastIndex = numbers[numbers.Count - 1];
                for (int j = numbers.Count - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = lastIndex;
            }
        }
    }
}
