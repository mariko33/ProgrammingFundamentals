using System;
using System.Linq;


namespace _02_ArrayManipulator
{
    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                var inputArr = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string command = inputArr[0];
                switch (command)
                {
                    case "exchange":
                        {
                            int index = int.Parse(inputArr[1]);
                            if (index < 0 || index >= inputList.Count)
                            {
                                Console.WriteLine("Invalid index");
                                break;
                            }
                            var currList = inputList.Skip(index + 1).Take(inputList.Count - 1 - index).ToList();
                            inputList.RemoveRange(index + 1, (inputList.Count - 1 - index));
                            inputList.InsertRange(0, currList);
                        }
                        break;
                    case "max":
                        {
                            string wichMax = inputArr[1];
                            if (wichMax == "odd")
                            {
                                int maxOdd = Int32.MinValue;
                                int maxIndex = -1;
                                for (int i = 0; i < inputList.Count; i++)
                                {
                                    if (inputList[i] % 2 != 0)
                                    {
                                        if (maxOdd <= inputList[i])
                                        {
                                            maxOdd = inputList[i];
                                            maxIndex = i;
                                        }
                                    }
                                }
                                if (maxIndex != -1) Console.WriteLine(maxIndex);
                                else Console.WriteLine("No matches");


                            }
                            else
                            {
                                int maxEven = Int32.MinValue;
                                int maxIndex = -1;
                                for (int i = 0; i < inputList.Count; i++)
                                {
                                    if (inputList[i] % 2 == 0)
                                    {
                                        if (maxEven <= inputList[i])
                                        {
                                            maxEven = inputList[i];
                                            maxIndex = i;
                                        }
                                    }
                                }
                                if (maxIndex != -1) Console.WriteLine(maxIndex);
                                else Console.WriteLine("No matches");
                            }
                        }
                        break;
                    case "min":
                        {
                            string wichMin = inputArr[1];
                            if (wichMin == "odd")
                            {
                                int minOdd = Int32.MaxValue;
                                int minIndex = -1;
                                for (int i = 0; i < inputList.Count; i++)
                                {
                                    if (inputList[i] % 2 != 0)
                                    {
                                        if (minOdd >= inputList[i])
                                        {
                                            minOdd = inputList[i];
                                            minIndex = i;
                                        }
                                    }
                                }
                                if (minIndex != -1) Console.WriteLine(minIndex);
                                else Console.WriteLine("No matches");
                            }
                            else
                            {
                                int minEven = Int32.MaxValue;
                                int minIndex = -1;
                                for (int i = 0; i < inputList.Count; i++)
                                {
                                    if (inputList[i] % 2 == 0)
                                    {
                                        if (minEven >= inputList[i])
                                        {
                                            minEven = inputList[i];
                                            minIndex = i;
                                        }
                                    }
                                }
                                if (minIndex != -1) Console.WriteLine(minIndex);
                                else Console.WriteLine("No matches");
                            }
                        }
                        break;
                    case "first":
                        {
                            int countTake = int.Parse(inputArr[1]);
                            string wichTake = inputArr[2];
                            if (countTake > inputList.Count)
                            {
                                Console.WriteLine("Invalid count");
                                break;
                            }
                            if (wichTake == "odd")
                            {
                                var oddArr = inputList.Where(n => n % 2 != 0).ToList();      //inputList.Where(n => n % 2 != 0).ToList();
                                if (oddArr.Count >= countTake) Console.WriteLine($"[{string.Join(", ", oddArr.Take(countTake))}]");
                                else if (oddArr.Count > 0 && oddArr.Count < countTake) Console.WriteLine($"[{string.Join(", ", oddArr)}]");
                                else Console.WriteLine("[]");


                            }
                            else
                            {
                                var evenArr = inputList.Where(n => n % 2 == 0).ToList();        //Enumerable.Range(0, inputList.Count).Where(i => inputList[i] % 2 == 0).ToList();-- get index with condititon 
                                if (evenArr.Count >= countTake) Console.WriteLine($"[{string.Join(", ", evenArr.Take(countTake))}]");
                                else if (evenArr.Count > 0 && evenArr.Count < countTake) Console.WriteLine($"[{string.Join(", ", evenArr)}]");
                                else Console.WriteLine("[]");
                            }
                        }
                        break;
                    case "last":
                        {
                            int countTake = int.Parse(inputArr[1]);
                            string wichTake = inputArr[2];
                            if (countTake > inputList.Count)
                            {
                                Console.WriteLine("Invalid count");
                                break;
                            }
                            if (wichTake == "odd")
                            {
                                var oddArr = inputList.Where(n => n % 2 != 0).ToList();
                                if (oddArr.Count >= countTake) Console.WriteLine($"[{string.Join(", ", oddArr.Skip(oddArr.Count - countTake).Take(countTake))}]");
                                else if (oddArr.Count > 0 && oddArr.Count < countTake) Console.WriteLine($"[{string.Join(", ", oddArr)}]");
                                else Console.WriteLine("[]");
                            }
                            else
                            {
                                var evenArr = inputList.Where(n => n % 2 == 0).ToList();
                                if (evenArr.Count >= countTake) Console.WriteLine($"[{string.Join(", ", evenArr.Skip(evenArr.Count - countTake).Take(countTake))}]");
                                else if (evenArr.Count > 0 && evenArr.Count < countTake) Console.WriteLine($"[{string.Join(", ", evenArr)}]");
                                else Console.WriteLine("[]");
                            }
                        }
                        break;

                }
            }

            Console.WriteLine($"[{string.Join(", ", inputList)}]");
        }
    }
}
