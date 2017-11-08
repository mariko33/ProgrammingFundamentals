using System;
using System.Text.RegularExpressions;

namespace _01_ExtractEmails
{
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]{1,}([-.]\w*)*(\.[a-z]{1,})";

            Regex regex=new Regex(pattern);
            var contains = regex.Matches(input);

            foreach (Match match in contains)
            {
                Console.WriteLine(match);
            }
        }
        
    }
}
