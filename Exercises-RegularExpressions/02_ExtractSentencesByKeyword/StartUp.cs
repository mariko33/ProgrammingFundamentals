using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace _02_ExtractSentencesByKeyword
{
   public class StartUp
    {
        public static void Main()
        {
            string inputWord = Console.ReadLine();
            string inputText = Console.ReadLine();

            var textArr = inputText.Split(new[] {".", "!", "?"}, StringSplitOptions.RemoveEmptyEntries);

           
            foreach (var sentence in textArr)
            {
               
                var sentenceArr = Regex.Split(sentence, @"\W");
                if (sentenceArr.Contains(inputWord))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }

           
        }
    }
}
