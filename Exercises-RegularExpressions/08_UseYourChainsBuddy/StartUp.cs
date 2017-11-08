using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08_UseYourChainsBuddy
{
    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"<p>(.*?)<\/p>";
            string whitespacePattern= @"[^a-z0-9]+";

            string input = Console.ReadLine();

            var paragraphCollection = Regex.Matches(input, pattern);
            
            List<string>textList=new List<string>();
            List<string>decriptedText=new List<string>();
            
            foreach (Match m in paragraphCollection)
            {
                Regex reg=new Regex(whitespacePattern);
                string text = reg.Replace(m.Groups[1].Value, " ");
                textList.Add(text.Replace(@"\s+"," "));
            }

            int difference = 13;
            foreach (var element in textList)
            {
                string elementNew = String.Empty;
                
                for (int i = 0; i < element.Length; i++)
                {
                    char replacement=element[i];
                    
                    if (element[i]>=97&&element[i]<=109)
                    {
                        replacement += (char) difference; 

                    }
                    else if(element[i] >= 110 && element[i] <= 122)
                    {
                        replacement -= (char) difference; 

                    }
                    

                    elementNew += replacement;

                }
                
                decriptedText.Add(elementNew);
                
            }

            Console.WriteLine(String.Join(String.Empty,decriptedText));
        }
    }
}
