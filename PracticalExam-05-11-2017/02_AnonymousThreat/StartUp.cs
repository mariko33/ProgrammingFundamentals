using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var inputArr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        string inputCommand;
        while ((inputCommand = Console.ReadLine()) != "3:1")
        {
            var commandArr = inputCommand.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string command = commandArr[0];

            switch (command)
            {
                case "merge":
                    {
                        int startIndex = int.Parse(commandArr[1]);
                        int endIndex = int.Parse(commandArr[2]);
                        if (startIndex < 0 || startIndex >= inputArr.Count) startIndex = 0;
                        if (endIndex < 0 || endIndex >= inputArr.Count) endIndex = inputArr.Count - 1;

                        string merged = "";
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            merged += inputArr[i];
                        }

                        inputArr.RemoveRange(startIndex, (endIndex + 1 - startIndex));
                        inputArr.Insert(startIndex, merged);
                    }
                    break;
                case "divide":
                    {
                        int index = int.Parse(commandArr[1]);
                        int partititons = int.Parse(commandArr[2]);

                        string str = inputArr[index];

                        int substLength = str.Length / partititons;
                        List<string> dividedList = new List<string>();

                        int index1 = 0;

                        while (index1 < str.Length)
                        {
                            string res = "";
                            for (int i = 0; i < substLength; i++)
                            {
                                if (str.Substring(index1).Length == substLength + str.Length % partititons)
                                {
                                    res += str.Substring(index1);
                                    i += substLength;
                                    index1 = str.Length;
                                    continue;
                                }

                                res += str[index1];
                                index1++;




                            }

                            dividedList.Add(res);

                        }

                        inputArr.RemoveAt(index);
                        inputArr.InsertRange(index, dividedList);

                    }
                    break;
            }

        }

        Console.WriteLine(string.Join(" ", inputArr));
    }
}

