using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace _06_ValidUsernames
{
   public class StartUp
    {
        public static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split(new[] { " ", "/", "\\", "(", ")", ","}, StringSplitOptions.RemoveEmptyEntries);


           // string pattern = @"^[a-zA-Z][\w]{2,25}";
            string pattern = @"\b[A-Za-z]\w{2,24}\b";

            List<string> usersList = new List<string>();

            foreach (var input in inputArr)
            {
                if (Regex.IsMatch(input,pattern))
                {
                    usersList.Add(input);
                }
            }

            int maxLength = 0;
            int maxPosition = 0;
            for (int i = 0; i < usersList.Count - 1; i++)
            {
                int currentLengh = usersList[i].Length + usersList[i + 1].Length;
                if (maxLength < currentLengh)
                {
                    maxLength = currentLengh;
                    maxPosition = i;
                }
            }

            Console.WriteLine(usersList[maxPosition]);
            Console.WriteLine(usersList[maxPosition + 1]);
        }

    }
}
