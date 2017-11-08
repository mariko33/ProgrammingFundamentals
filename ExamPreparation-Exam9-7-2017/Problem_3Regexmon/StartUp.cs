using System;
using System.Text.RegularExpressions;


namespace Problem_3Regexmon
{
    public class StartUp
    {
        public static void Main()
        {
            string sequence = Console.ReadLine();

            string didiPattern= @"([^a-zA-Z\-]+)";
            string bojoPatern= @"[a-zA-Z]+\-[a-zA-Z]+";

            bool isRunning = true;

            while (isRunning)
            {
                if (!Regex.IsMatch(sequence,didiPattern))
                {
                    isRunning = false;
                    continue;
                }
                Match didiMatch = Regex.Match(sequence, didiPattern);
                sequence = sequence.Substring(didiMatch.Index + didiMatch.Value.Length);
                Console.WriteLine(didiMatch.Value);

                if (!Regex.IsMatch(sequence,bojoPatern))
                {
                    isRunning = false;
                    continue;
                }
                Match bojoMatch = Regex.Match(sequence, bojoPatern);
                sequence = sequence.Substring(bojoMatch.Index + bojoMatch.Value.Length);
                Console.WriteLine(bojoMatch.Value);
                
                

            }

        }
    }
}
