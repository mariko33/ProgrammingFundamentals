using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace _07_QueryMess
{
    public class StartUp
    {
        public static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                Dictionary<string, string> queries = new Dictionary<string, string>();

                string pattern = @"([^&?]+)=([^&?]+)";
                string whiteSpacePattern = @"(%20|\+)+";

                var queriCollection = Regex.Matches(input, pattern);
                foreach (Match match in queriCollection)
                {

                    Regex reg = new Regex(whiteSpacePattern);

                    string queryKey = reg.Replace(match.Groups[1].Value, " ").Trim();
                    string queryValue = reg.Replace(match.Groups[2].Value, " ")
                        .Trim();

                    if (queries.Keys.Contains(queryKey))
                    {
                        queries[queryKey] += $", {queryValue}";
                    }
                    else
                    {
                        queries.Add(queryKey, queryValue);
                    }

                }

                StringBuilder sb = new StringBuilder();

                foreach (var pair in queries)
                {
                    sb.Append($"{pair.Key}=[{pair.Value}]");

                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
