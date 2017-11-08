using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


public class Program
{
    public static void Main()
    {
        string inputText = Console.ReadLine();
        var placeholders = Console.ReadLine().Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        string pattern = @"([a-zA-Z]+)(.+)\1";

        int indexPlacehoder = 0;
        StringBuilder sb = new StringBuilder(inputText);
        MatchCollection matches = Regex.Matches(inputText, pattern);

        foreach (Match m in matches)
        {

            if (indexPlacehoder >= placeholders.Count) break;

            var firstIndex = m.Groups[2].Index;
            if (firstIndex != inputText.LastIndexOf(m.Groups[2].Value))
            {
                sb.Replace(m.Groups[2].Value, placeholders[indexPlacehoder], firstIndex, m.Groups[2].Value.Length);
            }
            else sb.Replace(m.Groups[2].Value, placeholders[indexPlacehoder]);

            indexPlacehoder++;

        }

        Console.WriteLine(sb.ToString());
    }
}



