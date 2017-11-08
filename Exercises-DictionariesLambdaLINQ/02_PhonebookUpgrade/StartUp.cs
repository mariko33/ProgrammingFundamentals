using System;
using System.Collections.Generic;
using System.Linq;


namespace _02_PhonebookUpgrade
{
   public class StartUp
    {
        public static void Main()
        {
            string input;
            SortedDictionary<string, string> phonebook = new SortedDictionary<string,string>();
            while ((input = Console.ReadLine()) != "END")
            {
                var inputList = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string command = inputList[0];
                switch (command)
                {
                    case "A":
                        try
                        {
                            phonebook.Add(inputList[1], inputList[2]);
                        }
                        catch (Exception e)
                        {
                            phonebook[inputList[1]] = inputList[2];
                        }
                        break;
                    case "S":
                        if (phonebook.ContainsKey(inputList[1]))
                        {
                            Console.WriteLine($"{inputList[1]} -> {phonebook[inputList[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {inputList[1]} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (var pair in phonebook)
                        {
                            Console.WriteLine($"{pair.Key} -> {pair.Value}");
                        }
                        break;
                }
            }
        }
    }
}
