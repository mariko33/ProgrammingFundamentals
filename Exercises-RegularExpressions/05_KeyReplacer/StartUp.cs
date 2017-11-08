using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _05_KeyReplacer
{
    public class StartUp
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            string startKeyPattern = @"^([a-zA-Z]*)[\<|\||\\]";
            string endKeyPattern = @"[\<|\||\\]([a-zA-Z]*)";

            string keyPattern = @"^(?<startKey>[a-zA-Z]*)[\<|\||\\](?:.+)[\<|\||\\](?<endKey>[a-zA-Z]*)";

            var keyMatch = Regex.Match(key, keyPattern);

            if (keyMatch.Success)
            {
                string start = keyMatch.Groups["startKey"].Value;
                string end = keyMatch.Groups["endKey"].Value;

                string pattern = $@"{start}(.*?){end}";

                var resultCollection = Regex.Matches(text, pattern);
                string result = String.Empty;

                foreach (Match m in resultCollection)
                {
                    result += m.Groups[1].Value;
                }

                Console.WriteLine(result.Length == 0 ? "Empty result" : result);

            }

        }
    }
}
