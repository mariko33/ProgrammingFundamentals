using System;
using System.Collections.Generic;


namespace _04_FixEmails
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, string> emailsList = new Dictionary<string, string>();
            List<string> curr = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                curr.Add(input);
            }

            for (int i = 0; i < curr.Count - 1; i++)
            {
                if (!curr[i+1].ToLower().EndsWith("us")&&!curr[i+1].ToLower().EndsWith("uk"))
                {
                    emailsList.Add(curr[i],curr[i+1]);
                }
                i = i + 1;
            }
            foreach (var pair in emailsList)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
