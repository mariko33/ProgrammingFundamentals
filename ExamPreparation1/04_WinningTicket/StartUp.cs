using System;
using System.Text.RegularExpressions;


namespace _04_WinningTicket
{
    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"@{6,9}|#{6,9}|\${6,9}|\^{6,9}";
            string patternJackpot= @"@{10}|#{10}|\${10}|\^{10}";

            var inputArr = Console.ReadLine().Split(new[] {",", " "}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var input in inputArr)
            {
                if (input.Length==20)
                {
                    string leftPart = input.Substring(0, 10);
                    string rightPart = input.Substring(10,10);

                    if (Regex.IsMatch(leftPart,patternJackpot)&&Regex.IsMatch(rightPart,patternJackpot)&&leftPart==rightPart)
                    {
                        Console.WriteLine($"ticket \"{input}\" - 10{input[0]} Jackpot!");
                    }
                    else if (Regex.IsMatch(leftPart,pattern)&&Regex.IsMatch(rightPart,pattern)&&leftPart[5]==rightPart[5])
                    {
                        var leftMatch = Regex.Match(leftPart, pattern);
                        var rightMatch = Regex.Match(rightPart, pattern);
                        char winningSymbol = input[5];
                        int minMatch = Math.Min(leftMatch.Value.Length, rightMatch.Value.Length);
                        
                        Console.WriteLine($"ticket \"{input}\" - {minMatch}{winningSymbol}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{input}\" - no match");
                    }
                    

                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
                
            }
            

        }
    }
}
