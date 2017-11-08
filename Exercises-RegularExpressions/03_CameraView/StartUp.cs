using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _03_CameraView
{
    public class StartUp
    {
        public static void Main()
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skip = elements[0];
            int take = elements[1];
            string pattern = @"\|<(\w{" + skip + @"})(\w{0," + take + "})";
            string input = Console.ReadLine();
            MatchCollection matchedResult = Regex.Matches(input, pattern);
            List<string> result = new List<string>();
            foreach (Match m in matchedResult)
            {
                result.Add(m.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", result));


        }
    }
}
